namespace Sri_Lanka_Road_And_Traffic_Rules
{
    partial class AboutUs
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
            this.lblAbout = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.lblAboutNote = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.Crimson;
            this.lblAbout.Location = new System.Drawing.Point(812, 125);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(230, 58);
            this.lblAbout.TabIndex = 5;
            this.lblAbout.Text = "About Us";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Sri_Lanka_Road_And_Traffic_Rules.Properties.Resources.IMG_8646;
            this.pictureBox1.Location = new System.Drawing.Point(847, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxHome.Image = global::Sri_Lanka_Road_And_Traffic_Rules.Properties.Resources.IMG_8645;
            this.pictureBoxHome.Location = new System.Drawing.Point(13, -74);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(737, 667);
            this.pictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHome.TabIndex = 3;
            this.pictureBoxHome.TabStop = false;
            // 
            // lblAboutNote
            // 
            this.lblAboutNote.AutoSize = true;
            this.lblAboutNote.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutNote.ForeColor = System.Drawing.Color.White;
            this.lblAboutNote.Location = new System.Drawing.Point(765, 234);
            this.lblAboutNote.Name = "lblAboutNote";
            this.lblAboutNote.Size = new System.Drawing.Size(290, 34);
            this.lblAboutNote.TabIndex = 6;
            this.lblAboutNote.Text = "We are the best software solution company\r\nin Sri lanka. ";
            this.lblAboutNote.Click += new System.EventHandler(this.lblAboutNote_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(765, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 136);
            this.label1.TabIndex = 6;
            this.label1.Text = "Our contact Details,\r\n\r\nWebsite: www.traficrules.com\r\nContact No: 0712345648\r\nWha" +
    "tsApp / Viber: 0712345648\r\nAddress: VcNet IT Solution Company,\r\n              Ma" +
    "tara,\r\n              Sri Lanka.\r\n";
            this.label1.Click += new System.EventHandler(this.lblAboutNote_Click);
            // 
            // AboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1083, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAboutNote);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxHome);
            this.Name = "AboutUs";
            this.Text = "AboutUs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.Label lblAboutNote;
        private System.Windows.Forms.Label label1;
    }
}