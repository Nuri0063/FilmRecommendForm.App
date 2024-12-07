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
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMovies
            // 
            dgvMovies.BackgroundColor = Color.Navy;
            dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovies.Location = new Point(1, 0);
            dgvMovies.Name = "dgvMovies";
            dgvMovies.RowHeadersWidth = 51;
            dgvMovies.Size = new Size(799, 168);
            dgvMovies.TabIndex = 0;
            // 
            // btnShowGraph
            // 
            btnShowGraph.Location = new Point(48, 49);
            btnShowGraph.Name = "btnShowGraph";
            btnShowGraph.Size = new Size(122, 63);
            btnShowGraph.TabIndex = 2;
            btnShowGraph.Text = "Grafik";
            btnShowGraph.UseVisualStyleBackColor = true;
            btnShowGraph.Click += btnShowGraph_Click;
            // 
            // btnExportPdf
            // 
            btnExportPdf.Location = new Point(358, 49);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(133, 63);
            btnExportPdf.TabIndex = 3;
            btnExportPdf.Text = "PDF";
            btnExportPdf.UseVisualStyleBackColor = true;
            // 
            // btnSendMail
            // 
            btnSendMail.Location = new Point(631, 49);
            btnSendMail.Name = "btnSendMail";
            btnSendMail.Size = new Size(122, 63);
            btnSendMail.TabIndex = 4;
            btnSendMail.Text = "Mail";
            btnSendMail.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(628, 16);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnShowGraph);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(btnExportPdf);
            panel1.Controls.Add(btnSendMail);
            panel1.Location = new Point(1, 326);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 125);
            panel1.TabIndex = 6;
            // 
            // MovieListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dgvMovies);
            Name = "MovieListForm";
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
    }
}