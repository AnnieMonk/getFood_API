namespace getFood_UI.Rezervacije
{
    partial class frmPregledRezervacije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledRezervacije));
            this.picEdit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picPregled = new System.Windows.Forms.PictureBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.lblBrojLjudi = new System.Windows.Forms.Label();
            this.numBrojljudi = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.chbPotvrdjeno = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chbOtkazano = new System.Windows.Forms.CheckBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPregled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojljudi)).BeginInit();
            this.SuspendLayout();
            // 
            // picEdit
            // 
            this.picEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.picEdit.Image = ((System.Drawing.Image)(resources.GetObject("picEdit.Image")));
            this.picEdit.Location = new System.Drawing.Point(40, 0);
            this.picEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picEdit.Name = "picEdit";
            this.picEdit.Size = new System.Drawing.Size(129, 114);
            this.picEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picEdit.TabIndex = 56;
            this.picEdit.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 37);
            this.panel2.TabIndex = 55;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(635, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picPregled
            // 
            this.picPregled.Image = ((System.Drawing.Image)(resources.GetObject("picPregled.Image")));
            this.picPregled.Location = new System.Drawing.Point(423, 42);
            this.picPregled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPregled.Name = "picPregled";
            this.picPregled.Size = new System.Drawing.Size(176, 59);
            this.picPregled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPregled.TabIndex = 57;
            this.picPregled.TabStop = false;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrezime.Location = new System.Drawing.Point(293, 165);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.ReadOnly = true;
            this.txtPrezime.Size = new System.Drawing.Size(118, 26);
            this.txtPrezime.TabIndex = 65;
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIme.Location = new System.Drawing.Point(164, 165);
            this.txtIme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(108, 26);
            this.txtIme.TabIndex = 63;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.Location = new System.Drawing.Point(40, 170);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(101, 18);
            this.lblIme.TabIndex = 62;
            this.lblIme.Text = "Ime/Prezime";
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNapomena.Location = new System.Drawing.Point(40, 281);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(92, 18);
            this.lblNapomena.TabIndex = 67;
            this.lblNapomena.Text = "Napomena";
            // 
            // lblBrojLjudi
            // 
            this.lblBrojLjudi.AutoSize = true;
            this.lblBrojLjudi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojLjudi.Location = new System.Drawing.Point(40, 226);
            this.lblBrojLjudi.Name = "lblBrojLjudi";
            this.lblBrojLjudi.Size = new System.Drawing.Size(71, 18);
            this.lblBrojLjudi.TabIndex = 68;
            this.lblBrojLjudi.Text = "Broj ljudi";
            // 
            // numBrojljudi
            // 
            this.numBrojljudi.Location = new System.Drawing.Point(164, 226);
            this.numBrojljudi.Margin = new System.Windows.Forms.Padding(4);
            this.numBrojljudi.Name = "numBrojljudi";
            this.numBrojljudi.ReadOnly = true;
            this.numBrojljudi.Size = new System.Drawing.Size(44, 22);
            this.numBrojljudi.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(40, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 72;
            this.label3.Text = "Datum";
            // 
            // dateTime
            // 
            this.dateTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dateTime.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dateTime.CustomFormat = "dd.MM.yyyy h:mm tt";
            this.dateTime.Enabled = false;
            this.dateTime.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime.Location = new System.Drawing.Point(164, 420);
            this.dateTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(247, 23);
            this.dateTime.TabIndex = 71;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.btnPotvrdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPotvrdi.FlatAppearance.BorderSize = 0;
            this.btnPotvrdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrdi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPotvrdi.ForeColor = System.Drawing.Color.White;
            this.btnPotvrdi.Location = new System.Drawing.Point(552, 512);
            this.btnPotvrdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(95, 31);
            this.btnPotvrdi.TabIndex = 73;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = false;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.BackColor = System.Drawing.Color.Gray;
            this.btnOtkazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOtkazi.FlatAppearance.BorderSize = 0;
            this.btnOtkazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtkazi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOtkazi.ForeColor = System.Drawing.Color.White;
            this.btnOtkazi.Location = new System.Drawing.Point(423, 512);
            this.btnOtkazi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(95, 31);
            this.btnOtkazi.TabIndex = 74;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = false;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // chbPotvrdjeno
            // 
            this.chbPotvrdjeno.AutoSize = true;
            this.chbPotvrdjeno.Enabled = false;
            this.chbPotvrdjeno.Location = new System.Drawing.Point(164, 470);
            this.chbPotvrdjeno.Margin = new System.Windows.Forms.Padding(4);
            this.chbPotvrdjeno.Name = "chbPotvrdjeno";
            this.chbPotvrdjeno.Size = new System.Drawing.Size(98, 21);
            this.chbPotvrdjeno.TabIndex = 75;
            this.chbPotvrdjeno.Text = "checkBox1";
            this.chbPotvrdjeno.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(40, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 76;
            this.label1.Text = "Potvrđeno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(40, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 78;
            this.label2.Text = "Otkazano";
            // 
            // chbOtkazano
            // 
            this.chbOtkazano.AutoSize = true;
            this.chbOtkazano.Enabled = false;
            this.chbOtkazano.Location = new System.Drawing.Point(164, 512);
            this.chbOtkazano.Margin = new System.Windows.Forms.Padding(4);
            this.chbOtkazano.Name = "chbOtkazano";
            this.chbOtkazano.Size = new System.Drawing.Size(98, 21);
            this.chbOtkazano.TabIndex = 77;
            this.chbOtkazano.Text = "checkBox1";
            this.chbOtkazano.UseVisualStyleBackColor = true;
            // 
            // txtNaziv
            // 
            this.txtNaziv.BackColor = System.Drawing.Color.White;
            this.txtNaziv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNaziv.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNaziv.Location = new System.Drawing.Point(261, 75);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNaziv.Multiline = true;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.ReadOnly = true;
            this.txtNaziv.Size = new System.Drawing.Size(156, 22);
            this.txtNaziv.TabIndex = 80;
            this.txtNaziv.Text = "Rezervacija no2";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(164, 281);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(247, 87);
            this.txtNapomena.TabIndex = 81;
            // 
            // frmPregledRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 567);
            this.ControlBox = false;
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chbOtkazano);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chbPotvrdjeno);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.numBrojljudi);
            this.Controls.Add(this.lblBrojLjudi);
            this.Controls.Add(this.lblNapomena);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.picEdit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.picPregled);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPregledRezervacije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPregledRezervacije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPregled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojljudi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picEdit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picPregled;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.Label lblBrojLjudi;
        private System.Windows.Forms.NumericUpDown numBrojljudi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.CheckBox chbPotvrdjeno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbOtkazano;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtNapomena;
    }
}