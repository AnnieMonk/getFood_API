namespace getFood_UI.Narudzbe
{
    partial class frmPregledNarudzbe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledNarudzbe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picPregled = new System.Windows.Forms.PictureBox();
            this.picEdit = new System.Windows.Forms.PictureBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.produktiGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Količina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBrojNarudzbe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeNarudzba = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.chbProcesirana = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.btnProcesiraj = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPregled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktiGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 37);
            this.panel2.TabIndex = 50;
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
            this.picPregled.Location = new System.Drawing.Point(409, 41);
            this.picPregled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPregled.Name = "picPregled";
            this.picPregled.Size = new System.Drawing.Size(176, 59);
            this.picPregled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPregled.TabIndex = 52;
            this.picPregled.TabStop = false;
            // 
            // picEdit
            // 
            this.picEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.picEdit.Image = ((System.Drawing.Image)(resources.GetObject("picEdit.Image")));
            this.picEdit.Location = new System.Drawing.Point(34, -2);
            this.picEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picEdit.Name = "picEdit";
            this.picEdit.Size = new System.Drawing.Size(129, 114);
            this.picEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEdit.TabIndex = 51;
            this.picEdit.TabStop = false;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.Location = new System.Drawing.Point(36, 139);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(56, 18);
            this.lblNaziv.TabIndex = 54;
            this.lblNaziv.Text = "Kupac";
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.BackColor = System.Drawing.Color.White;
            this.txtImePrezime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImePrezime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtImePrezime.Location = new System.Drawing.Point(115, 139);
            this.txtImePrezime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImePrezime.Multiline = true;
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.ReadOnly = true;
            this.txtImePrezime.Size = new System.Drawing.Size(148, 22);
            this.txtImePrezime.TabIndex = 53;
            this.txtImePrezime.Text = "imeprzeime";
            // 
            // produktiGrid
            // 
            this.produktiGrid.AllowUserToAddRows = false;
            this.produktiGrid.AllowUserToDeleteRows = false;
            this.produktiGrid.AllowUserToOrderColumns = true;
            this.produktiGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.produktiGrid.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.produktiGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.produktiGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.produktiGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produktiGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.produktiGrid.ColumnHeadersHeight = 20;
            this.produktiGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Naziv,
            this.Opis,
            this.Cijena,
            this.Količina});
            this.produktiGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.produktiGrid.EnableHeadersVisualStyles = false;
            this.produktiGrid.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.produktiGrid.Location = new System.Drawing.Point(39, 268);
            this.produktiGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.produktiGrid.Name = "produktiGrid";
            this.produktiGrid.ReadOnly = true;
            this.produktiGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produktiGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.produktiGrid.RowHeadersVisible = false;
            this.produktiGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.produktiGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.produktiGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.produktiGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.produktiGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.produktiGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.produktiGrid.RowTemplate.Height = 30;
            this.produktiGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.produktiGrid.Size = new System.Drawing.Size(581, 231);
            this.produktiGrid.TabIndex = 55;
            this.produktiGrid.TabStop = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ProduktiId";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.MinimumWidth = 6;
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.MinimumWidth = 6;
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // Količina
            // 
            this.Količina.DataPropertyName = "Kolicina";
            this.Količina.HeaderText = "Količina";
            this.Količina.MinimumWidth = 6;
            this.Količina.Name = "Količina";
            this.Količina.ReadOnly = true;
            // 
            // txtBrojNarudzbe
            // 
            this.txtBrojNarudzbe.BackColor = System.Drawing.Color.White;
            this.txtBrojNarudzbe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBrojNarudzbe.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBrojNarudzbe.Location = new System.Drawing.Point(238, 81);
            this.txtBrojNarudzbe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBrojNarudzbe.Name = "txtBrojNarudzbe";
            this.txtBrojNarudzbe.ReadOnly = true;
            this.txtBrojNarudzbe.Size = new System.Drawing.Size(165, 19);
            this.txtBrojNarudzbe.TabIndex = 56;
            this.txtBrojNarudzbe.Text = "BrNarudzbe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(273, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 57;
            this.label1.Text = "Datum";
            // 
            // dateTimeNarudzba
            // 
            this.dateTimeNarudzba.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dateTimeNarudzba.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dateTimeNarudzba.CustomFormat = "dd.MM.yyyy h:mm tt";
            this.dateTimeNarudzba.Enabled = false;
            this.dateTimeNarudzba.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimeNarudzba.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNarudzba.Location = new System.Drawing.Point(371, 134);
            this.dateTimeNarudzba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeNarudzba.Name = "dateTimeNarudzba";
            this.dateTimeNarudzba.Size = new System.Drawing.Size(200, 23);
            this.dateTimeNarudzba.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(36, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 59;
            this.label2.Text = "Procesirana";
            // 
            // chbProcesirana
            // 
            this.chbProcesirana.AutoSize = true;
            this.chbProcesirana.Enabled = false;
            this.chbProcesirana.Location = new System.Drawing.Point(145, 543);
            this.chbProcesirana.Name = "chbProcesirana";
            this.chbProcesirana.Size = new System.Drawing.Size(18, 17);
            this.chbProcesirana.TabIndex = 60;
            this.chbProcesirana.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(273, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 61;
            this.label3.Text = "Napomena";
            // 
            // txtNapomena
            // 
            this.txtNapomena.BackColor = System.Drawing.Color.White;
            this.txtNapomena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNapomena.Enabled = false;
            this.txtNapomena.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNapomena.Location = new System.Drawing.Point(371, 172);
            this.txtNapomena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.ReadOnly = true;
            this.txtNapomena.Size = new System.Drawing.Size(249, 91);
            this.txtNapomena.TabIndex = 63;
            this.txtNapomena.Text = "Napomena";
            // 
            // btnProcesiraj
            // 
            this.btnProcesiraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.btnProcesiraj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesiraj.FlatAppearance.BorderSize = 0;
            this.btnProcesiraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesiraj.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProcesiraj.ForeColor = System.Drawing.Color.White;
            this.btnProcesiraj.Location = new System.Drawing.Point(525, 529);
            this.btnProcesiraj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProcesiraj.Name = "btnProcesiraj";
            this.btnProcesiraj.Size = new System.Drawing.Size(95, 31);
            this.btnProcesiraj.TabIndex = 64;
            this.btnProcesiraj.Text = "Procesiraj";
            this.btnProcesiraj.UseVisualStyleBackColor = false;
            this.btnProcesiraj.Click += new System.EventHandler(this.btnProcesiraj_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(39, 503);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(149, 22);
            this.textBox2.TabIndex = 66;
            this.textBox2.Text = "*Narudžba je plaćena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(36, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 68;
            this.label4.Text = "Kontakt";
            // 
            // txtTelefon
            // 
            this.txtTelefon.BackColor = System.Drawing.Color.White;
            this.txtTelefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefon.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTelefon.Location = new System.Drawing.Point(115, 171);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefon.Multiline = true;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.ReadOnly = true;
            this.txtTelefon.Size = new System.Drawing.Size(141, 22);
            this.txtTelefon.TabIndex = 67;
            this.txtTelefon.Text = "imeprzeime";
            // 
            // frmPregledNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 582);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnProcesiraj);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chbProcesirana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeNarudzba);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrojNarudzbe);
            this.Controls.Add(this.produktiGrid);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.picEdit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.picPregled);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPregledNarudzbe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPregledNarudzbe_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPregled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktiGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picPregled;
        private System.Windows.Forms.PictureBox picEdit;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.DataGridView produktiGrid;
        private System.Windows.Forms.TextBox txtBrojNarudzbe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeNarudzba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbProcesirana;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Button btnProcesiraj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Količina;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefon;
    }
}