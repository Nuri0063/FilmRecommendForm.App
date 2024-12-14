using FilmRecommend.Data;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static FilmRecommend.Data.FilmMoodDBContext;

namespace FilmRecommendForm.App
{
    public partial class MovieListForm : Form
    {
        private int selectedMovieId;
          private int _MainCategoryId;
        private int _SubCategoryId;

        private string _username;
        private bool _isAdmin;
        public MovieListForm(int selectedMainCategoryId, int selectedSubCategoryId, string username, bool isAdmin)
        {
            InitializeComponent();
            LoadMovies(selectedMainCategoryId, selectedSubCategoryId);
            _username = username;
            _isAdmin = isAdmin;

            _MainCategoryId = selectedMainCategoryId;
            _SubCategoryId = selectedSubCategoryId;

        label1.Text = $"Hoş Geldiniz, {_username}";

            btnAddMovie.Visible = _isAdmin;
            btnEditMovie.Visible = _isAdmin;
            btnDeleteMovie.Visible = _isAdmin;


        }



        private void LoadMovies(int categoryId, int subCategoryId)
        {
            var context = Program.DbContext;
            // Filmleri getir ve listele

            var movies = context.Movies
                    .Where(m => m.SubCategory.MovieCategoryID == categoryId && m.MovieSubCategoryID == subCategoryId)
                    .Select(m => new
                    {
                        m.MovieID,
                        m.MovieName,
                        m.Rating,
                        m.Director,
                        m.LeadingActor,
                        m.ReleaseYear


                    })
                    .ToList();


                dgvMovies.DataSource = movies; // DataGridView'e bağla

                // MovieID ve Rating kolonlarını gizle
                dgvMovies.Columns["MovieID"].Visible = false;
                dgvMovies.Columns["Rating"].Visible = false;
                dgvMovies.Columns["Director"].Visible = false;
                dgvMovies.Columns["LeadingActor"].Visible = false;
                dgvMovies.Columns["ReleaseYear"].Visible = false;

                // MovieName kolonunun başlığını ayarla
                dgvMovies.Columns["MovieName"].HeaderText = "Film Adı";
                dgvMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMovies.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                dgvMovies.BorderStyle = BorderStyle.None;
                dgvMovies.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;






            
        }

