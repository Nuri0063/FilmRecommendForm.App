using FilmRecommend.Data;
using FilmRecommend.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmRecommendForm.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CustomizeComponents(); // Özelleştirmek için bileşenleri ayarlıyoruz.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void CustomizeComponents() // Bileşenleri özelleştiren metot.
        {
            // Formun arka plan rengini ayarlıyoruz.
            this.BackColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Form kenar stilini ayarlıyoruz.

            // Film kategorileri ComboBox'ını özelleştiriyoruz.
            comboBoxMovieCategories.DropDownStyle = ComboBoxStyle.DropDownList; // Sadece liste öğelerinden seçim yapmasını sağlıyoruz.
            comboBoxMovieCategories.ForeColor = System.Drawing.Color.Black; // Yazı rengini siyah yapıyoruz.

            // Film alt kategorileri ComboBox'ını özelleştiriyoruz.
            comboBoxSubCategories.DropDownStyle = ComboBoxStyle.DropDownList; // Sadece liste öğelerinden seçim yapmasını sağlıyoruz.
            comboBoxSubCategories.ForeColor = System.Drawing.Color.Black; // Yazı rengini siyah yapıyoruz.

            // DataGridView bileşenini özelleştiriyoruz.
            dataGridViewMovies.BackgroundColor = System.Drawing.Color.White; // Arka plan rengini beyaz yapıyoruz.
            dataGridViewMovies.BorderStyle = BorderStyle.None; // Kenarlık stilini kaldırıyoruz.
            dataGridViewMovies.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightBlue; // Başlık arka plan rengini mavi yapıyoruz.
            dataGridViewMovies.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black; // Başlık yazı rengini siyah yapıyoruz.
            dataGridViewMovies.EnableHeadersVisualStyles = false; // Başlık stilini özelleştirmeyi etkinleştiriyoruz.
        }

        private void LoadCategories() // Film kategorilerini yükleyen metot.
        {
            using (var context = new FilmMoodDBContext())
            {
                var categories = context.MovieCategories.ToList(); // Veritabanından film kategorilerini alıyoruz.
                
                comboBoxMovieCategories.DataSource = categories; // Kategorileri ComboBox'a veri kaynağı olarak bağlıyoruz.
                comboBoxMovieCategories.DisplayMember = "CategoryName"; // Görüntülenecek alanı belirliyoruz.
                comboBoxMovieCategories.ValueMember = "MovieCategoryID"; // Değerini belirliyoruz.
            }
        }

        private void comboBoxMovieCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBoxMovieCategories.SelectedValue != null) // Eğer bir değer seçilmişse
            //{
            //    // Seçilen değeri int olarak al
            //    int selectedCategoryId = (int)comboBoxMovieCategories.SelectedValue;
            //    LoadSubCategories(selectedCategoryId); // Alt kategorileri yükle
            //}
            // Kullanıcı bir kategori seçtiğinde bu metot tetiklenir
            if (comboBoxMovieCategories.SelectedItem != null) // Seçili bir öğe var mı kontrol et
            {
                // Seçilen öğeyi MovieCategory nesnesi olarak al
                var selectedCategory = (MovieCategory)comboBoxMovieCategories.SelectedItem;

                // MovieCategoryID'yi al
                int selectedCategoryId = selectedCategory.MovieCategoryID;

                // Alt kategorileri yükle
                LoadSubCategories(selectedCategoryId);
            }
        }
     

        private void LoadSubCategories(int categoryId) // Alt kategorileri yükleyen metot.
        {
            using (var context = new FilmMoodDBContext()) // Veritabanı bağlamını kullanarak açıyoruz.
            {
                var subCategories = context.MovieSubCategories // Seçilen kategoriye ait alt kategorileri alıyoruz.
                    .Where(sc => sc.MovieCategoryID == categoryId)
                    .ToList(); // Alt kategorileri listeye dönüştürüyoruz.

                comboBoxSubCategories.DataSource = subCategories; // Alt kategorileri ComboBox'a veri kaynağı olarak bağlıyoruz.
                comboBoxSubCategories.DisplayMember = "SubCategoryName"; // Görüntülenecek alanı belirliyoruz.
                comboBoxSubCategories.ValueMember = "MovieSubCategoryID"; // Değerini belirliyoruz.
            }
        }

        private void comboBoxSubCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kullanıcı bir alt kategori seçtiğinde bu metot tetiklenir
            if (comboBoxSubCategories.SelectedItem != null) // Seçili bir öğe var mı kontrol et
            {
                // Seçilen öğeyi MovieSubCategory nesnesi olarak al
                var selectedSubCategory = (MovieSubCategory)comboBoxSubCategories.SelectedItem;

                // MovieSubCategoryID'yi al
                int selectedSubCategoryId = selectedSubCategory.MovieSubCategoryID;

                // Filmleri yükle
                LoadMovies(selectedSubCategoryId);
            }
        }

        private void LoadMovies(int subCategoryId) // Filmleri yükleyen metot.
        {
            using (var context = new FilmMoodDBContext()) // Veritabanı bağlamını kullanarak açıyoruz.
            {
                var movies = context.Movies // Seçilen alt kategoriye ait filmleri alıyoruz.
                    .Where(m => m.MovieSubCategoryID == subCategoryId)
                    .ToList(); // Filmleri listeye dönüştürüyoruz.

                dataGridViewMovies.DataSource = movies; // Filmleri DataGridView'a veri kaynağı olarak bağlıyoruz.
            }
        }

        private void dataGridViewMovies_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) // DataGridView'da hücreye çift tıklandığında çağrılan metot.
        {
            if (e.RowIndex >= 0) // Eğer geçerli bir satır seçildiyse
            {
                var selectedRow = dataGridViewMovies.Rows[e.RowIndex]; // Seçilen satırı alıyoruz.
                string movieName = selectedRow.Cells["MovieName"].Value.ToString(); // Film adını alıyoruz.
                ShowMovieDetails(movieName); // Film detaylarını gösteren metodu çağırıyoruz.
            }
        }

        private void ShowMovieDetails(string movieName) // Film detaylarını gösteren metot.
        {
            using (var context = new FilmMoodDBContext()) // Veritabanı bağlamını kullanarak açıyoruz.
            {
                var movie = context.Movies.FirstOrDefault(m => m.MovieName == movieName); // Filmi adını kullanarak buluyoruz.

                if (movie != null) // Eğer film bulunursa
                {
                    // Film detaylarını bir mesaj kutusunda gösteriyoruz.
                    MessageBox.Show($"Film Adı: {movie.MovieName}\nYönetmen: {movie.Director}\nÇıkış Yılı: {movie.ReleaseYear}\nBaşrol: {movie.LeadingActor}\nIMDB Puanı: {movie.Rating}", "Film Detayları");
                }
            }
        }
    }
}
