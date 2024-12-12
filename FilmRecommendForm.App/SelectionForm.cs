using FilmRecommend.Data;
using FilmRecommend.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FilmRecommendForm.App
{

    public partial class SelectionForm : Form
    {
        private string _userName;
        private bool _isAdmin;
        public SelectionForm(string userName, bool isAdmin)
        {
            InitializeComponent();
            _userName = userName;
            _isAdmin = isAdmin;

            lblUserName.Text = $"Hoşgeldiniz, {_userName}";

        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {


            try
            {
                using (var context = new FilmMoodDBContext())
                {
                    var categories = context.MovieCategories.ToList();

                    if (categories != null && categories.Any())
                    {
                        cmbMainCategory.DataSource = categories;
                        cmbMainCategory.DisplayMember = "CategoryName";
                        cmbMainCategory.ValueMember = "MovieCategoryID";
                    }
                    else
                    {
                        MessageBox.Show("Veritabanında kategori bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Veritabanı bağlantısı sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                var movieListForm = new MovieListForm(selectedMainCategoryId, selectedSubCategoryId, _userName, _isAdmin);
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

        private void SelectionForm_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
