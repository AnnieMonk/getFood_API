namespace getFood_UI.Meni
{
    partial class frmDodajMeni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDodajMeni));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picEdit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picDodaj = new System.Windows.Forms.PictureBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.dateTimeRok = new System.Windows.Forms.DateTimePicker();
            this.lblRok = new System.Windows.Forms.Label();
            this.lblOdaberiProizvode = new System.Windows.Forms.Label();
            this.btnSnimiProizvod = new System.Windows.Forms.Button();
            this.produktiGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odaberi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnPretrazi = new System.Windows.Forms.PictureBox();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUredi = new System.Windows.Forms.Button();
            this.picUredi = new System.Windows.Forms.PictureBox();
            this.picPregled = new System.Windows.Forms.PictureBox();
            this.btnObrisiMeni = new System.Windows.Forms.Button();
            this.errorProviderMeni = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDodaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktiGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPretrazi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUredi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPregled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMeni)).BeginInit();
            this.SuspendLayout();
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
            // picEdit
            // 
            this.picEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.picEdit.Image = ((System.Drawing.Image)(resources.GetObject("picEdit.Image")));
            this.picEdit.Location = new System.Drawing.Point(37, 0);
            this.picEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picEdit.Name = "picEdit";
            this.picEdit.Size = new System.Drawing.Size(129, 114);
            this.picEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEdit.TabIndex = 18;
            this.picEdit.TabStop = false;
            this.picEdit.Click += new System.EventHandler(this.picEdit_Click);
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
            this.panel2.TabIndex = 17;
            // 
            // picDodaj
            // 
            this.picDodaj.Image = ((System.Drawing.Image)(resources.GetObject("picDodaj.Image")));
            this.picDodaj.Location = new System.Drawing.Point(423, 42);
            this.picDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picDodaj.Name = "picDodaj";
            this.picDodaj.Size = new System.Drawing.Size(165, 60);
            this.picDodaj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDodaj.TabIndex = 32;
            this.picDodaj.TabStop = false;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNaziv.Location = new System.Drawing.Point(151, 155);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(165, 26);
            this.txtNaziv.TabIndex = 33;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.Location = new System.Drawing.Point(43, 162);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(48, 18);
            this.lblNaziv.TabIndex = 35;
            this.lblNaziv.Text = "Naziv";
            // 
            // dateTimeRok
            // 
            this.dateTimeRok.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dateTimeRok.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dateTimeRok.CustomFormat = "dd.MM.yyyy h:mm tt";
            this.dateTimeRok.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimeRok.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeRok.Location = new System.Drawing.Point(151, 526);
            this.dateTimeRok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeRok.Name = "dateTimeRok";
            this.dateTimeRok.Size = new System.Drawing.Size(165, 23);
            this.dateTimeRok.TabIndex = 36;
            this.dateTimeRok.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimeRok_Validating);
            // 
            // lblRok
            // 
            this.lblRok.AutoSize = true;
            this.lblRok.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRok.Location = new System.Drawing.Point(44, 528);
            this.lblRok.Name = "lblRok";
            this.lblRok.Size = new System.Drawing.Size(80, 18);
            this.lblRok.TabIndex = 37;
            this.lblRok.Text = "Vrijedi do";
            // 
            // lblOdaberiProizvode
            // 
            this.lblOdaberiProizvode.AutoSize = true;
            this.lblOdaberiProizvode.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdaberiProizvode.Location = new System.Drawing.Point(44, 255);
            this.lblOdaberiProizvode.Name = "lblOdaberiProizvode";
            this.lblOdaberiProizvode.Size = new System.Drawing.Size(148, 18);
            this.lblOdaberiProizvode.TabIndex = 38;
            this.lblOdaberiProizvode.Text = "Odaberi proizvode";
            // 
            // btnSnimiProizvod
            // 
            this.btnSnimiProizvod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.btnSnimiProizvod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSnimiProizvod.FlatAppearance.BorderSize = 0;
            this.btnSnimiProizvod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnimiProizvod.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSnimiProizvod.ForeColor = System.Drawing.Color.White;
            this.btnSnimiProizvod.Location = new System.Drawing.Point(529, 523);
            this.btnSnimiProizvod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSnimiProizvod.Name = "btnSnimiProizvod";
            this.btnSnimiProizvod.Size = new System.Drawing.Size(95, 31);
            this.btnSnimiProizvod.TabIndex = 40;
            this.btnSnimiProizvod.Text = "Snimi";
            this.btnSnimiProizvod.UseVisualStyleBackColor = false;
            this.btnSnimiProizvod.Click += new System.EventHandler(this.btnSnimiProizvod_Click);
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
            this.Odaberi});
            this.produktiGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.produktiGrid.EnableHeadersVisualStyles = false;
            this.produktiGrid.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.produktiGrid.Location = new System.Drawing.Point(43, 284);
            this.produktiGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.produktiGrid.Name = "produktiGrid";
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
            this.produktiGrid.TabIndex = 41;
            this.produktiGrid.TabStop = false;
            this.produktiGrid.Validating += new System.ComponentModel.CancelEventHandler(this.produktiGrid_Validating);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ProduktiId";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.MinimumWidth = 6;
            this.Opis.Name = "Opis";
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.MinimumWidth = 6;
            this.Cijena.Name = "Cijena";
            // 
            // Odaberi
            // 
            this.Odaberi.HeaderText = "Odaberi";
            this.Odaberi.MinimumWidth = 6;
            this.Odaberi.Name = "Odaberi";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPretrazi.Image = ((System.Drawing.Image)(resources.GetObject("btnPretrazi.Image")));
            this.btnPretrazi.Location = new System.Drawing.Point(584, 250);
            this.btnPretrazi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(40, 30);
            this.btnPretrazi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPretrazi.TabIndex = 44;
            this.btnPretrazi.TabStop = false;
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPretrazi.Location = new System.Drawing.Point(429, 250);
            this.txtPretrazi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPretrazi.Multiline = true;
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(148, 29);
            this.txtPretrazi.TabIndex = 43;
            this.txtPretrazi.Text = "Unesite pojam";
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOpis.Location = new System.Drawing.Point(151, 188);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(165, 62);
            this.txtOpis.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(44, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 46;
            this.label1.Text = "Opis ";
            // 
            // btnUredi
            // 
            this.btnUredi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.btnUredi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUredi.FlatAppearance.BorderSize = 0;
            this.btnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUredi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUredi.ForeColor = System.Drawing.Color.White;
            this.btnUredi.Location = new System.Drawing.Point(529, 523);
            this.btnUredi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(95, 31);
            this.btnUredi.TabIndex = 47;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // picUredi
            // 
            this.picUredi.Image = ((System.Drawing.Image)(resources.GetObject("picUredi.Image")));
            this.picUredi.Location = new System.Drawing.Point(423, 43);
            this.picUredi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picUredi.Name = "picUredi";
            this.picUredi.Size = new System.Drawing.Size(165, 59);
            this.picUredi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUredi.TabIndex = 48;
            this.picUredi.TabStop = false;
            // 
            // picPregled
            // 
            this.picPregled.Image = ((System.Drawing.Image)(resources.GetObject("picPregled.Image")));
            this.picPregled.Location = new System.Drawing.Point(412, 43);
            this.picPregled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPregled.Name = "picPregled";
            this.picPregled.Size = new System.Drawing.Size(176, 59);
            this.picPregled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPregled.TabIndex = 49;
            this.picPregled.TabStop = false;
            // 
            // btnObrisiMeni
            // 
            this.btnObrisiMeni.BackColor = System.Drawing.Color.Gray;
            this.btnObrisiMeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObrisiMeni.FlatAppearance.BorderSize = 0;
            this.btnObrisiMeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiMeni.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiMeni.ForeColor = System.Drawing.Color.White;
            this.btnObrisiMeni.Location = new System.Drawing.Point(383, 523);
            this.btnObrisiMeni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObrisiMeni.Name = "btnObrisiMeni";
            this.btnObrisiMeni.Size = new System.Drawing.Size(101, 31);
            this.btnObrisiMeni.TabIndex = 50;
            this.btnObrisiMeni.Text = "Obriši";
            this.btnObrisiMeni.UseVisualStyleBackColor = false;
            this.btnObrisiMeni.Click += new System.EventHandler(this.btnObrisiMeni_Click);
            // 
            // errorProviderMeni
            // 
            this.errorProviderMeni.ContainerControl = this;
            // 
            // frmDodajMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 582);
            this.ControlBox = false;
            this.Controls.Add(this.btnObrisiMeni);
            this.Controls.Add(this.picPregled);
            this.Controls.Add(this.picUredi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.produktiGrid);
            this.Controls.Add(this.btnSnimiProizvod);
            this.Controls.Add(this.lblOdaberiProizvode);
            this.Controls.Add(this.lblRok);
            this.Controls.Add(this.dateTimeRok);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.picDodaj);
            this.Controls.Add(this.picEdit);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDodajMeni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDodajMeni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDodaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktiGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPretrazi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUredi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPregled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMeni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picEdit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picDodaj;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.DateTimePicker dateTimeRok;
        private System.Windows.Forms.Label lblRok;
        private System.Windows.Forms.Label lblOdaberiProizvode;
        private System.Windows.Forms.Button btnSnimiProizvod;
        private System.Windows.Forms.DataGridView produktiGrid;
        private System.Windows.Forms.PictureBox btnPretrazi;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Odaberi;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.PictureBox picUredi;
        private System.Windows.Forms.PictureBox picPregled;
        private System.Windows.Forms.Button btnObrisiMeni;
        private System.Windows.Forms.ErrorProvider errorProviderMeni;
    }
}