namespace FilmRecommendForm.App
{
    partial class EditMovieForm
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
            txtMovieName = new TextBox();
            txtLeadingActor = new TextBox();
            txtReleaseYear = new TextBox();
            txtDirector = new TextBox();
            txtRating = new TextBox();
            txtPosterURL = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtMovieName
            // 
            txtMovieName.Location = new Point(396, 23);
            txtMovieName.Name = "txtMovieName";
            txtMovieName.Size = new Size(125, 27);
            txtMovieName.TabIndex = 0;
            // 
            // txtLeadingActor
            // 
            txtLeadingActor.Location = new Point(396, 82);
            txtLeadingActor.Name = "txtLeadingActor";
            txtLeadingActor.Size = new Size(125, 27);
            txtLeadingActor.TabIndex = 1;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(396, 152);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(125, 27);
            txtReleaseYear.TabIndex = 2;
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(396, 222);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(125, 27);
            txtDirector.TabIndex = 3;
            // 
            // txtRating
            // 
            txtRating.Location = new Point(396, 291);
            txtRating.Name = "txtRating";
            txtRating.Size = new Size(125, 27);
            txtRating.TabIndex = 4;
            // 
            // txtPosterURL
            // 
            txtPosterURL.Location = new Point(396, 363);
            txtPosterURL.Name = "txtPosterURL";
            txtPosterURL.Size = new Size(125, 27);
            txtPosterURL.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(238, 243);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "button1";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // EditMovieForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(txtPosterURL);
            Controls.Add(txtRating);
            Controls.Add(txtDirector);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtLeadingActor);
            Controls.Add(txtMovieName);
            Name = "EditMovieForm";
            Text = "EditMovieForm";
            Load += EditMovieForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMovieName;
        private TextBox txtLeadingActor;
        private TextBox txtReleaseYear;
        private TextBox txtDirector;
        private TextBox txtRating;
        private TextBox txtPosterURL;
        private Button btnSave;
    }
}