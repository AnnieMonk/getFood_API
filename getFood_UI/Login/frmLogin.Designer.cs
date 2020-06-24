namespace getFood_UI.Login
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-71, -38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 612);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUsername.Location = new System.Drawing.Point(486, 195);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(243, 37);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Text = "Username";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.Location = new System.Drawing.Point(486, 287);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(243, 37);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "Password";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Location = new System.Drawing.Point(556, 382);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(88, 38);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseApp.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseApp.Image")));
            this.btnCloseApp.Location = new System.Drawing.Point(730, 12);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(18, 19);
            this.btnCloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCloseApp.TabIndex = 12;
            this.btnCloseApp.TabStop = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(513, 95);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(159, 69);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(486, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 3);
            this.panel2.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(486, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 3);
            this.panel1.TabIndex = 39;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(775, 481);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox btnCloseApp;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}