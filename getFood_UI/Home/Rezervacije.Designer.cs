namespace getFood_UI.Home
{
    partial class Rezervacije
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rezervacije));
            this.rezervacijeGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pregledano = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnPretrazi = new System.Windows.Forms.PictureBox();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.btnDodajRezervaciju = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPretrazi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rezervacijeGrid
            // 
            this.rezervacijeGrid.AllowUserToAddRows = false;
            this.rezervacijeGrid.AllowUserToDeleteRows = false;
            this.rezervacijeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rezervacijeGrid.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.rezervacijeGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rezervacijeGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.rezervacijeGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rezervacijeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rezervacijeGrid.ColumnHeadersHeight = 20;
            this.rezervacijeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ime,
            this.Prezime,
            this.DatumVrijeme,
            this.Pregledano});
            this.rezervacijeGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rezervacijeGrid.EnableHeadersVisualStyles = false;
            this.rezervacijeGrid.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.rezervacijeGrid.Location = new System.Drawing.Point(53, 165);
            this.rezervacijeGrid.Margin = new System.Windows.Forms.Padding(2);
            this.rezervacijeGrid.Name = "rezervacijeGrid";
            this.rezervacijeGrid.ReadOnly = true;
            this.rezervacijeGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rezervacijeGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.rezervacijeGrid.RowHeadersVisible = false;
            this.rezervacijeGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.rezervacijeGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.rezervacijeGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.rezervacijeGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rezervacijeGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.rezervacijeGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.rezervacijeGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.rezervacijeGrid.RowTemplate.Height = 30;
            this.rezervacijeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rezervacijeGrid.Size = new System.Drawing.Size(1015, 476);
            this.rezervacijeGrid.TabIndex = 3;
            this.rezervacijeGrid.TabStop = false;
            this.rezervacijeGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.rezervacijeGrid_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "RezervacijaId";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
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
            // DatumVrijeme
            // 
            this.DatumVrijeme.DataPropertyName = "DatumVrijeme";
            this.DatumVrijeme.HeaderText = "Datum";
            this.DatumVrijeme.MinimumWidth = 6;
            this.DatumVrijeme.Name = "DatumVrijeme";
            this.DatumVrijeme.ReadOnly = true;
            // 
            // Pregledano
            // 
            this.Pregledano.HeaderText = "Pregledano";
            this.Pregledano.MinimumWidth = 6;
            this.Pregledano.Name = "Pregledano";
            this.Pregledano.ReadOnly = true;
            this.Pregledano.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPretrazi.Image = ((System.Drawing.Image)(resources.GetObject("btnPretrazi.Image")));
            this.btnPretrazi.Location = new System.Drawing.Point(1032, 121);
            this.btnPretrazi.Margin = new System.Windows.Forms.Padding(2);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(36, 31);
            this.btnPretrazi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPretrazi.TabIndex = 8;
            this.btnPretrazi.TabStop = false;
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPretrazi.Location = new System.Drawing.Point(871, 121);
            this.txtPretrazi.Margin = new System.Windows.Forms.Padding(2);
            this.txtPretrazi.Multiline = true;
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(157, 31);
            this.txtPretrazi.TabIndex = 7;
            this.txtPretrazi.Text = "Unesite pojam";
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            // 
            // btnDodajRezervaciju
            // 
            this.btnDodajRezervaciju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.btnDodajRezervaciju.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodajRezervaciju.FlatAppearance.BorderSize = 0;
            this.btnDodajRezervaciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajRezervaciju.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajRezervaciju.ForeColor = System.Drawing.Color.White;
            this.btnDodajRezervaciju.Image = ((System.Drawing.Image)(resources.GetObject("btnDodajRezervaciju.Image")));
            this.btnDodajRezervaciju.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodajRezervaciju.Location = new System.Drawing.Point(449, 91);
            this.btnDodajRezervaciju.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajRezervaciju.Name = "btnDodajRezervaciju";
            this.btnDodajRezervaciju.Size = new System.Drawing.Size(145, 47);
            this.btnDodajRezervaciju.TabIndex = 9;
            this.btnDodajRezervaciju.Text = "Rezervacija";
            this.btnDodajRezervaciju.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajRezervaciju.UseVisualStyleBackColor = false;
            this.btnDodajRezervaciju.Click += new System.EventHandler(this.btnDodajRezervaciju_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(53, 650);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(315, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "*Dvoklikom na red otvarate detalje o rezervaciji";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.BackColor = System.Drawing.Color.White;
            this.txtImePrezime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImePrezime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtImePrezime.Location = new System.Drawing.Point(120, 124);
            this.txtImePrezime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImePrezime.Multiline = true;
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.ReadOnly = true;
            this.txtImePrezime.Size = new System.Drawing.Size(263, 22);
            this.txtImePrezime.TabIndex = 57;
            this.txtImePrezime.Text = "Rezervacije koje još nisu izvršene";
            // 
            // Rezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.rezervacijeGrid);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDodajRezervaciju);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretrazi);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Rezervacije";
            this.Size = new System.Drawing.Size(1121, 716);
            this.Load += new System.EventHandler(this.Rezervacije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPretrazi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView rezervacijeGrid;
        private System.Windows.Forms.PictureBox btnPretrazi;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Button btnDodajRezervaciju;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVrijeme;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Pregledano;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtImePrezime;
    }
}
