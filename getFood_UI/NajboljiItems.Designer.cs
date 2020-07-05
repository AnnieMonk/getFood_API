namespace getFood_UI
{
    partial class NajboljiItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NajboljiItems));
            this.slikaHrane = new System.Windows.Forms.PictureBox();
            this.txtNaziv = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.Label();
            this.txtRating = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.slikaHrane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // slikaHrane
            // 
            this.slikaHrane.Location = new System.Drawing.Point(0, 0);
            this.slikaHrane.Name = "slikaHrane";
            this.slikaHrane.Size = new System.Drawing.Size(174, 158);
            this.slikaHrane.TabIndex = 0;
            this.slikaHrane.TabStop = false;
            // 
            // txtNaziv
            // 
            this.txtNaziv.AutoSize = true;
            this.txtNaziv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNaziv.Location = new System.Drawing.Point(188, 14);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(63, 23);
            this.txtNaziv.TabIndex = 3;
            this.txtNaziv.Text = "Naziv";
            // 
            // txtOpis
            // 
            this.txtOpis.AutoSize = true;
            this.txtOpis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOpis.Location = new System.Drawing.Point(188, 49);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(54, 23);
            this.txtOpis.TabIndex = 6;
            this.txtOpis.Text = "Opis";
            // 
            // txtRating
            // 
            this.txtRating.AutoSize = true;
            this.txtRating.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRating.Location = new System.Drawing.Point(180, 126);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(71, 23);
            this.txtRating.TabIndex = 7;
            this.txtRating.Text = "Rating";
            this.txtRating.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(257, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 25);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // NajboljiItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.slikaHrane);
            this.Name = "NajboljiItems";
            this.Size = new System.Drawing.Size(349, 161);
            ((System.ComponentModel.ISupportInitialize)(this.slikaHrane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox slikaHrane;
        private System.Windows.Forms.Label txtNaziv;
        private System.Windows.Forms.Label txtOpis;
        private System.Windows.Forms.Label txtRating;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
