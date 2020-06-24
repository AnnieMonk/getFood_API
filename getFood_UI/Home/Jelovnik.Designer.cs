namespace getFood_UI.Home
{
    partial class Jelovnik
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jelovnik));
            this.produktiGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.PictureBox();
            this.cmbMeni = new System.Windows.Forms.ComboBox();
            this.btnDodajMeni = new System.Windows.Forms.Button();
            this.btnDodajProizvod = new System.Windows.Forms.Button();
            this.btnPogledajMeni = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.produktiGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPretrazi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPogledajMeni)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
            this.Cijena});
            this.produktiGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.produktiGrid.EnableHeadersVisualStyles = false;
            this.produktiGrid.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.produktiGrid.Location = new System.Drawing.Point(54, 169);
            this.produktiGrid.Margin = new System.Windows.Forms.Padding(2);
            this.produktiGrid.Name = "produktiGrid";
            this.produktiGrid.ReadOnly = true;
            this.produktiGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produktiGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.produktiGrid.RowHeadersVisible = false;
            this.produktiGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.produktiGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.produktiGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.produktiGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.produktiGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.produktiGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.produktiGrid.RowTemplate.Height = 30;
            this.produktiGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.produktiGrid.Size = new System.Drawing.Size(1015, 476);
            this.produktiGrid.TabIndex = 2;
            this.produktiGrid.TabStop = false;
            this.produktiGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.produktiGrid_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ProduktiId";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(54, 649);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(311, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "*Dvoklikom na red otvarate detalje o proizvodu";
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPretrazi.Location = new System.Drawing.Point(872, 125);
            this.txtPretrazi.Margin = new System.Windows.Forms.Padding(2);
            this.txtPretrazi.Multiline = true;
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(157, 31);
            this.txtPretrazi.TabIndex = 4;
            this.txtPretrazi.Text = "Unesite pojam";
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPretrazi.Image = ((System.Drawing.Image)(resources.GetObject("btnPretrazi.Image")));
            this.btnPretrazi.Location = new System.Drawing.Point(1033, 125);
            this.btnPretrazi.Margin = new System.Windows.Forms.Padding(2);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(36, 31);
            this.btnPretrazi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPretrazi.TabIndex = 6;
            this.btnPretrazi.TabStop = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // cmbMeni
            // 
            this.cmbMeni.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbMeni.FormattingEnabled = true;
            this.cmbMeni.Location = new System.Drawing.Point(54, 128);
            this.cmbMeni.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMeni.Name = "cmbMeni";
            this.cmbMeni.Size = new System.Drawing.Size(174, 28);
            this.cmbMeni.TabIndex = 8;
            this.cmbMeni.Text = "Odaberite meni";
            this.cmbMeni.SelectedIndexChanged += new System.EventHandler(this.cmbMeni_SelectedIndexChanged);
            // 
            // btnDodajMeni
            // 
            this.btnDodajMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.btnDodajMeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDodajMeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodajMeni.FlatAppearance.BorderSize = 0;
            this.btnDodajMeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajMeni.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajMeni.ForeColor = System.Drawing.Color.White;
            this.btnDodajMeni.Image = ((System.Drawing.Image)(resources.GetObject("btnDodajMeni.Image")));
            this.btnDodajMeni.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodajMeni.Location = new System.Drawing.Point(568, 93);
            this.btnDodajMeni.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajMeni.Name = "btnDodajMeni";
            this.btnDodajMeni.Size = new System.Drawing.Size(121, 46);
            this.btnDodajMeni.TabIndex = 9;
            this.btnDodajMeni.Text = "Meni";
            this.btnDodajMeni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajMeni.UseVisualStyleBackColor = false;
            this.btnDodajMeni.Click += new System.EventHandler(this.btnDodajMeni_Click);
            // 
            // btnDodajProizvod
            // 
            this.btnDodajProizvod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.btnDodajProizvod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodajProizvod.FlatAppearance.BorderSize = 0;
            this.btnDodajProizvod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajProizvod.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajProizvod.ForeColor = System.Drawing.Color.White;
            this.btnDodajProizvod.Image = ((System.Drawing.Image)(resources.GetObject("btnDodajProizvod.Image")));
            this.btnDodajProizvod.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodajProizvod.Location = new System.Drawing.Point(416, 93);
            this.btnDodajProizvod.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajProizvod.Name = "btnDodajProizvod";
            this.btnDodajProizvod.Size = new System.Drawing.Size(132, 47);
            this.btnDodajProizvod.TabIndex = 1;
            this.btnDodajProizvod.Text = "Proizvod";
            this.btnDodajProizvod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajProizvod.UseVisualStyleBackColor = false;
            this.btnDodajProizvod.Click += new System.EventHandler(this.btnDodajProizvod_Click);
            // 
            // btnPogledajMeni
            // 
            this.btnPogledajMeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPogledajMeni.Image = ((System.Drawing.Image)(resources.GetObject("btnPogledajMeni.Image")));
            this.btnPogledajMeni.Location = new System.Drawing.Point(232, 125);
            this.btnPogledajMeni.Margin = new System.Windows.Forms.Padding(2);
            this.btnPogledajMeni.Name = "btnPogledajMeni";
            this.btnPogledajMeni.Size = new System.Drawing.Size(42, 30);
            this.btnPogledajMeni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPogledajMeni.TabIndex = 10;
            this.btnPogledajMeni.TabStop = false;
            this.toolTip1.SetToolTip(this.btnPogledajMeni, "Pogledaj meni");
            this.btnPogledajMeni.Click += new System.EventHandler(this.btnPogledajMeni_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.AutoPopDelay = 0;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            // 
            // Jelovnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnPogledajMeni);
            this.Controls.Add(this.btnDodajMeni);
            this.Controls.Add(this.cmbMeni);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.produktiGrid);
            this.Controls.Add(this.btnDodajProizvod);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Jelovnik";
            this.Size = new System.Drawing.Size(1121, 716);
            this.Load += new System.EventHandler(this.Jelovnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produktiGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPretrazi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPogledajMeni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView produktiGrid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.PictureBox btnPretrazi;
        private System.Windows.Forms.ComboBox cmbMeni;
        private System.Windows.Forms.Button btnDodajMeni;
        private System.Windows.Forms.Button btnDodajProizvod;
        private System.Windows.Forms.PictureBox btnPogledajMeni;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
    }
}
