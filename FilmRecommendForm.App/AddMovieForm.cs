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
    public partial class AddMovieForm : Form
    {
        private int _mainCategoryId;
        private int _subCategoryId;
        public AddMovieForm(int mainCategoryId, int subCategoryId)
        {
            InitializeComponent();
            _mainCategoryId = mainCategoryId;
            _subCategoryId = subCategoryId;
        }

        private void AddMovieForm_Load(object sender, EventArgs e)
        {
            var context = Program.DbContext;
            var subCategory = context.MovieSubCategories
                                         .FirstOrDefault(sc => sc.MovieSubCategoryID == _subCategoryId);

                
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var context = Program.DbContext;
            var newMovie = new Movie
                {
                    MovieName = txtMovieName.Text,
                    LeadingActor = txtLeadingActor.Text,
                    ReleaseYear = int.TryParse(txtReleaseYear.Text, out int year) ? year : 0,
                    Director = txtDirector.Text,
                    Rating = double.TryParse(txtRating.Text, out double rating) ? rating : 0.0,
                    PosterURL = txtPosterURL.Text,
                    MovieSubCategoryID = _subCategoryId
                };

                context.Movies.Add(newMovie);
                context.SaveChanges();

                MessageBox.Show("Film başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            
        }
    }
}
