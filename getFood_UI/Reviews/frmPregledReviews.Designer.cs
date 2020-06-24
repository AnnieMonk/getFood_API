namespace getFood_UI.Restoran
{
    partial class frmPregledReviews
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledReviews));
            this.reviewsGrid = new System.Windows.Forms.DataGridView();
            this.ReviewId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Komentar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picEdit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.PictureBox();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.picPregled = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPretrazi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPregled)).BeginInit();
            this.SuspendLayout();
            // 
            // reviewsGrid
            // 
            this.reviewsGrid.AllowUserToAddRows = false;
            this.reviewsGrid.AllowUserToDeleteRows = false;
            this.reviewsGrid.AllowUserToOrderColumns = true;
            this.reviewsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reviewsGrid.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.reviewsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reviewsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.reviewsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reviewsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.reviewsGrid.ColumnHeadersHeight = 20;
            this.reviewsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReviewId,
            this.Ime,
            this.Komentar,
            this.Ocjena});
            this.reviewsGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reviewsGrid.EnableHeadersVisualStyles = false;
            this.reviewsGrid.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.reviewsGrid.Location = new System.Drawing.Point(11, 166);
            this.reviewsGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reviewsGrid.Name = "reviewsGrid";
            this.reviewsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reviewsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.reviewsGrid.RowHeadersVisible = false;
            this.reviewsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.reviewsGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.reviewsGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reviewsGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.reviewsGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.reviewsGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.reviewsGrid.RowTemplate.Height = 30;
            this.reviewsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reviewsGrid.Size = new System.Drawing.Size(639, 335);
            this.reviewsGrid.TabIndex = 3;
            this.reviewsGrid.TabStop = false;
            this.reviewsGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.reviewsGrid_MouseDoubleClick);
            // 
            // ReviewId
            // 
            this.ReviewId.DataPropertyName = "ReviewId";
            this.ReviewId.HeaderText = "ID";
            this.ReviewId.MinimumWidth = 6;
            this.ReviewId.Name = "ReviewId";
            this.ReviewId.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.MinimumWidth = 6;
            this.Ime.Name = "Ime";
            // 
            // Komentar
            // 
            this.Komentar.DataPropertyName = "Komentar";
            this.Komentar.HeaderText = "Komentar";
            this.Komentar.MinimumWidth = 6;
            this.Komentar.Name = "Komentar";
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.MinimumWidth = 6;
            this.Ocjena.Name = "Ocjena";
            // 
            // picEdit
            // 
            this.picEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.picEdit.Image = ((System.Drawing.Image)(resources.GetObject("picEdit.Image")));
            this.picEdit.Location = new System.Drawing.Point(41, 0);
            this.picEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picEdit.Name = "picEdit";
            this.picEdit.Size = new System.Drawing.Size(129, 114);
            this.picEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picEdit.TabIndex = 20;
            this.picEdit.TabStop = false;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 37);
            this.panel2.TabIndex = 19;
            // 
            // txtRating
            // 
            this.txtRating.BackColor = System.Drawing.Color.White;
            this.txtRating.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtRating.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.txtRating.Location = new System.Drawing.Point(93, 506);
            this.txtRating.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(45, 19);
            this.txtRating.TabIndex = 51;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(147, 505);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(24, 21);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 50;
            this.pictureBox7.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(11, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 49;
            this.label6.Text = "Rating";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPretrazi.Image = ((System.Drawing.Image)(resources.GetObject("btnPretrazi.Image")));
            this.btnPretrazi.Location = new System.Drawing.Point(607, 133);
            this.btnPretrazi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(40, 30);
            this.btnPretrazi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPretrazi.TabIndex = 53;
            this.btnPretrazi.TabStop = false;
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPretrazi.Location = new System.Drawing.Point(452, 133);
            this.txtPretrazi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPretrazi.Multiline = true;
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(148, 29);
            this.txtPretrazi.TabIndex = 52;
            this.txtPretrazi.Text = "Unesite pojam";
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            // 
            // picPregled
            // 
            this.picPregled.Image = ((System.Drawing.Image)(resources.GetObject("picPregled.Image")));
            this.picPregled.Location = new System.Drawing.Point(411, 41);
            this.picPregled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPregled.Name = "picPregled";
            this.picPregled.Size = new System.Drawing.Size(176, 59);
            this.picPregled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPregled.TabIndex = 54;
            this.picPregled.TabStop = false;
            // 
            // frmPregledReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 582);
            this.ControlBox = false;
            this.Controls.Add(this.picPregled);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picEdit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.reviewsGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPregledReviews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPregledReviews_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reviewsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPretrazi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPregled)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reviewsGrid;
        private System.Windows.Forms.PictureBox picEdit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Komentar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox btnPretrazi;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.PictureBox picPregled;
    }
}