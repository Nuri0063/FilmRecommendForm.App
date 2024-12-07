using FilmRecommend.Data;
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
    }
}
