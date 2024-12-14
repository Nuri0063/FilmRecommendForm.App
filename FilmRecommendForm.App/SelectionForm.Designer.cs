namespace FilmRecommendForm.App
{
    partial class SelectionForm
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
            cmbMainCategory = new ComboBox();
            cmbSubCategory = new ComboBox();
            btnListMovies = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            lblUserName = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            pictureBox1 = new PictureBox();
            pictureBox5 = new PictureBox();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // cmbMainCategory
            // 
            cmbMainCategory.FormattingEnabled = true;
            cmbMainCategory.Location = new Point(200, 163);
            cmbMainCategory.Name = "cmbMainCategory";
            cmbMainCategory.Size = new Size(178, 28);
            cmbMainCategory.TabIndex = 0;
            cmbMainCategory.SelectedIndexChanged += cmbMainCategory_SelectedIndexChanged;
            // 
            // cmbSubCategory
            // 
            cmbSubCategory.FormattingEnabled = true;
            cmbSubCategory.Location = new Point(412, 163);
            cmbSubCategory.Name = "cmbSubCategory";
            cmbSubCategory.Size = new Size(179, 28);
            cmbSubCategory.TabIndex = 1;
            cmbSubCategory.SelectedIndexChanged += cmbSubCategory_SelectedIndexChanged;
            // 
            // btnListMovies
            // 
            btnListMovies.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnListMovies.Location = new Point(325, 219);
            btnListMovies.Name = "btnListMovies";
            btnListMovies.Size = new Size(118, 55);
            btnListMovies.TabIndex = 2;
            btnListMovies.Text = "Listele";
            btnListMovies.UseVisualStyleBackColor = true;
            btnListMovies.Click += btnListMovies_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(239, 137);
            label1.Name = "label1";
            label1.Size = new Size(74, 23);
            label1.TabIndex = 3;
            label1.Text = "Kategori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(446, 137);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 4;
            label2.Text = "Alt kategori";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(183, 6);
            label3.Name = "label3";
            label3.Size = new Size(408, 35);
            label3.TabIndex = 5;
            label3.Text = "Kategori Seçimi Ekranı";
            // 
            // label4
            // 
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(14, 47);
            label4.Name = "label4";
            label4.Size = new Size(762, 60);
            label4.TabIndex = 6;
            label4.Text = "Aklındaki kategoriyi seç ve aklınaki alt kategoriler eşliğinde aklına gelemeyen filmleri listeleyelim.";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(lblUserName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 113);
            panel1.TabIndex = 7;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(637, 6);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(39, 20);
            lblUserName.TabIndex = 10;
            lblUserName.Text = "-----";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 527);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(782, 26);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(151, 20);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkGray;
            pictureBox1.BackgroundImage = Properties.Resources.DLjOIGlWkAAiNSh;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Cursor = Cursors.IBeam;
            pictureBox1.Image = Properties.Resources.DLjOIGlWkAAiNSh;
            pictureBox1.Location = new Point(425, 306);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.Image = Properties.Resources.resized_7d81c_a15a1e46mttb_den_tepki_ceken_suleyman_cakir_paylasimiyla_ilgili_aciklama_yapti;
            pictureBox5.Location = new Point(38, 306);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(306, 203);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // SelectionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(782, 553);
            Controls.Add(btnListMovies);
            Controls.Add(cmbMainCategory);
            Controls.Add(pictureBox5);
            Controls.Add(cmbSubCategory);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Cursor = Cursors.AppStarting;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SelectionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seçim Ekranı";
            Load += SelectionForm_Load;
            Paint += SelectionForm_Paint;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMainCategory;
        private ComboBox cmbSubCategory;
        private Button btnListMovies;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Label lblUserName;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
    }
}