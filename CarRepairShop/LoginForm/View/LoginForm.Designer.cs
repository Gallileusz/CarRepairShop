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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblTitle = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            btnLogin = new System.Windows.Forms.Button();
            pbConnectionError = new System.Windows.Forms.PictureBox();
            txtLogin = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            panel4 = new System.Windows.Forms.Panel();
            cbCacheLogin = new System.Windows.Forms.CheckBox();
            pbPassword = new System.Windows.Forms.PictureBox();
            pbLogin = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            panel6 = new System.Windows.Forms.Panel();
            btnQuit = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            lblError = new System.Windows.Forms.Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbConnectionError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogin).BeginInit();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            resources.ApplyResources(lblTitle, "lblTitle");
            lblTitle.ForeColor = System.Drawing.Color.SteelBlue;
            lblTitle.Name = "lblTitle";
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.Controls.Add(btnLogin);
            panel2.Name = "panel2";
            // 
            // btnLogin
            // 
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.BackColor = System.Drawing.Color.SteelBlue;
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.Name = "btnLogin";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pbConnectionError
            // 
            resources.ApplyResources(pbConnectionError, "pbConnectionError");
            pbConnectionError.BackColor = System.Drawing.Color.White;
            pbConnectionError.Image = Properties.Resources.warning;
            pbConnectionError.Name = "pbConnectionError";
            pbConnectionError.TabStop = false;
            pbConnectionError.Click += pbConnectionError_Click;
            // 
            // txtLogin
            // 
            resources.ApplyResources(txtLogin, "txtLogin");
            txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtLogin.ForeColor = System.Drawing.Color.SteelBlue;
            txtLogin.Name = "txtLogin";
            // 
            // txtPassword
            // 
            resources.ApplyResources(txtPassword, "txtPassword");
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtPassword.ForeColor = System.Drawing.Color.SteelBlue;
            txtPassword.Name = "txtPassword";
            // 
            // panel4
            // 
            resources.ApplyResources(panel4, "panel4");
            panel4.BackColor = System.Drawing.Color.SteelBlue;
            panel4.Name = "panel4";
            // 
            // cbCacheLogin
            // 
            resources.ApplyResources(cbCacheLogin, "cbCacheLogin");
            cbCacheLogin.BackColor = System.Drawing.Color.White;
            cbCacheLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            cbCacheLogin.Name = "cbCacheLogin";
            cbCacheLogin.UseVisualStyleBackColor = false;
            // 
            // pbPassword
            // 
            resources.ApplyResources(pbPassword, "pbPassword");
            pbPassword.Image = Properties.Resources.key;
            pbPassword.Name = "pbPassword";
            pbPassword.TabStop = false;
            // 
            // pbLogin
            // 
            resources.ApplyResources(pbLogin, "pbLogin");
            pbLogin.Image = Properties.Resources.users;
            pbLogin.Name = "pbLogin";
            pbLogin.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = System.Drawing.Color.SteelBlue;
            panel1.BackgroundImage = Properties.Resources.mechanicGif;
            panel1.Controls.Add(panel6);
            panel1.ForeColor = System.Drawing.Color.White;
            panel1.Name = "panel1";
            // 
            // panel6
            // 
            resources.ApplyResources(panel6, "panel6");
            panel6.Controls.Add(btnQuit);
            panel6.Name = "panel6";
            // 
            // btnQuit
            // 
            resources.ApplyResources(btnQuit, "btnQuit");
            btnQuit.BackColor = System.Drawing.Color.White;
            btnQuit.ForeColor = System.Drawing.Color.SteelBlue;
            btnQuit.Name = "btnQuit";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += btnQuit_Click;
            // 
            // panel3
            // 
            resources.ApplyResources(panel3, "panel3");
            panel3.BackColor = System.Drawing.Color.SteelBlue;
            panel3.Name = "panel3";
            // 
            // lblError
            // 
            resources.ApplyResources(lblError, "lblError");
            lblError.BackColor = System.Drawing.Color.White;
            lblError.ForeColor = System.Drawing.Color.Crimson;
            lblError.Name = "lblError";
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(lblError);
            Controls.Add(panel3);
            Controls.Add(pbConnectionError);
            Controls.Add(cbCacheLogin);
            Controls.Add(panel4);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(panel2);
            Controls.Add(pbPassword);
            Controls.Add(pbLogin);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            KeyPreview = true;
            Name = "LoginForm";
            Load += LoginForm_Load;
            KeyPress += LoginForm_KeyPress;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbConnectionError).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogin).EndInit();
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox cbCacheLogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.PictureBox pbConnectionError;
        private System.Windows.Forms.Label lblError;
    }
}