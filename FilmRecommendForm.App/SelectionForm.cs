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
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {
            using (var context = new FilmMoodDBContext())
            {
                // Üst kategori ComboBox'ına verileri ekle
                cmbMainCategory.DataSource = context.MovieCategories.ToList();
                cmbMainCategory.DisplayMember = "CategoryName";
                cmbMainCategory.ValueMember = "MovieCategoryID";
            }
        }

        private void cmbMainCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = cmbMainCategory.SelectedItem as MovieCategory;
            int selectedCategoryId = selectedItem.MovieCategoryID;
            using (var context = new FilmMoodDBContext())
            {
                cmbSubCategory.DataSource = context.MovieSubCategories
                    .Where(sc => sc.MovieCategoryID == selectedCategoryId)
                    .ToList();
                cmbSubCategory.DisplayMember = "SubCategoryName";
                cmbSubCategory.ValueMember = "MovieSubCategoryID";
            }
        }

        private void btnListMovies_Click(object sender, EventArgs e)
        {
            if (cmbMainCategory.SelectedValue != null && cmbSubCategory.SelectedValue != null)
            {
                int selectedMainCategoryId = (int)cmbMainCategory.SelectedValue;
                int selectedSubCategoryId = (int)cmbSubCategory.SelectedValue;

                var movieListForm = new MovieListForm(selectedMainCategoryId, selectedSubCategoryId);
                movieListForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen hem üst kategoriyi hem de alt kategoriyi seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Seçilen Kategori: {cmbMainCategory.Text}, Alt Kategori: {cmbSubCategory.Text}";
        }
    }
}
