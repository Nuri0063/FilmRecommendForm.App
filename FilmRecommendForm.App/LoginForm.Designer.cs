namespace FilmRecommendForm.App
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            btnLogin = new Button();
            txtUsername = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(138, 80);
            label2.Name = "label2";
            label2.Size = new Size(510, 62);
            label2.TabIndex = 1;
            label2.Text = "The Film in Your Mind";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnLogin.ForeColor = Color.Navy;
            btnLogin.Location = new Point(201, 244);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(402, 75);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Keşfetmeye Başla ";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtUsername.Location = new Point(373, 170);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(275, 38);
            txtUsername.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(155, 173);
            label1.Name = "label1";
            label1.Size = new Size(154, 31);
            label1.TabIndex = 4;
            label1.Text = "Kullanıcı Adı: ";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FJKdOoJWUAI3Rzl;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 553);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Sayfası";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnLogin;
        private TextBox txtUsername;
        private Label label1;
    }
}