namespace getFood_UI.Meni
{
    partial class frmDodajProizvod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDodajProizvod));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.picDodajProizvod = new System.Windows.Forms.PictureBox();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnSnimiProizvod = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSastojci = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chListSastojci = new System.Windows.Forms.CheckedListBox();
            this.decCijena = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picNew = new System.Windows.Forms.PictureBox();
            this.picEdit = new System.Windows.Forms.PictureBox();
            this.txtPretraziSastojak = new System.Windows.Forms.TextBox();
            this.btnDodajSastojak = new System.Windows.Forms.PictureBox();
            this.txtDodajSastojak = new System.Windows.Forms.TextBox();
            this.btnPretraziSastojak = new System.Windows.Forms.PictureBox();
            this.btnObrisiProizvod = new System.Windows.Forms.Button();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chbMeni = new System.Windows.Forms.CheckedListBox();
            this.picUrediUredi = new System.Windows.Forms.PictureBox();
            this.picPregledUredi = new System.Windows.Forms.PictureBox();
            this.picDodajUredi = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.btnDodajSliku = new System.Windows.Forms.PictureBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.errorProviderProdukti = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picDodajProizvod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decCijena)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDodajSastojak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPretraziSastojak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUrediUredi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPregledUredi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDodajUredi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDodajSliku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProdukti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(49, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNaziv.Location = new System.Drawing.Point(164, 148);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(2);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(156, 26);
            this.txtNaziv.TabIndex = 1;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // picDodajProizvod
            // 
            this.picDodajProizvod.Image = ((System.Drawing.Image)(resources.GetObject("picDodajProizvod.Image")));
            this.picDodajProizvod.Location = new System.Drawing.Point(359, 186);
            this.picDodajProizvod.Margin = new System.Windows.Forms.Padding(0);
            this.picDodajProizvod.Name = "picDodajProizvod";
            this.picDodajProizvod.Size = new System.Drawing.Size(265, 265);
            this.picDodajProizvod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDodajProizvod.TabIndex = 0;
            this.picDodajProizvod.TabStop = false;
            // 
            // btnUredi
            // 
            this.btnUredi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.btnUredi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUredi.FlatAppearance.BorderSize = 0;
            this.btnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUredi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUredi.ForeColor = System.Drawing.Color.White;
            this.btnUredi.Location = new System.Drawing.Point(529, 524);
            this.btnUredi.Margin = new System.Windows.Forms.Padding(2);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(95, 31);
            this.btnUredi.TabIndex = 11;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
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
            this.btnSnimiProizvod.Margin = new System.Windows.Forms.Padding(2);
            this.btnSnimiProizvod.Name = "btnSnimiProizvod";
            this.btnSnimiProizvod.Size = new System.Drawing.Size(95, 31);
            this.btnSnimiProizvod.TabIndex = 1;
            this.btnSnimiProizvod.Text = "Snimi";
            this.btnSnimiProizvod.UseVisualStyleBackColor = false;
            this.btnSnimiProizvod.Click += new System.EventHandler(this.btnSnimiProizvod_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(49, 275);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cijena";
            // 
            // txtSastojci
            // 
            this.txtSastojci.AutoSize = true;
            this.txtSastojci.BackColor = System.Drawing.Color.White;
            this.txtSastojci.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSastojci.Location = new System.Drawing.Point(49, 466);
            this.txtSastojci.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtSastojci.Name = "txtSastojci";
            this.txtSastojci.Size = new System.Drawing.Size(64, 18);
            this.txtSastojci.TabIndex = 5;
            this.txtSastojci.Text = "Sastojci";
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOpis.Location = new System.Drawing.Point(164, 186);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(2);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(156, 26);
            this.txtOpis.TabIndex = 8;
            this.txtOpis.Validating += new System.ComponentModel.CancelEventHandler(this.txtOpis_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(49, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Opis";
            // 
            // chListSastojci
            // 
            this.chListSastojci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chListSastojci.CheckOnClick = true;
            this.chListSastojci.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chListSastojci.ForeColor = System.Drawing.Color.Black;
            this.chListSastojci.FormattingEnabled = true;
            this.chListSastojci.Location = new System.Drawing.Point(164, 428);
            this.chListSastojci.Margin = new System.Windows.Forms.Padding(0);
            this.chListSastojci.Name = "chListSastojci";
            this.chListSastojci.Size = new System.Drawing.Size(156, 92);
            this.chListSastojci.TabIndex = 9;
            this.chListSastojci.Validating += new System.ComponentModel.CancelEventHandler(this.chListSastojci_Validating);
            // 
            // decCijena
            // 
            this.decCijena.DecimalPlaces = 2;
            this.decCijena.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.decCijena.Location = new System.Drawing.Point(164, 268);
            this.decCijena.Margin = new System.Windows.Forms.Padding(2);
            this.decCijena.Name = "decCijena";
            this.decCijena.Size = new System.Drawing.Size(158, 26);
            this.decCijena.TabIndex = 13;
            this.decCijena.Validating += new System.ComponentModel.CancelEventHandler(this.decCijena_Validating);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 38);
            this.panel2.TabIndex = 14;
            // 
            // picNew
            // 
            this.picNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.picNew.Image = ((System.Drawing.Image)(resources.GetObject("picNew.Image")));
            this.picNew.Location = new System.Drawing.Point(45, 0);
            this.picNew.Margin = new System.Windows.Forms.Padding(2);
            this.picNew.Name = "picNew";
            this.picNew.Size = new System.Drawing.Size(122, 116);
            this.picNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNew.TabIndex = 15;
            this.picNew.TabStop = false;
            // 
            // picEdit
            // 
            this.picEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.picEdit.Image = ((System.Drawing.Image)(resources.GetObject("picEdit.Image")));
            this.picEdit.Location = new System.Drawing.Point(45, 0);
            this.picEdit.Margin = new System.Windows.Forms.Padding(2);
            this.picEdit.Name = "picEdit";
            this.picEdit.Size = new System.Drawing.Size(125, 116);
            this.picEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEdit.TabIndex = 16;
            this.picEdit.TabStop = false;
            // 
            // txtPretraziSastojak
            // 
            this.txtPretraziSastojak.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPretraziSastojak.Location = new System.Drawing.Point(164, 400);
            this.txtPretraziSastojak.Margin = new System.Windows.Forms.Padding(0);
            this.txtPretraziSastojak.Name = "txtPretraziSastojak";
            this.txtPretraziSastojak.Size = new System.Drawing.Size(116, 23);
            this.txtPretraziSastojak.TabIndex = 20;
            this.txtPretraziSastojak.Text = "Unesite pojam";
            this.txtPretraziSastojak.TextChanged += new System.EventHandler(this.txtPretraziSastojak_TextChanged);
            // 
            // btnDodajSastojak
            // 
            this.btnDodajSastojak.BackColor = System.Drawing.Color.White;
            this.btnDodajSastojak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodajSastojak.Image = ((System.Drawing.Image)(resources.GetObject("btnDodajSastojak.Image")));
            this.btnDodajSastojak.Location = new System.Drawing.Point(291, 524);
            this.btnDodajSastojak.Margin = new System.Windows.Forms.Padding(0);
            this.btnDodajSastojak.Name = "btnDodajSastojak";
            this.btnDodajSastojak.Size = new System.Drawing.Size(30, 32);
            this.btnDodajSastojak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDodajSastojak.TabIndex = 18;
            this.btnDodajSastojak.TabStop = false;
            this.btnDodajSastojak.Click += new System.EventHandler(this.btnDodajSastojak_Click);
            // 
            // txtDodajSastojak
            // 
            this.txtDodajSastojak.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDodajSastojak.Location = new System.Drawing.Point(164, 531);
            this.txtDodajSastojak.Margin = new System.Windows.Forms.Padding(0);
            this.txtDodajSastojak.Name = "txtDodajSastojak";
            this.txtDodajSastojak.Size = new System.Drawing.Size(116, 23);
            this.txtDodajSastojak.TabIndex = 17;
            this.txtDodajSastojak.Text = "Unesite pojam";
            this.txtDodajSastojak.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDodajSastojak_KeyDown);
            this.txtDodajSastojak.Validating += new System.ComponentModel.CancelEventHandler(this.txtDodajSastojak_Validating);
            // 
            // btnPretraziSastojak
            // 
            this.btnPretraziSastojak.BackColor = System.Drawing.Color.White;
            this.btnPretraziSastojak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPretraziSastojak.Image = ((System.Drawing.Image)(resources.GetObject("btnPretraziSastojak.Image")));
            this.btnPretraziSastojak.Location = new System.Drawing.Point(291, 385);
            this.btnPretraziSastojak.Margin = new System.Windows.Forms.Padding(0);
            this.btnPretraziSastojak.Name = "btnPretraziSastojak";
            this.btnPretraziSastojak.Size = new System.Drawing.Size(30, 40);
            this.btnPretraziSastojak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPretraziSastojak.TabIndex = 21;
            this.btnPretraziSastojak.TabStop = false;
            // 
            // btnObrisiProizvod
            // 
            this.btnObrisiProizvod.BackColor = System.Drawing.Color.Gray;
            this.btnObrisiProizvod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObrisiProizvod.FlatAppearance.BorderSize = 0;
            this.btnObrisiProizvod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiProizvod.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiProizvod.ForeColor = System.Drawing.Color.White;
            this.btnObrisiProizvod.Location = new System.Drawing.Point(359, 524);
            this.btnObrisiProizvod.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrisiProizvod.Name = "btnObrisiProizvod";
            this.btnObrisiProizvod.Size = new System.Drawing.Size(95, 31);
            this.btnObrisiProizvod.TabIndex = 23;
            this.btnObrisiProizvod.Text = "Obriši";
            this.btnObrisiProizvod.UseVisualStyleBackColor = false;
            this.btnObrisiProizvod.Click += new System.EventHandler(this.btnObrisiProizvod_Click);
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(164, 225);
            this.cmbKategorija.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(156, 28);
            this.cmbKategorija.TabIndex = 24;
            this.cmbKategorija.Text = "Odaberite";
            this.cmbKategorija.Validating += new System.ComponentModel.CancelEventHandler(this.cmbKategorija_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(49, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Kategorija";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(49, 336);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "Meni";
            // 
            // chbMeni
            // 
            this.chbMeni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chbMeni.CheckOnClick = true;
            this.chbMeni.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbMeni.FormattingEnabled = true;
            this.chbMeni.Location = new System.Drawing.Point(164, 309);
            this.chbMeni.Margin = new System.Windows.Forms.Padding(0);
            this.chbMeni.Name = "chbMeni";
            this.chbMeni.Size = new System.Drawing.Size(156, 74);
            this.chbMeni.TabIndex = 22;
            this.chbMeni.Validating += new System.ComponentModel.CancelEventHandler(this.chbMeni_Validating);
            // 
            // picUrediUredi
            // 
            this.picUrediUredi.Image = ((System.Drawing.Image)(resources.GetObject("picUrediUredi.Image")));
            this.picUrediUredi.Location = new System.Drawing.Point(422, 42);
            this.picUrediUredi.Margin = new System.Windows.Forms.Padding(2);
            this.picUrediUredi.Name = "picUrediUredi";
            this.picUrediUredi.Size = new System.Drawing.Size(165, 60);
            this.picUrediUredi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUrediUredi.TabIndex = 29;
            this.picUrediUredi.TabStop = false;
            // 
            // picPregledUredi
            // 
            this.picPregledUredi.Image = ((System.Drawing.Image)(resources.GetObject("picPregledUredi.Image")));
            this.picPregledUredi.Location = new System.Drawing.Point(422, 42);
            this.picPregledUredi.Margin = new System.Windows.Forms.Padding(2);
            this.picPregledUredi.Name = "picPregledUredi";
            this.picPregledUredi.Size = new System.Drawing.Size(165, 60);
            this.picPregledUredi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPregledUredi.TabIndex = 30;
            this.picPregledUredi.TabStop = false;
            // 
            // picDodajUredi
            // 
            this.picDodajUredi.Image = ((System.Drawing.Image)(resources.GetObject("picDodajUredi.Image")));
            this.picDodajUredi.Location = new System.Drawing.Point(422, 42);
            this.picDodajUredi.Margin = new System.Windows.Forms.Padding(2);
            this.picDodajUredi.Name = "picDodajUredi";
            this.picDodajUredi.Size = new System.Drawing.Size(165, 60);
            this.picDodajUredi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDodajUredi.TabIndex = 31;
            this.picDodajUredi.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(355, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Slika";
            // 
            // txtSlika
            // 
            this.txtSlika.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSlika.Location = new System.Drawing.Point(422, 148);
            this.txtSlika.Margin = new System.Windows.Forms.Padding(2);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(165, 26);
            this.txtSlika.TabIndex = 12;
            this.txtSlika.Validating += new System.ComponentModel.CancelEventHandler(this.txtSlika_Validating);
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodajSliku.Image = ((System.Drawing.Image)(resources.GetObject("btnDodajSliku.Image")));
            this.btnDodajSliku.Location = new System.Drawing.Point(594, 148);
            this.btnDodajSliku.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(30, 26);
            this.btnDodajSliku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDodajSliku.TabIndex = 19;
            this.btnDodajSliku.TabStop = false;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRating.ForeColor = System.Drawing.Color.Black;
            this.lblRating.Location = new System.Drawing.Point(356, 466);
            this.lblRating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(54, 18);
            this.lblRating.TabIndex = 32;
            this.lblRating.Text = "Rating";
            this.lblRating.Visible = false;
            // 
            // txtRating
            // 
            this.txtRating.BackColor = System.Drawing.Color.White;
            this.txtRating.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtRating.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.txtRating.Location = new System.Drawing.Point(417, 466);
            this.txtRating.Margin = new System.Windows.Forms.Padding(2);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(37, 19);
            this.txtRating.TabIndex = 34;
            this.txtRating.Visible = false;
            this.txtRating.Click += new System.EventHandler(this.txtRating_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(458, 464);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(26, 21);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 33;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            // 
            // errorProviderProdukti
            // 
            this.errorProviderProdukti.ContainerControl = this;
            // 
            // frmDodajProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 582);
            this.ControlBox = false;
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.txtDodajSastojak);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.txtPretraziSastojak);
            this.Controls.Add(this.picDodajUredi);
            this.Controls.Add(this.btnPretraziSastojak);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.btnDodajSastojak);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chListSastojci);
            this.Controls.Add(this.picPregledUredi);
            this.Controls.Add(this.picUrediUredi);
            this.Controls.Add(this.picDodajProizvod);
            this.Controls.Add(this.chbMeni);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.btnObrisiProizvod);
            this.Controls.Add(this.btnSnimiProizvod);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.picEdit);
            this.Controls.Add(this.picNew);
            this.Controls.Add(this.decCijena);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSastojci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDodajProizvod";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDodajProizvod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDodajProizvod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decCijena)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDodajSastojak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPretraziSastojak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUrediUredi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPregledUredi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDodajUredi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDodajSliku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProdukti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.PictureBox picDodajProizvod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtSastojci;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox chbMeni;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSnimiProizvod;
        private System.Windows.Forms.NumericUpDown decCijena;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picNew;
        private System.Windows.Forms.PictureBox picEdit;
        private System.Windows.Forms.TextBox txtPretraziSastojak;
        private System.Windows.Forms.PictureBox btnDodajSastojak;
        private System.Windows.Forms.TextBox txtDodajSastojak;
        private System.Windows.Forms.PictureBox btnPretraziSastojak;
        private System.Windows.Forms.Button btnObrisiProizvod;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        //private System.Windows.Forms.CheckedListBox chbMeni;
        private System.Windows.Forms.CheckedListBox chListSastojci;
        private System.Windows.Forms.PictureBox picUrediUredi;
        private System.Windows.Forms.PictureBox picPregledUredi;
        private System.Windows.Forms.PictureBox picDodajUredi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.PictureBox btnDodajSliku;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.ErrorProvider errorProviderProdukti;
    }
}