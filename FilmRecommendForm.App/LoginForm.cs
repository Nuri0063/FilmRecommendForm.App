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
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            string username = txtUsername.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Lütfen bir kullanıcı adı giriniz.");
                return;
            }

            // Admin kontrolü
            bool isAdmin = username.Equals("admin", StringComparison.OrdinalIgnoreCase);

            // Kullanıcı adını bir property olarak saklayalım
            SelectionForm selectionForm = new SelectionForm(username, isAdmin);
            selectionForm.Show();
            this.Hide();


        }



        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
