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
using static FilmRecommend.Data.FilmMoodDBContext;

namespace FilmRecommendForm.App
{
    public partial class MovieDetailsFormcs : Form
    {
        private string _userName;
        private int _selectedMovieId;
        public MovieDetailsFormcs(int selectedMovieId,string username)
        {
            InitializeComponent();
            _selectedMovieId = selectedMovieId;
            _userName = username;

            label6.Text = $"Hoş Geldiniz, {_userName}";
        }

        private void MovieDetailsFormcs_Load(object sender, EventArgs e)
        {
            var context = Program.DbContext;
            var movie = context.Movies.FirstOrDefault(m => m.MovieID == _selectedMovieId);

                if (movie != null)
                {

                    pictureBox1.ImageLocation = movie.PosterURL; // Posteri göster
                }
                else
                {
                    MessageBox.Show("Film bulunamadı.");
                }
            

            
                var movie1 = context.Movies.Include(m => m.SubCategory.Category)
                                          .FirstOrDefault(m => m.MovieID == _selectedMovieId);

                if (movie1 != null)
                {
                    txtMovieName.Text = movie1.MovieName;
                    txtDirector.Text = movie1.Director;
                    txtLeadingActor.Text = movie1.LeadingActor;
                    txtReleaseYear.Text = movie1.ReleaseYear.ToString();
                    txtRating.Text = movie1.Rating.ToString();
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
