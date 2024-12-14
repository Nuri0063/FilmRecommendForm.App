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
using static FilmRecommend.Data.FilmMoodDBContext;

namespace FilmRecommendForm.App
{
    public partial class EditMovieForm : Form
    {
        private int _movieId;
        public EditMovieForm(int movieId)
        {
            InitializeComponent();
            _movieId = movieId;
        }

        private void EditMovieForm_Load(object sender, EventArgs e)
        {
            var context = Program.DbContext;
            var movie = context.Movies.FirstOrDefault(m => m.MovieID == _movieId);

                if (movie != null)
                {
                    txtMovieName.Text = movie.MovieName;
                    txtLeadingActor.Text = movie.LeadingActor;
                    txtReleaseYear.Text = movie.ReleaseYear.ToString();
                    txtDirector.Text = movie.Director;
                    txtRating.Text = movie.Rating.ToString();
                    txtPosterURL.Text = movie.PosterURL;

                    var subCategory = context.MovieSubCategories.FirstOrDefault(sc => sc.MovieSubCategoryID == movie.MovieSubCategoryID);

                    
                }
                else
                {
                    MessageBox.Show("Film bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var context = Program.DbContext;
            var movie = context.Movies.FirstOrDefault(m => m.MovieID == _movieId);

                if (movie != null)
                {
                    movie.MovieName = txtMovieName.Text;
                    movie.LeadingActor = txtLeadingActor.Text;
                    movie.ReleaseYear = int.TryParse(txtReleaseYear.Text, out int year) ? year : 0;
                    movie.Director = txtDirector.Text;
                    movie.Rating = double.TryParse(txtRating.Text, out double rating) ? rating : 0.0;
                    movie.PosterURL = txtPosterURL.Text;

                    context.SaveChanges();

                    MessageBox.Show("Film başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Film bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
    }
}
