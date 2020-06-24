namespace getFood_UI.Home
{
    partial class RadnaPloca
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(80, 220);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(530, 505);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(73, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Top proizvodi";
            // 
            // RadnaPloca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "RadnaPloca";
            this.Size = new System.Drawing.Size(1121, 725);
            this.Load += new System.EventHandler(this.RadnaPloca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label label1;
    }
}
