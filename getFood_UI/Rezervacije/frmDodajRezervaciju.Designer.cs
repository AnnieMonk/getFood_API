namespace getFood_UI.Rezervacije
{
    partial class frmDodajRezervaciju
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDodajRezervaciju));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picEdit = new System.Windows.Forms.PictureBox();
            this.picDodajUredi = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.numBrojljudi = new System.Windows.Forms.NumericUpDown();
            this.lblBrojLjudi = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProviderRezervacija = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDodajUredi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojljudi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRezervacija)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(635, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 19);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 38);
            this.panel2.TabIndex = 17;
            // 
            // picEdit
            // 
            this.picEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.picEdit.Image = ((System.Drawing.Image)(resources.GetObject("picEdit.Image")));
            this.picEdit.Location = new System.Drawing.Point(44, 0);
            this.picEdit.Margin = new System.Windows.Forms.Padding(2);
            this.picEdit.Name = "picEdit";
            this.picEdit.Size = new System.Drawing.Size(125, 116);
            this.picEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picEdit.TabIndex = 17;
            this.picEdit.TabStop = false;
            // 
            // picDodajUredi
            // 
            this.picDodajUredi.Image = ((System.Drawing.Image)(resources.GetObject("picDodajUredi.Image")));
            this.picDodajUredi.Location = new System.Drawing.Point(422, 42);
            this.picDodajUredi.Margin = new System.Windows.Forms.Padding(2);
            this.picDodajUredi.Name = "picDodajUredi";
            this.picDodajUredi.Size = new System.Drawing.Size(165, 60);
            this.picDodajUredi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDodajUredi.TabIndex = 32;
            this.picDodajUredi.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(56, 246);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Datum i vrijeme";
            // 
            // dateTime
            // 
            this.dateTime.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dateTime.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dateTime.Checked = false;
            this.dateTime.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dateTime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime.Location = new System.Drawing.Point(195, 241);
            this.dateTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTime.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTime.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(247, 26);
            this.dateTime.TabIndex = 72;
            this.dateTime.Validating += new System.ComponentModel.CancelEventHandler(this.dateTime_Validating);
            // 
            // numBrojljudi
            // 
            this.numBrojljudi.Location = new System.Drawing.Point(195, 302);
            this.numBrojljudi.Margin = new System.Windows.Forms.Padding(4);
            this.numBrojljudi.Name = "numBrojljudi";
            this.numBrojljudi.Size = new System.Drawing.Size(44, 22);
            this.numBrojljudi.TabIndex = 85;
            this.numBrojljudi.Validating += new System.ComponentModel.CancelEventHandler(this.numBrojljudi_Validating);
            // 
            // lblBrojLjudi
            // 
            this.lblBrojLjudi.AutoSize = true;
            this.lblBrojLjudi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojLjudi.Location = new System.Drawing.Point(56, 306);
            this.lblBrojLjudi.Name = "lblBrojLjudi";
            this.lblBrojLjudi.Size = new System.Drawing.Size(71, 18);
            this.lblBrojLjudi.TabIndex = 84;
            this.lblBrojLjudi.Text = "Broj ljudi";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrezime.Location = new System.Drawing.Point(326, 138);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(116, 26);
            this.txtPrezime.TabIndex = 82;
            this.txtPrezime.Text = "Prezime";
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIme.Location = new System.Drawing.Point(195, 138);
            this.txtIme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(125, 26);
            this.txtIme.TabIndex = 80;
            this.txtIme.Text = "Ime";
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.btnDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(492, 333);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(95, 31);
            this.btnDodaj.TabIndex = 86;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKorisnickoIme.Location = new System.Drawing.Point(195, 185);
            this.txtKorisnickoIme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(247, 26);
            this.txtKorisnickoIme.TabIndex = 90;
            this.txtKorisnickoIme.Text = "Korisnicko ime";
            this.txtKorisnickoIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtKorisnickoIme_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(56, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 91;
            this.label2.Text = "Profil";
            // 
            // errorProviderRezervacija
            // 
            this.errorProviderRezervacija.ContainerControl = this;
            // 
            // frmDodajRezervaciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 390);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.numBrojljudi);
            this.Controls.Add(this.lblBrojLjudi);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picDodajUredi);
            this.Controls.Add(this.picEdit);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDodajRezervaciju";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDodajUredi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojljudi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRezervacija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picEdit;
        private System.Windows.Forms.PictureBox picDodajUredi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.NumericUpDown numBrojljudi;
        private System.Windows.Forms.Label lblBrojLjudi;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProviderRezervacija;
    }
}