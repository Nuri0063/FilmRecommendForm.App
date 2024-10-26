namespace FilmRecommendForm.App
{
    partial class Form1
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
            comboBoxMovieCategories = new ComboBox();
            comboBoxSubCategories = new ComboBox();
            dataGridViewMovies = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).BeginInit();
            SuspendLayout();
            // 
            // comboBoxMovieCategories
            // 
            comboBoxMovieCategories.FormattingEnabled = true;
            comboBoxMovieCategories.Location = new Point(114, 27);
            comboBoxMovieCategories.Name = "comboBoxMovieCategories";
            comboBoxMovieCategories.Size = new Size(151, 28);
            comboBoxMovieCategories.TabIndex = 0;
            comboBoxMovieCategories.SelectedIndexChanged += comboBoxMovieCategories_SelectedIndexChanged;
            // 
            // comboBoxSubCategories
            // 
            comboBoxSubCategories.FormattingEnabled = true;
            comboBoxSubCategories.Location = new Point(531, 27);
            comboBoxSubCategories.Name = "comboBoxSubCategories";
            comboBoxSubCategories.Size = new Size(151, 28);
            comboBoxSubCategories.TabIndex = 1;
            comboBoxSubCategories.SelectedIndexChanged += comboBoxSubCategories_SelectedIndexChanged;
            // 
            // dataGridViewMovies
            // 
            dataGridViewMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMovies.Location = new Point(12, 74);
            dataGridViewMovies.Name = "dataGridViewMovies";
            dataGridViewMovies.RowHeadersWidth = 51;
            dataGridViewMovies.Size = new Size(884, 420);
            dataGridViewMovies.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 506);
            Controls.Add(dataGridViewMovies);
            Controls.Add(comboBoxSubCategories);
            Controls.Add(comboBoxMovieCategories);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxMovieCategories;
        private ComboBox comboBoxSubCategories;
        private DataGridView dataGridViewMovies;
    }
}