namespace Sri_Lanka_Road_And_Traffic_Rules
{
    partial class Home
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Sri_Lanka_Road_And_Traffic_Rules.Properties.Resources.IMG_8646;
            this.pictureBox1.Location = new System.Drawing.Point(839, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxHome.Image = global::Sri_Lanka_Road_And_Traffic_Rules.Properties.Resources.IMG_8645;
            this.pictureBoxHome.Location = new System.Drawing.Point(0, -1);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(737, 667);
            this.pictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHome.TabIndex = 0;
            this.pictureBoxHome.TabStop = false;
            this.pictureBoxHome.Click += new System.EventHandler(this.pictureBoxHome_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Crimson;
            this.lblWelcome.Location = new System.Drawing.Point(786, 126);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(270, 58);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "WELCOME";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1083, 519);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxHome);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWelcome;
    }
}