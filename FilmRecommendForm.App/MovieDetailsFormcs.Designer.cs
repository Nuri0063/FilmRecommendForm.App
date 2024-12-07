﻿namespace FilmRecommendForm.App
{
    partial class MovieDetailsFormcs
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
            txtDirector = new TextBox();
            txtLeadingActor = new TextBox();
            txtReleaseYear = new TextBox();
            txtRating = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtMovieName
            // 
            txtMovieName.Location = new Point(443, 50);
            txtMovieName.Name = "txtMovieName";
            txtMovieName.ReadOnly = true;
            txtMovieName.Size = new Size(172, 27);
            txtMovieName.TabIndex = 0;
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(443, 99);
            txtDirector.Name = "txtDirector";
            txtDirector.ReadOnly = true;
            txtDirector.Size = new Size(172, 27);
            txtDirector.TabIndex = 1;
            // 
            // txtLeadingActor
            // 
            txtLeadingActor.Location = new Point(443, 146);
            txtLeadingActor.Name = "txtLeadingActor";
            txtLeadingActor.ReadOnly = true;
            txtLeadingActor.Size = new Size(172, 27);
            txtLeadingActor.TabIndex = 2;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(443, 195);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.ReadOnly = true;
            txtReleaseYear.Size = new Size(172, 27);
            txtReleaseYear.TabIndex = 3;
            // 
            // txtRating
            // 
            txtRating.Location = new Point(443, 248);
            txtRating.Name = "txtRating";
            txtRating.ReadOnly = true;
            txtRating.Size = new Size(172, 27);
            txtRating.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(335, 54);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 5;
            label1.Text = "Filmin Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(334, 150);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 6;
            label2.Text = "Başrol";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(334, 103);
            label3.Name = "label3";
            label3.Size = new Size(87, 23);
            label3.TabIndex = 7;
            label3.Text = "Yönetmen";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(334, 196);
            label4.Name = "label4";
            label4.Size = new Size(72, 23);
            label4.TabIndex = 8;
            label4.Text = "Çıkış Yılı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(335, 252);
            label5.Name = "label5";
            label5.Size = new Size(49, 23);
            label5.TabIndex = 9;
            label5.Text = "Puan";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(27, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 336);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // MovieDetailsFormcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtRating);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtLeadingActor);
            Controls.Add(txtDirector);
            Controls.Add(txtMovieName);
            Name = "MovieDetailsFormcs";
            Text = "MovieDetailsFormcs";
            Load += MovieDetailsFormcs_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMovieName;
        private TextBox txtDirector;
        private TextBox txtLeadingActor;
        private TextBox txtReleaseYear;
        private TextBox txtRating;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
    }
}