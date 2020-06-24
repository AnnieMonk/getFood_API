namespace getFood_UI
{
    partial class ListItem
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
            this.slikaHrane = new System.Windows.Forms.PictureBox();
            this.txtNaziv = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.slikaHrane)).BeginInit();
            this.SuspendLayout();
            // 
            // slikaHrane
            // 
            this.slikaHrane.Location = new System.Drawing.Point(0, 0);
            this.slikaHrane.Name = "slikaHrane";
            this.slikaHrane.Size = new System.Drawing.Size(174, 123);
            this.slikaHrane.TabIndex = 0;
            this.slikaHrane.TabStop = false;
            // 
            // txtNaziv
            // 
            this.txtNaziv.AutoSize = true;
            this.txtNaziv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNaziv.Location = new System.Drawing.Point(197, 44);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(70, 23);
            this.txtNaziv.TabIndex = 3;
            this.txtNaziv.Text = "label1";
            // 
            // txtCijena
            // 
            this.txtCijena.AutoSize = true;
            this.txtCijena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCijena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.txtCijena.Location = new System.Drawing.Point(197, 89);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(70, 23);
            this.txtCijena.TabIndex = 4;
            this.txtCijena.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(273, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "KM";
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.slikaHrane);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(412, 123);
            ((System.ComponentModel.ISupportInitialize)(this.slikaHrane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox slikaHrane;
        private System.Windows.Forms.Label txtNaziv;
        private System.Windows.Forms.Label txtCijena;
        private System.Windows.Forms.Label label1;
    }
}
