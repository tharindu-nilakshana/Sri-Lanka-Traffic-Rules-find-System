namespace Sri_Lanka_Road_And_Traffic_Rules
{
    partial class RulesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RulesForm));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoTrafficControlSignal = new System.Windows.Forms.RadioButton();
            this.rdoTrafficLights = new System.Windows.Forms.RadioButton();
            this.rdoMissellaneous = new System.Windows.Forms.RadioButton();
            this.rdoDirectional = new System.Windows.Forms.RadioButton();
            this.rdoRegulatoty = new System.Windows.Forms.RadioButton();
            this.rdoDangerWarning = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(24, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(892, 33);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.rdoTrafficControlSignal);
            this.panel1.Controls.Add(this.rdoTrafficLights);
            this.panel1.Controls.Add(this.rdoMissellaneous);
            this.panel1.Controls.Add(this.rdoDirectional);
            this.panel1.Controls.Add(this.rdoRegulatoty);
            this.panel1.Controls.Add(this.rdoDangerWarning);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 146);
            this.panel1.TabIndex = 3;
            // 
            // rdoTrafficControlSignal
            // 
            this.rdoTrafficControlSignal.AutoSize = true;
            this.rdoTrafficControlSignal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTrafficControlSignal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoTrafficControlSignal.Location = new System.Drawing.Point(206, 108);
            this.rdoTrafficControlSignal.Name = "rdoTrafficControlSignal";
            this.rdoTrafficControlSignal.Size = new System.Drawing.Size(162, 20);
            this.rdoTrafficControlSignal.TabIndex = 7;
            this.rdoTrafficControlSignal.TabStop = true;
            this.rdoTrafficControlSignal.Text = "Traffic Control Signal";
            this.rdoTrafficControlSignal.UseVisualStyleBackColor = true;
            this.rdoTrafficControlSignal.CheckedChanged += new System.EventHandler(this.rdoTrafficControlSignal_CheckedChanged);
            // 
            // rdoTrafficLights
            // 
            this.rdoTrafficLights.AutoSize = true;
            this.rdoTrafficLights.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTrafficLights.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoTrafficLights.Location = new System.Drawing.Point(55, 108);
            this.rdoTrafficLights.Name = "rdoTrafficLights";
            this.rdoTrafficLights.Size = new System.Drawing.Size(107, 20);
            this.rdoTrafficLights.TabIndex = 6;
            this.rdoTrafficLights.TabStop = true;
            this.rdoTrafficLights.Text = "Traffic Lights";
            this.rdoTrafficLights.UseVisualStyleBackColor = true;
            this.rdoTrafficLights.CheckedChanged += new System.EventHandler(this.rdoTrafficLights_CheckedChanged);
            // 
            // rdoMissellaneous
            // 
            this.rdoMissellaneous.AutoSize = true;
            this.rdoMissellaneous.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMissellaneous.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoMissellaneous.Location = new System.Drawing.Point(608, 71);
            this.rdoMissellaneous.Name = "rdoMissellaneous";
            this.rdoMissellaneous.Size = new System.Drawing.Size(117, 20);
            this.rdoMissellaneous.TabIndex = 4;
            this.rdoMissellaneous.TabStop = true;
            this.rdoMissellaneous.Text = "Missellaneous";
            this.rdoMissellaneous.UseVisualStyleBackColor = true;
            this.rdoMissellaneous.CheckedChanged += new System.EventHandler(this.rdoMissellaneous_CheckedChanged);
            // 
            // rdoDirectional
            // 
            this.rdoDirectional.AutoSize = true;
            this.rdoDirectional.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDirectional.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoDirectional.Location = new System.Drawing.Point(375, 70);
            this.rdoDirectional.Name = "rdoDirectional";
            this.rdoDirectional.Size = new System.Drawing.Size(174, 20);
            this.rdoDirectional.TabIndex = 3;
            this.rdoDirectional.TabStop = true;
            this.rdoDirectional.Text = "Directional Informative";
            this.rdoDirectional.UseVisualStyleBackColor = true;
            this.rdoDirectional.CheckedChanged += new System.EventHandler(this.rdoDirectional_CheckedChanged);
            // 
            // rdoRegulatoty
            // 
            this.rdoRegulatoty.AutoSize = true;
            this.rdoRegulatoty.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRegulatoty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoRegulatoty.Location = new System.Drawing.Point(206, 71);
            this.rdoRegulatoty.Name = "rdoRegulatoty";
            this.rdoRegulatoty.Size = new System.Drawing.Size(97, 20);
            this.rdoRegulatoty.TabIndex = 2;
            this.rdoRegulatoty.TabStop = true;
            this.rdoRegulatoty.Text = "Regulatory";
            this.rdoRegulatoty.UseVisualStyleBackColor = true;
            this.rdoRegulatoty.CheckedChanged += new System.EventHandler(this.rdoRegulatoty_CheckedChanged);
            // 
            // rdoDangerWarning
            // 
            this.rdoDangerWarning.AutoSize = true;
            this.rdoDangerWarning.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDangerWarning.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoDangerWarning.Location = new System.Drawing.Point(55, 71);
            this.rdoDangerWarning.Name = "rdoDangerWarning";
            this.rdoDangerWarning.Size = new System.Drawing.Size(133, 20);
            this.rdoDangerWarning.TabIndex = 1;
            this.rdoDangerWarning.TabStop = true;
            this.rdoDangerWarning.Text = "Danger Warning";
            this.rdoDangerWarning.UseVisualStyleBackColor = true;
            this.rdoDangerWarning.CheckedChanged += new System.EventHandler(this.rdoDangerWarning_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(922, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstname,
            this.description,
            this.image});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(12, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.Size = new System.Drawing.Size(1059, 433);
            this.dataGridView1.TabIndex = 4;
            // 
            // firstname
            // 
            this.firstname.DataPropertyName = "name";
            this.firstname.HeaderText = "Name Of The Rule";
            this.firstname.Name = "firstname";
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            // 
            // image
            // 
            this.image.DataPropertyName = "image";
            this.image.HeaderText = "Sign";
            this.image.Name = "image";
            // 
            // RulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1083, 587);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "RulesForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.RulesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdoRegulatoty;
        private System.Windows.Forms.RadioButton rdoDangerWarning;
        private System.Windows.Forms.RadioButton rdoTrafficControlSignal;
        private System.Windows.Forms.RadioButton rdoTrafficLights;
        private System.Windows.Forms.RadioButton rdoMissellaneous;
        private System.Windows.Forms.RadioButton rdoDirectional;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewImageColumn image;
    }
}