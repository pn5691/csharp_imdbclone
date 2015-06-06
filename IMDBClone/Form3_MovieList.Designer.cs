namespace IMDBClone
{
    partial class Form3_MovieList
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
            this.m_richTextBox_details = new System.Windows.Forms.RichTextBox();
            this.m_picturebox_poster = new System.Windows.Forms.PictureBox();
            this.m_button_newMovie = new System.Windows.Forms.Button();
            this.m_button_editMovie = new System.Windows.Forms.Button();
            this.m_button_logout = new System.Windows.Forms.Button();
            this.m_label_username = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_picturebox_poster)).BeginInit();
            this.SuspendLayout();
            // 
            // m_richTextBox_details
            // 
            this.m_richTextBox_details.Location = new System.Drawing.Point(356, 173);
            this.m_richTextBox_details.Name = "m_richTextBox_details";
            this.m_richTextBox_details.Size = new System.Drawing.Size(138, 182);
            this.m_richTextBox_details.TabIndex = 0;
            this.m_richTextBox_details.Text = "";
            // 
            // m_picturebox_poster
            // 
            this.m_picturebox_poster.Location = new System.Drawing.Point(356, 12);
            this.m_picturebox_poster.Name = "m_picturebox_poster";
            this.m_picturebox_poster.Size = new System.Drawing.Size(138, 155);
            this.m_picturebox_poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.m_picturebox_poster.TabIndex = 1;
            this.m_picturebox_poster.TabStop = false;
            // 
            // m_button_newMovie
            // 
            this.m_button_newMovie.Location = new System.Drawing.Point(12, 12);
            this.m_button_newMovie.Name = "m_button_newMovie";
            this.m_button_newMovie.Size = new System.Drawing.Size(338, 25);
            this.m_button_newMovie.TabIndex = 2;
            this.m_button_newMovie.Text = "Add a Movie...";
            this.m_button_newMovie.UseVisualStyleBackColor = true;
            this.m_button_newMovie.Click += new System.EventHandler(this.m_button_newMovie_Click);
            // 
            // m_button_editMovie
            // 
            this.m_button_editMovie.Location = new System.Drawing.Point(356, 361);
            this.m_button_editMovie.Name = "m_button_editMovie";
            this.m_button_editMovie.Size = new System.Drawing.Size(138, 21);
            this.m_button_editMovie.TabIndex = 3;
            this.m_button_editMovie.Text = "Edit Details";
            this.m_button_editMovie.UseVisualStyleBackColor = false;
            this.m_button_editMovie.Click += new System.EventHandler(this.m_button_editMovie_Click);
            // 
            // m_button_logout
            // 
            this.m_button_logout.Location = new System.Drawing.Point(274, 44);
            this.m_button_logout.Name = "m_button_logout";
            this.m_button_logout.Size = new System.Drawing.Size(74, 22);
            this.m_button_logout.TabIndex = 4;
            this.m_button_logout.Text = "Log Out";
            this.m_button_logout.UseVisualStyleBackColor = true;
            this.m_button_logout.Click += new System.EventHandler(this.m_button_logout_Click);
            // 
            // m_label_username
            // 
            this.m_label_username.AutoSize = true;
            this.m_label_username.Location = new System.Drawing.Point(233, 49);
            this.m_label_username.Name = "m_label_username";
            this.m_label_username.Size = new System.Drawing.Size(35, 13);
            this.m_label_username.TabIndex = 5;
            this.m_label_username.Text = "label1";
            // 
            // Form3_MovieList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 435);
            this.Controls.Add(this.m_label_username);
            this.Controls.Add(this.m_button_logout);
            this.Controls.Add(this.m_button_editMovie);
            this.Controls.Add(this.m_button_newMovie);
            this.Controls.Add(this.m_picturebox_poster);
            this.Controls.Add(this.m_richTextBox_details);
            this.Name = "Form3_MovieList";
            this.Text = "Form3_MovieList";
            this.Load += new System.EventHandler(this.Form3_MovieList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_picturebox_poster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox m_richTextBox_details;
        private System.Windows.Forms.PictureBox m_picturebox_poster;
        private System.Windows.Forms.Button m_button_newMovie;
        private System.Windows.Forms.Button m_button_editMovie;
        private System.Windows.Forms.Button m_button_logout;
        private System.Windows.Forms.Label m_label_username;
    }
}