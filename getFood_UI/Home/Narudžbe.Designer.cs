namespace getFood_UI.Home
{
    partial class Narudžbe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Narudžbe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.narudzbeGrid = new System.Windows.Forms.DataGridView();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.txtDatumDanas = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPretrazi = new System.Windows.Forms.PictureBox();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Procesirana = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPretrazi)).BeginInit();
            this.SuspendLayout();
            // 
            // narudzbeGrid
            // 
            this.narudzbeGrid.AllowUserToAddRows = false;
            this.narudzbeGrid.AllowUserToDeleteRows = false;
            this.narudzbeGrid.AllowUserToOrderColumns = true;
            this.narudzbeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.narudzbeGrid.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.narudzbeGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.narudzbeGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.narudzbeGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.narudzbeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.narudzbeGrid.ColumnHeadersHeight = 20;
            this.narudzbeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Naziv,
            this.Ime,
            this.Prezime,
            this.Procesirana});
            this.narudzbeGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.narudzbeGrid.EnableHeadersVisualStyles = false;
            this.narudzbeGrid.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.narudzbeGrid.Location = new System.Drawing.Point(53, 165);
            this.narudzbeGrid.Margin = new System.Windows.Forms.Padding(2);
            this.narudzbeGrid.Name = "narudzbeGrid";
            this.narudzbeGrid.ReadOnly = true;
            this.narudzbeGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.narudzbeGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.narudzbeGrid.RowHeadersVisible = false;
            this.narudzbeGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.narudzbeGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.narudzbeGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.narudzbeGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.narudzbeGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.narudzbeGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.narudzbeGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.narudzbeGrid.RowTemplate.Height = 30;
            this.narudzbeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.narudzbeGrid.Size = new System.Drawing.Size(1015, 476);
            this.narudzbeGrid.TabIndex = 3;
            this.narudzbeGrid.TabStop = false;
            this.narudzbeGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.narudzbeGrid_MouseDoubleClick);
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.BackColor = System.Drawing.Color.White;
            this.txtImePrezime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImePrezime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtImePrezime.Location = new System.Drawing.Point(140, 103);
            this.txtImePrezime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImePrezime.Multiline = true;
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.ReadOnly = true;
            this.txtImePrezime.Size = new System.Drawing.Size(202, 22);
            this.txtImePrezime.TabIndex = 54;
            this.txtImePrezime.Text = "Narudžbe za";
            // 
            // txtDatumDanas
            // 
            this.txtDatumDanas.BackColor = System.Drawing.Color.White;
            this.txtDatumDanas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDatumDanas.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDatumDanas.Location = new System.Drawing.Point(257, 103);
            this.txtDatumDanas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDatumDanas.Multiline = true;
            this.txtDatumDanas.Name = "txtDatumDanas";
            this.txtDatumDanas.ReadOnly = true;
            this.txtDatumDanas.Size = new System.Drawing.Size(202, 22);
            this.txtDatumDanas.TabIndex = 55;
            this.txtDatumDanas.Text = "Danas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPretrazi.Image = ((System.Drawing.Image)(resources.GetObject("btnPretrazi.Image")));
            this.btnPretrazi.Location = new System.Drawing.Point(1030, 103);
            this.btnPretrazi.Margin = new System.Windows.Forms.Padding(2);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(36, 31);
            this.btnPretrazi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPretrazi.TabIndex = 58;
            this.btnPretrazi.TabStop = false;
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPretrazi.Location = new System.Drawing.Point(869, 103);
            this.txtPretrazi.Margin = new System.Windows.Forms.Padding(2);
            this.txtPretrazi.Multiline = true;
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(157, 31);
            this.txtPretrazi.TabIndex = 57;
            this.txtPretrazi.Text = "Prezime kupca";
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "NarudzbaId";
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
            this.Naziv.DataPropertyName = "BrojNarudzbe";
            this.Naziv.HeaderText = "Broj narudžbe";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.MinimumWidth = 6;
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.MinimumWidth = 6;
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Procesirana
            // 
            this.Procesirana.HeaderText = "Procesirana";
            this.Procesirana.MinimumWidth = 6;
            this.Procesirana.Name = "Procesirana";
            this.Procesirana.ReadOnly = true;
            this.Procesirana.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Procesirana.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Narudžbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDatumDanas);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.narudzbeGrid);
            this.Name = "Narudžbe";
            this.Size = new System.Drawing.Size(1121, 716);
            this.Load += new System.EventHandler(this.Narudžbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPretrazi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView narudzbeGrid;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.TextBox txtDatumDanas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnPretrazi;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Procesirana;
    }
}
