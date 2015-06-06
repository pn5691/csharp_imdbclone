﻿namespace IMDBClone
{
    partial class Form4_addMovie
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
            this.m_textBox_name = new System.Windows.Forms.TextBox();
            this.m_textBox_director = new System.Windows.Forms.TextBox();
            this.m_textBox_actorMain = new System.Windows.Forms.TextBox();
            this.m_textBox_actorSecondary = new System.Windows.Forms.TextBox();
            this.m_richTextBox_summary = new System.Windows.Forms.RichTextBox();
            this.m_button_browse = new System.Windows.Forms.Button();
            this.m_textBox_filepath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.m_button_addMovie = new System.Windows.Forms.Button();
            this.m_button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_textBox_name
            // 
            this.m_textBox_name.Location = new System.Drawing.Point(85, 12);
            this.m_textBox_name.Name = "m_textBox_name";
            this.m_textBox_name.Size = new System.Drawing.Size(243, 20);
            this.m_textBox_name.TabIndex = 0;
            // 
            // m_textBox_director
            // 
            this.m_textBox_director.Location = new System.Drawing.Point(85, 38);
            this.m_textBox_director.Name = "m_textBox_director";
            this.m_textBox_director.Size = new System.Drawing.Size(243, 20);
            this.m_textBox_director.TabIndex = 1;
            // 
            // m_textBox_actorMain
            // 
            this.m_textBox_actorMain.Location = new System.Drawing.Point(85, 64);
            this.m_textBox_actorMain.Name = "m_textBox_actorMain";
            this.m_textBox_actorMain.Size = new System.Drawing.Size(243, 20);
            this.m_textBox_actorMain.TabIndex = 2;
            // 
            // m_textBox_actorSecondary
            // 
            this.m_textBox_actorSecondary.Location = new System.Drawing.Point(85, 90);
            this.m_textBox_actorSecondary.Name = "m_textBox_actorSecondary";
            this.m_textBox_actorSecondary.Size = new System.Drawing.Size(243, 20);
            this.m_textBox_actorSecondary.TabIndex = 3;
            // 
            // m_richTextBox_summary
            // 
            this.m_richTextBox_summary.Location = new System.Drawing.Point(85, 116);
            this.m_richTextBox_summary.Name = "m_richTextBox_summary";
            this.m_richTextBox_summary.Size = new System.Drawing.Size(243, 179);
            this.m_richTextBox_summary.TabIndex = 4;
            this.m_richTextBox_summary.Text = "";
            // 
            // m_button_browse
            // 
            this.m_button_browse.Location = new System.Drawing.Point(85, 302);
            this.m_button_browse.Name = "m_button_browse";
            this.m_button_browse.Size = new System.Drawing.Size(67, 20);
            this.m_button_browse.TabIndex = 5;
            this.m_button_browse.Text = "Browse...";
            this.m_button_browse.UseVisualStyleBackColor = true;
            this.m_button_browse.Click += new System.EventHandler(this.m_button_browse_Click);
            // 
            // m_textBox_filepath
            // 
            this.m_textBox_filepath.Location = new System.Drawing.Point(158, 302);
            this.m_textBox_filepath.Name = "m_textBox_filepath";
            this.m_textBox_filepath.ReadOnly = true;
            this.m_textBox_filepath.Size = new System.Drawing.Size(170, 20);
            this.m_textBox_filepath.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Director";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Starring";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Featuring";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Summary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Poster";
            // 
            // m_button_addMovie
            // 
            this.m_button_addMovie.Location = new System.Drawing.Point(85, 328);
            this.m_button_addMovie.Name = "m_button_addMovie";
            this.m_button_addMovie.Size = new System.Drawing.Size(115, 23);
            this.m_button_addMovie.TabIndex = 13;
            this.m_button_addMovie.Text = "Add";
            this.m_button_addMovie.UseVisualStyleBackColor = true;
            this.m_button_addMovie.Click += new System.EventHandler(this.m_button_addMovie_Click);
            // 
            // m_button_cancel
            // 
            this.m_button_cancel.Location = new System.Drawing.Point(216, 328);
            this.m_button_cancel.Name = "m_button_cancel";
            this.m_button_cancel.Size = new System.Drawing.Size(112, 23);
            this.m_button_cancel.TabIndex = 14;
            this.m_button_cancel.Text = "Cancel";
            this.m_button_cancel.UseVisualStyleBackColor = true;
            this.m_button_cancel.Click += new System.EventHandler(this.m_button_cancel_Click);
            // 
            // Form4_addMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 426);
            this.Controls.Add(this.m_button_cancel);
            this.Controls.Add(this.m_button_addMovie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_textBox_filepath);
            this.Controls.Add(this.m_button_browse);
            this.Controls.Add(this.m_richTextBox_summary);
            this.Controls.Add(this.m_textBox_actorSecondary);
            this.Controls.Add(this.m_textBox_actorMain);
            this.Controls.Add(this.m_textBox_director);
            this.Controls.Add(this.m_textBox_name);
            this.Location = new System.Drawing.Point(400, 400);
            this.Name = "Form4_addMovie";
            this.Text = "Form4_addMovie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_textBox_name;
        private System.Windows.Forms.TextBox m_textBox_director;
        private System.Windows.Forms.TextBox m_textBox_actorMain;
        private System.Windows.Forms.TextBox m_textBox_actorSecondary;
        private System.Windows.Forms.RichTextBox m_richTextBox_summary;
        private System.Windows.Forms.Button m_button_browse;
        private System.Windows.Forms.TextBox m_textBox_filepath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button m_button_addMovie;
        private System.Windows.Forms.Button m_button_cancel;
    }
}