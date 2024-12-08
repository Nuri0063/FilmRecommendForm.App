namespace FilmRecommendForm.App
{
    partial class MovieListForm
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
            dgvMovies = new DataGridView();
            btnShowGraph = new Button();
            btnExportPdf = new Button();
            btnSendMail = new Button();
            txtEmail = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMovies
            // 
            dgvMovies.BackgroundColor = Color.Navy;
            dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovies.Location = new Point(0, -4);
            dgvMovies.Name = "dgvMovies";
            dgvMovies.RowHeadersWidth = 51;
            dgvMovies.Size = new Size(800, 152);
            dgvMovies.TabIndex = 0;
            dgvMovies.MouseDoubleClick += dgvMovies_MouseDoubleClick;
            // 
            // btnShowGraph
            // 
            btnShowGraph.Location = new Point(50, 36);
            btnShowGraph.Name = "btnShowGraph";
            btnShowGraph.Size = new Size(130, 63);
            btnShowGraph.TabIndex = 2;
            btnShowGraph.Text = "Grafik";
            btnShowGraph.UseVisualStyleBackColor = true;
            btnShowGraph.Click += btnShowGraph_Click;
            // 
            // btnExportPdf
            // 
            btnExportPdf.Location = new Point(237, 36);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(130, 63);
            btnExportPdf.TabIndex = 3;
            btnExportPdf.Text = "PDF";
            btnExportPdf.UseVisualStyleBackColor = true;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // btnSendMail
            // 
            btnSendMail.Location = new Point(428, 36);
            btnSendMail.Name = "btnSendMail";
            btnSendMail.Size = new Size(130, 63);
            btnSendMail.TabIndex = 4;
            btnSendMail.Text = "Mail";
            btnSendMail.UseVisualStyleBackColor = true;
            btnSendMail.Click += btnSendMail_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(428, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(130, 27);
            txtEmail.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnShowGraph);
            panel1.Controls.Add(btnSendMail);
            panel1.Controls.Add(btnExportPdf);
            panel1.Controls.Add(txtEmail);
            panel1.Location = new Point(0, 429);
            panel1.Name = "panel1";
            panel1.Size = new Size(783, 125);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(606, 36);
            button1.Name = "button1";
            button1.Size = new Size(130, 63);
            button1.TabIndex = 7;
            button1.Text = "Geri Dön";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MovieListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(panel1);
            Controls.Add(dgvMovies);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MovieListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MovieListForm";
            Load += MovieListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMovies).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMovies;
        private Button btnShowGraph;
        private Button btnExportPdf;
        private Button btnSendMail;
        private TextBox txtEmail;
        private Panel panel1;
        private Button button1;
    }
}