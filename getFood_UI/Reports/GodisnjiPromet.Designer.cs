namespace getFood_UI.Reports
{
    partial class GodisnjiPromet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GodisnjiPromet));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rptGodisnjiPromet = new Microsoft.Reporting.WinForms.ReportViewer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.godina = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(726, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 37);
            this.panel2.TabIndex = 19;
            // 
            // rptGodisnjiPromet
            // 
            this.rptGodisnjiPromet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rptGodisnjiPromet.LocalReport.ReportEmbeddedResource = "getFood_UI.Reports.GodisnjiPromet.rdlc";
            this.rptGodisnjiPromet.Location = new System.Drawing.Point(0, 106);
            this.rptGodisnjiPromet.Name = "rptGodisnjiPromet";
            this.rptGodisnjiPromet.ServerReport.BearerToken = null;
            this.rptGodisnjiPromet.Size = new System.Drawing.Size(769, 711);
            this.rptGodisnjiPromet.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(39, 54);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 27);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "Datum";
            // 
            // godina
            // 
            this.godina.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.godina.CustomFormat = "yyyy";
            this.godina.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.godina.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.godina.Location = new System.Drawing.Point(125, 54);
            this.godina.Name = "godina";
            this.godina.Size = new System.Drawing.Size(207, 26);
            this.godina.TabIndex = 22;
            this.godina.Value = new System.DateTime(2020, 6, 16, 15, 12, 8, 0);
            this.godina.ValueChanged += new System.EventHandler(this.godina_ValueChanged);
            // 
            // GodisnjiPromet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(769, 817);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.godina);
            this.Controls.Add(this.rptGodisnjiPromet);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GodisnjiPromet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.GodisnjiPromet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer rptGodisnjiPromet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker godina;
    }
}