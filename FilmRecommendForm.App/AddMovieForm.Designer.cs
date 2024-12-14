namespace FilmRecommendForm.App
{
    partial class AddMovieForm
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
            btnSave = new Button();
            txtMovieName = new TextBox();
            txtLeadingActor = new TextBox();
            txtReleaseYear = new TextBox();
            txtDirector = new TextBox();
            txtRating = new TextBox();
            txtPosterURL = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(375, 309);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Ekle";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtMovieName
            // 
            txtMovieName.Location = new Point(375, 12);
            txtMovieName.Name = "txtMovieName";
            txtMovieName.Size = new Size(125, 27);
            txtMovieName.TabIndex = 2;
            // 
            // txtLeadingActor
            // 
            txtLeadingActor.Location = new Point(375, 56);
            txtLeadingActor.Name = "txtLeadingActor";
            txtLeadingActor.Size = new Size(125, 27);
            txtLeadingActor.TabIndex = 3;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(375, 106);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(125, 27);
            txtReleaseYear.TabIndex = 4;
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(375, 152);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(125, 27);
            txtDirector.TabIndex = 5;
            // 
            // txtRating
            // 
            txtRating.Location = new Point(375, 199);
            txtRating.Name = "txtRating";
            txtRating.Size = new Size(125, 27);
            txtRating.TabIndex = 6;
            // 
            // txtPosterURL
            // 
            txtPosterURL.Location = new Point(375, 246);
            txtPosterURL.Name = "txtPosterURL";
            txtPosterURL.Size = new Size(125, 27);
            txtPosterURL.TabIndex = 7;
            // 
            // AddMovieForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPosterURL);
            Controls.Add(txtRating);
            Controls.Add(txtDirector);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtLeadingActor);
            Controls.Add(txtMovieName);
            Controls.Add(btnSave);
            Name = "AddMovieForm";
            Text = "AddMovieForm";
            Load += AddMovieForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private TextBox txtMovieName;
        private TextBox txtLeadingActor;
        private TextBox txtReleaseYear;
        private TextBox txtDirector;
        private TextBox txtRating;
        private TextBox txtPosterURL;
    }
}