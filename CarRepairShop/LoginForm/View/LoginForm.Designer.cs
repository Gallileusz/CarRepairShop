namespace CarRepairShop.LoginForm.View
{
    partial class LoginForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblQuit = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbCacheLogin = new System.Windows.Forms.CheckBox();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.Location = new System.Drawing.Point(130, 199);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(106, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LOG IN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Location = new System.Drawing.Point(87, 359);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 39);
            this.panel2.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(-13, -8);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(228, 53);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LOG IN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblQuit
            // 
            this.lblQuit.AutoSize = true;
            this.lblQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQuit.ForeColor = System.Drawing.Color.Red;
            this.lblQuit.Location = new System.Drawing.Point(168, 407);
            this.lblQuit.Name = "lblQuit";
            this.lblQuit.Size = new System.Drawing.Size(35, 18);
            this.lblQuit.TabIndex = 4;
            this.lblQuit.Text = "Quit";
            this.lblQuit.Click += new System.EventHandler(this.lblQuit_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLogin.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtLogin.Location = new System.Drawing.Point(72, 251);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(236, 24);
            this.txtLogin.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPassword.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtPassword.Location = new System.Drawing.Point(72, 301);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(236, 24);
            this.txtPassword.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Location = new System.Drawing.Point(35, 331);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 2);
            this.panel4.TabIndex = 8;
            // 
            // cbCacheLogin
            // 
            this.cbCacheLogin.AutoSize = true;
            this.cbCacheLogin.BackColor = System.Drawing.Color.White;
            this.cbCacheLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCacheLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbCacheLogin.Location = new System.Drawing.Point(314, 259);
            this.cbCacheLogin.Margin = new System.Windows.Forms.Padding(0);
            this.cbCacheLogin.Name = "cbCacheLogin";
            this.cbCacheLogin.Size = new System.Drawing.Size(15, 14);
            this.cbCacheLogin.TabIndex = 9;
            this.cbCacheLogin.UseVisualStyleBackColor = false;
            // 
            // pbPassword
            // 
            this.pbPassword.Image = global::CarRepairShop.Properties.Resources.key;
            this.pbPassword.Location = new System.Drawing.Point(35, 300);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(30, 30);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPassword.TabIndex = 2;
            this.pbPassword.TabStop = false;
            // 
            // pbLogin
            // 
            this.pbLogin.Image = global::CarRepairShop.Properties.Resources.users;
            this.pbLogin.Location = new System.Drawing.Point(35, 249);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(30, 30);
            this.pbLogin.TabIndex = 1;
            this.pbLogin.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BackgroundImage = global::CarRepairShop.Properties.Resources.mechanicGif;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 194);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Location = new System.Drawing.Point(35, 281);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 2);
            this.panel3.TabIndex = 10;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(366, 440);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cbCacheLogin);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblQuit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pbPassword);
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginForm_KeyPress);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblQuit;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox cbCacheLogin;
        private System.Windows.Forms.Panel panel3;
    }
}