using FilmRecommend.Business;
using FilmRecommend.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FilmRecommend.Business.DataOperations;

namespace FilmRecommendForm.App
{
    public partial class MovieDetailsFormcs : Form
    {
        private int _selectedMovieId;
        public MovieDetailsFormcs(int selectedMovieId)
        {
            InitializeComponent();
            _selectedMovieId = selectedMovieId;
        }

        private void MovieDetailsFormcs_Load(object sender, EventArgs e)
        {
            using (var context = new FilmMoodDBContext())
            {
                var movie = context.Movies.FirstOrDefault(m => m.MovieID == _selectedMovieId);

                if (movie != null)
                {

                    pictureBox1.ImageLocation = movie.PosterURL; // Posteri göster
                }
                else
                {
                    MessageBox.Show("Film bulunamadı.");
                }
            }

            using (var context = new FilmMoodDBContext())
            {
                var movie = context.Movies.Include(m => m.SubCategory.Category)
                                          .FirstOrDefault(m => m.MovieID == _selectedMovieId);

                if (movie != null)
                {
                    txtMovieName.Text = movie.MovieName;
                    txtDirector.Text = movie.Director;
                    txtLeadingActor.Text = movie.LeadingActor;
                    txtReleaseYear.Text = movie.ReleaseYear.ToString();
                    txtRating.Text = movie.Rating.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