        private void MovieListForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnShowGraph_Click(object sender, EventArgs e)
        {
            // Rating bilgilerini ve film isimlerini bir dictionary içinde saklıyoruz
            Dictionary<string, double> movieRatings = new Dictionary<string, double>();

            foreach (DataGridViewRow row in dgvMovies.Rows)
            {
                if (row.Cells["MovieName"].Value != null && row.Cells["Rating"].Value != null)
                {
                    string movieName = row.Cells["MovieName"].Value.ToString();
                    double rating = Convert.ToDouble(row.Cells["Rating"].Value);

                    // Filmi ve puanını dictionary'e ekle
                    if (!movieRatings.ContainsKey(movieName))
                    {
                        movieRatings[movieName] = rating;
                    }
                }
            }

            // Grafiği oluştur
            Chart chart = new Chart
            {
                Dock = DockStyle.Fill
            };
            ChartArea chartArea = new ChartArea("Film Puan Grafiği");
            chart.ChartAreas.Add(chartArea);

            Series series = new Series("Filmler ve Puanları")
            {
                ChartType = SeriesChartType.Column
            };

            // Dictionary'deki her filmi grafiğe ekle
            foreach (var movie in movieRatings)
            {
                series.Points.AddXY(movie.Key, movie.Value);
            }

            chart.Series.Add(series);

            // Grafiği yeni bir formda göster
            Form graphForm = new Form
            {
                Text = "Film Puan Grafiği",
                Width = 800,
                Height = 600
            };
            graphForm.Controls.Add(chart);
            graphForm.Show();
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            // itex7  ardıdan itex7.bouncy-castle-adapter eklentilerini ekleyerek bu kod yazıldı ve işlem tamammlandı
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // PDF yazıcısını oluştur
                    using (var writer = new PdfWriter(saveFileDialog.FileName)) // Burada dosya adını geçiriyoruz
                    using (var pdf = new PdfDocument(writer)) // PdfDocument'ı oluşturuyoruz
                    {
                        var document = new Document(pdf);
                        document.Add(new Paragraph("Film Bilgileri").SetTextAlignment(TextAlignment.CENTER)); // Başlık ekle

                        // DataGridView'deki verileri PDF'ye ekle
                        foreach (DataGridViewRow row in dgvMovies.Rows)
                        {
                            if (row.IsNewRow) continue; // Yeni satırı atla
                            string movieDetails = $"Film Adı: {row.Cells["MovieName"].Value}, " +
                                                  $"Yönetmen: {row.Cells["Director"].Value}, " +
                                                  $"Çıkış Yılı: {row.Cells["ReleaseYear"].Value}, " +
                                                  $"Başrol: {row.Cells["LeadingActor"].Value}, " +
                                                  $"IMDB Puanı: {row.Cells["Rating"].Value}";
                            document.Add(new Paragraph(movieDetails)); // Film detaylarını ekle
                        }

                        document.Close(); // PDF dökümanını kapat
                    }
                }
            }
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            try
            {
                var usermail = txtEmail.Text;
                // DataGridView'dan film bilgilerini toplama
                StringBuilder filmDetailsBuilder = new StringBuilder();
                filmDetailsBuilder.AppendLine("Film Bilgileri:\n");

                // DataGridView'daki her satırı dolaşma
                foreach (DataGridViewRow row in dgvMovies.Rows)
                {
                    if (row.Cells["MovieName"].Value != null && row.Cells["Director"].Value != null)
                    {
                        // Film bilgilerini al
                        string filmTitle = row.Cells["MovieName"].Value.ToString();
                        string filmDirector = row.Cells["Director"].Value.ToString();
                        int releaseYear = Convert.ToInt32(row.Cells["ReleaseYear"].Value); // Yıl hücresinin ismi "Yıl" olarak varsayılmıştır.

                        // Bilgileri ekle
                        filmDetailsBuilder.AppendLine($"Film Adı: {filmTitle}");
                        filmDetailsBuilder.AppendLine($"Yönetmen: {filmDirector}");
                        filmDetailsBuilder.AppendLine($"Yıl: {releaseYear}");
                        filmDetailsBuilder.AppendLine(); // Boş bir satır ekle
                    }
                }

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("nurii6345@gmail.com", "vkew qukv lgev dabl"), // Uygulama şifresini buraya ekleyin
                    EnableSsl = true,
                };

                // E-posta gönderim işlemi
                smtpClient.Send("nurii6345@gmail.com", usermail, "Film Bilgileri", filmDetailsBuilder.ToString());
                MessageBox.Show("E-posta başarıyla gönderildi!");
            }
            catch (SmtpException smtpEx)
            {
                MessageBox.Show($"SMTP Hatası: {smtpEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }

        private void dgvMovies_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvMovies.SelectedRows.Count > 0)
            {
                int selectedMovieId = (int)dgvMovies.SelectedRows[0].Cells["MovieID"].Value;

                // MovieDetailsForm'u aç ve ID'yi gönder
                MovieDetailsFormcs detailsForm = new MovieDetailsFormcs(selectedMovieId,_username);
                detailsForm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectionForm categoryForm = new SelectionForm(_username,_isAdmin);
            categoryForm.Show();
            this.Close();
        }






        private void dgvMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMovies_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMovies.SelectedRows.Count > 0)
            {
                selectedMovieId = (int)dgvMovies.SelectedRows[0].Cells["MovieID"].Value;
            }
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            AddMovieForm addMovieForm = new AddMovieForm(_MainCategoryId,_SubCategoryId);
            addMovieForm.ShowDialog();
            LoadMovies(_MainCategoryId, _SubCategoryId); // Yeni filmleri yükle
        }

        private void btnEditMovie_Click(object sender, EventArgs e)
        {
            if (selectedMovieId != 0)
            {
                EditMovieForm editMovieForm = new EditMovieForm(selectedMovieId);
                editMovieForm.ShowDialog();
                LoadMovies(_MainCategoryId, _SubCategoryId);
            }
            else
            {
                MessageBox.Show("Lütfen düzenlenecek bir film seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            var context = Program.DbContext;
            if (selectedMovieId != 0)
                {
                    DialogResult result = MessageBox.Show("Bu filmi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        // Film silme işlemi
                        var movie = context.Movies.Find(selectedMovieId);
                        if (movie != null)
                        {
                            context.Movies.Remove(movie);
                            context.SaveChanges();
                            MessageBox.Show("Film başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadMovies(_MainCategoryId, _SubCategoryId);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silinecek bir film seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
        }
    }
}
