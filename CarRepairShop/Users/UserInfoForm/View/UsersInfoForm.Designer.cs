namespace CarRepairShop.Users.UserInfoForm.View
{
    partial class UsersInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersInfoForm));
            txtName = new System.Windows.Forms.TextBox();
            txtSurname = new System.Windows.Forms.TextBox();
            btnCancel = new System.Windows.Forms.Button();
            btnAccept = new System.Windows.Forms.Button();
            gbName = new System.Windows.Forms.GroupBox();
            gbSurname = new System.Windows.Forms.GroupBox();
            gbLogin = new System.Windows.Forms.GroupBox();
            txtLogin = new System.Windows.Forms.TextBox();
            gbPassword = new System.Windows.Forms.GroupBox();
            btnShowPassword = new System.Windows.Forms.Button();
            txtPassword = new System.Windows.Forms.TextBox();
            gbSuperAdmin = new System.Windows.Forms.GroupBox();
            cbSuperAdmin = new System.Windows.Forms.CheckBox();
            gbName.SuspendLayout();
            gbSurname.SuspendLayout();
            gbLogin.SuspendLayout();
            gbPassword.SuspendLayout();
            gbSuperAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            resources.ApplyResources(txtName, "txtName");
            txtName.Name = "txtName";
            // 
            // txtSurname
            // 
            resources.ApplyResources(txtSurname, "txtSurname");
            txtSurname.Name = "txtSurname";
            // 
            // btnCancel
            // 
            resources.ApplyResources(btnCancel, "btnCancel");
            btnCancel.Name = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAccept
            // 
            resources.ApplyResources(btnAccept, "btnAccept");
            btnAccept.Name = "btnAccept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // gbName
            // 
            gbName.Controls.Add(txtName);
            resources.ApplyResources(gbName, "gbName");
            gbName.ForeColor = System.Drawing.Color.SteelBlue;
            gbName.Name = "gbName";
            gbName.TabStop = false;
            // 
            // gbSurname
            // 
            gbSurname.Controls.Add(txtSurname);
            resources.ApplyResources(gbSurname, "gbSurname");
            gbSurname.ForeColor = System.Drawing.Color.SteelBlue;
            gbSurname.Name = "gbSurname";
            gbSurname.TabStop = false;
            // 
            // gbLogin
            // 
            gbLogin.Controls.Add(txtLogin);
            resources.ApplyResources(gbLogin, "gbLogin");
            gbLogin.ForeColor = System.Drawing.Color.SteelBlue;
            gbLogin.Name = "gbLogin";
            gbLogin.TabStop = false;
            // 
            // txtLogin
            // 
            resources.ApplyResources(txtLogin, "txtLogin");
            txtLogin.Name = "txtLogin";
            // 
            // gbPassword
            // 
            gbPassword.Controls.Add(btnShowPassword);
            gbPassword.Controls.Add(txtPassword);
            resources.ApplyResources(gbPassword, "gbPassword");
            gbPassword.ForeColor = System.Drawing.Color.SteelBlue;
            gbPassword.Name = "gbPassword";
            gbPassword.TabStop = false;
            // 
            // btnShowPassword
            // 
            btnShowPassword.Image = Properties.Resources.show;
            resources.ApplyResources(btnShowPassword, "btnShowPassword");
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.UseVisualStyleBackColor = true;
            btnShowPassword.MouseDown += btnShowPassword_MouseDown;
            btnShowPassword.MouseUp += btnShowPassword_MouseUp;
            // 
            // txtPassword
            // 
            resources.ApplyResources(txtPassword, "txtPassword");
            txtPassword.Name = "txtPassword";
            // 
            // gbSuperAdmin
            // 
            gbSuperAdmin.Controls.Add(cbSuperAdmin);
            resources.ApplyResources(gbSuperAdmin, "gbSuperAdmin");
            gbSuperAdmin.ForeColor = System.Drawing.Color.SteelBlue;
            gbSuperAdmin.Name = "gbSuperAdmin";
            gbSuperAdmin.TabStop = false;
            // 
            // cbSuperAdmin
            // 
            resources.ApplyResources(cbSuperAdmin, "cbSuperAdmin");
            cbSuperAdmin.Name = "cbSuperAdmin";
            cbSuperAdmin.UseVisualStyleBackColor = true;
            // 
            // UsersInfoForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gbSuperAdmin);
            Controls.Add(gbPassword);
            Controls.Add(gbLogin);
            Controls.Add(gbSurname);
            Controls.Add(gbName);
            Controls.Add(btnAccept);
            Controls.Add(btnCancel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UsersInfoForm";
            FormClosing += UsersInfoForm_FormClosing;
            Load += UsersInfoForm_Load;
            gbName.ResumeLayout(false);
            gbName.PerformLayout();
            gbSurname.ResumeLayout(false);
            gbSurname.PerformLayout();
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            gbPassword.ResumeLayout(false);
            gbPassword.PerformLayout();
            gbSuperAdmin.ResumeLayout(false);
            gbSuperAdmin.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.GroupBox gbName;
        private System.Windows.Forms.GroupBox gbSurname;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.GroupBox gbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.GroupBox gbSuperAdmin;
        private System.Windows.Forms.CheckBox cbSuperAdmin;
    }
}