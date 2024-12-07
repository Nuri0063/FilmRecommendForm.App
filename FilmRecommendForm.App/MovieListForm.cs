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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FilmRecommendForm.App
{
    public partial class MovieListForm : Form
    {
        public MovieListForm(int selectedMainCategoryId, int selectedSubCategoryId)
        {
            InitializeComponent();
            LoadMovies(selectedMainCategoryId, selectedSubCategoryId);
        }

        private void LoadMovies(int categoryId, int subCategoryId)
        {
            using (var context = new FilmMoodDBContext())
            {
                // Filmleri getir ve listele

                var movies = context.Movies
                    .Where(m => m.SubCategory.MovieCategoryID == categoryId && m.MovieSubCategoryID == subCategoryId)
                    .Select(m => new
                    {
                        m.MovieID,
                        m.MovieName,
                        m.Director,
                        m.LeadingActor,
                        m.ReleaseYear,
                        m.Rating
                    })
                    .ToList();

                dgvMovies.DataSource = movies; // DataGridView'e bağla
            }
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
    }
}
