namespace getFood_UI.Izvještaji
{
    partial class frmUpitDatum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpitDatum));
            this.DatumOd = new System.Windows.Forms.DateTimePicker();
            this.DatumDo = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnIzvještaj = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DatumOd
            // 
            this.DatumOd.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DatumOd.Location = new System.Drawing.Point(174, 94);
            this.DatumOd.Name = "DatumOd";
            this.DatumOd.Size = new System.Drawing.Size(314, 23);
            this.DatumOd.TabIndex = 0;
            // 
            // DatumDo
            // 
            this.DatumDo.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DatumDo.Location = new System.Drawing.Point(174, 150);
            this.DatumDo.Name = "DatumDo";
            this.DatumDo.Size = new System.Drawing.Size(314, 23);
            this.DatumDo.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 39);
            this.panel2.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(585, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(47, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(583, 27);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "Odaberite datume u okviru kojih želite da vidite količinu prodanih proizvoda";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(47, 94);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(92, 23);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "Datum od:";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(47, 152);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(92, 21);
            this.textBox3.TabIndex = 22;
            this.textBox3.Text = "Datum do:";
            // 
            // btnIzvještaj
            // 
            this.btnIzvještaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.btnIzvještaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzvještaj.FlatAppearance.BorderSize = 0;
            this.btnIzvještaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzvještaj.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzvještaj.ForeColor = System.Drawing.Color.White;
            this.btnIzvještaj.Location = new System.Drawing.Point(509, 202);
            this.btnIzvještaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIzvještaj.Name = "btnIzvještaj";
            this.btnIzvještaj.Size = new System.Drawing.Size(95, 36);
            this.btnIzvještaj.TabIndex = 48;
            this.btnIzvještaj.Text = "Prikaži";
            this.btnIzvještaj.UseVisualStyleBackColor = false;
            this.btnIzvještaj.Click += new System.EventHandler(this.btnIzvještaj_Click);
            // 
            // frmUpitDatum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 249);
            this.ControlBox = false;
            this.Controls.Add(this.btnIzvještaj);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DatumDo);
            this.Controls.Add(this.DatumOd);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmUpitDatum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DatumOd;
        private System.Windows.Forms.DateTimePicker DatumDo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnIzvještaj;
    }
}