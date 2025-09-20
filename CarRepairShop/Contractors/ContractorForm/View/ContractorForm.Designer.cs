namespace CarRepairShop.Contractors.ContractorForm.View
{
    partial class ContractorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractorForm));
            gbName = new System.Windows.Forms.GroupBox();
            txtName = new System.Windows.Forms.TextBox();
            gbSurname = new System.Windows.Forms.GroupBox();
            txtSurname = new System.Windows.Forms.TextBox();
            gmEmail = new System.Windows.Forms.GroupBox();
            txtEmail = new System.Windows.Forms.TextBox();
            gbPhoneNumber = new System.Windows.Forms.GroupBox();
            txtPhoneNumber = new System.Windows.Forms.TextBox();
            btnConfirm = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            gbName.SuspendLayout();
            gbSurname.SuspendLayout();
            gmEmail.SuspendLayout();
            gbPhoneNumber.SuspendLayout();
            SuspendLayout();
            // 
            // gbName
            // 
            gbName.Controls.Add(txtName);
            resources.ApplyResources(gbName, "gbName");
            gbName.ForeColor = System.Drawing.Color.SteelBlue;
            gbName.Name = "gbName";
            gbName.TabStop = false;
            // 
            // txtName
            // 
            resources.ApplyResources(txtName, "txtName");
            txtName.Name = "txtName";
            // 
            // gbSurname
            // 
            gbSurname.Controls.Add(txtSurname);
            resources.ApplyResources(gbSurname, "gbSurname");
            gbSurname.ForeColor = System.Drawing.Color.SteelBlue;
            gbSurname.Name = "gbSurname";
            gbSurname.TabStop = false;
            // 
            // txtSurname
            // 
            resources.ApplyResources(txtSurname, "txtSurname");
            txtSurname.Name = "txtSurname";
            // 
            // gmEmail
            // 
            gmEmail.Controls.Add(txtEmail);
            resources.ApplyResources(gmEmail, "gmEmail");
            gmEmail.ForeColor = System.Drawing.Color.SteelBlue;
            gmEmail.Name = "gmEmail";
            gmEmail.TabStop = false;
            // 
            // txtEmail
            // 
            resources.ApplyResources(txtEmail, "txtEmail");
            txtEmail.Name = "txtEmail";
            // 
            // gbPhoneNumber
            // 
            gbPhoneNumber.Controls.Add(txtPhoneNumber);
            resources.ApplyResources(gbPhoneNumber, "gbPhoneNumber");
            gbPhoneNumber.ForeColor = System.Drawing.Color.SteelBlue;
            gbPhoneNumber.Name = "gbPhoneNumber";
            gbPhoneNumber.TabStop = false;
            // 
            // txtPhoneNumber
            // 
            resources.ApplyResources(txtPhoneNumber, "txtPhoneNumber");
            txtPhoneNumber.Name = "txtPhoneNumber";
            // 
            // btnConfirm
            // 
            resources.ApplyResources(btnConfirm, "btnConfirm");
            btnConfirm.Name = "btnConfirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            resources.ApplyResources(btnCancel, "btnCancel");
            btnCancel.Name = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ContractorForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(gbPhoneNumber);
            Controls.Add(gmEmail);
            Controls.Add(gbSurname);
            Controls.Add(gbName);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ContractorForm";
            Load += ContractorForm_Load;
            gbName.ResumeLayout(false);
            gbName.PerformLayout();
            gbSurname.ResumeLayout(false);
            gbSurname.PerformLayout();
            gmEmail.ResumeLayout(false);
            gmEmail.PerformLayout();
            gbPhoneNumber.ResumeLayout(false);
            gbPhoneNumber.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox gbSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.GroupBox gmEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox gbPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}