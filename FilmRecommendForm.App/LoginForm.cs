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
            if (txtUsername.Text == "admin" && txtPassword.Text == "1234")
            {
                var categoryForm =new SelectionForm();
                categoryForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Geçersiz kullanıcı adı veya şifre!");
            }
        }
    }
}
