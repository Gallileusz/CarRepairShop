namespace CarRepairShop.Services.View
{
    partial class SerivcesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerivcesForm));
            btnCancel = new System.Windows.Forms.Button();
            btnConfirm = new System.Windows.Forms.Button();
            gbPhoneNumber = new System.Windows.Forms.GroupBox();
            txtWarrantyTime = new System.Windows.Forms.TextBox();
            gmEmail = new System.Windows.Forms.GroupBox();
            txtCost = new System.Windows.Forms.TextBox();
            gbSurname = new System.Windows.Forms.GroupBox();
            txtTimeNeeded = new System.Windows.Forms.TextBox();
            gbName = new System.Windows.Forms.GroupBox();
            txtName = new System.Windows.Forms.TextBox();
            gbStatus = new System.Windows.Forms.GroupBox();
            cbActive = new System.Windows.Forms.CheckBox();
            gbPhoneNumber.SuspendLayout();
            gmEmail.SuspendLayout();
            gbSurname.SuspendLayout();
            gbName.SuspendLayout();
            gbStatus.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            resources.ApplyResources(btnCancel, "btnCancel");
            btnCancel.Name = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            resources.ApplyResources(btnConfirm, "btnConfirm");
            btnConfirm.Name = "btnConfirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // gbPhoneNumber
            // 
            gbPhoneNumber.Controls.Add(txtWarrantyTime);
            resources.ApplyResources(gbPhoneNumber, "gbPhoneNumber");
            gbPhoneNumber.ForeColor = System.Drawing.Color.SteelBlue;
            gbPhoneNumber.Name = "gbPhoneNumber";
            gbPhoneNumber.TabStop = false;
            // 
            // txtWarrantyTime
            // 
            resources.ApplyResources(txtWarrantyTime, "txtWarrantyTime");
            txtWarrantyTime.Name = "txtWarrantyTime";
            // 
            // gmEmail
            // 
            gmEmail.Controls.Add(txtCost);
            resources.ApplyResources(gmEmail, "gmEmail");
            gmEmail.ForeColor = System.Drawing.Color.SteelBlue;
            gmEmail.Name = "gmEmail";
            gmEmail.TabStop = false;
            // 
            // txtCost
            // 
            resources.ApplyResources(txtCost, "txtCost");
            txtCost.Name = "txtCost";
            // 
            // gbSurname
            // 
            gbSurname.Controls.Add(txtTimeNeeded);
            resources.ApplyResources(gbSurname, "gbSurname");
            gbSurname.ForeColor = System.Drawing.Color.SteelBlue;
            gbSurname.Name = "gbSurname";
            gbSurname.TabStop = false;
            // 
            // txtTimeNeeded
            // 
            resources.ApplyResources(txtTimeNeeded, "txtTimeNeeded");
            txtTimeNeeded.Name = "txtTimeNeeded";
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
            // gbStatus
            // 
            gbStatus.Controls.Add(cbActive);
            resources.ApplyResources(gbStatus, "gbStatus");
            gbStatus.ForeColor = System.Drawing.Color.SteelBlue;
            gbStatus.Name = "gbStatus";
            gbStatus.TabStop = false;
            // 
            // cbActive
            // 
            resources.ApplyResources(cbActive, "cbActive");
            cbActive.Name = "cbActive";
            cbActive.UseVisualStyleBackColor = true;
            // 
            // SerivcesForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gbStatus);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(gbPhoneNumber);
            Controls.Add(gmEmail);
            Controls.Add(gbSurname);
            Controls.Add(gbName);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SerivcesForm";
            FormClosing += SerivcesForm_FormClosing;
            Load += SerivcesForm_Load;
            gbPhoneNumber.ResumeLayout(false);
            gbPhoneNumber.PerformLayout();
            gmEmail.ResumeLayout(false);
            gmEmail.PerformLayout();
            gbSurname.ResumeLayout(false);
            gbSurname.PerformLayout();
            gbName.ResumeLayout(false);
            gbName.PerformLayout();
            gbStatus.ResumeLayout(false);
            gbStatus.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox gbPhoneNumber;
        private System.Windows.Forms.TextBox txtWarrantyTime;
        private System.Windows.Forms.GroupBox gmEmail;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.GroupBox gbSurname;
        private System.Windows.Forms.TextBox txtTimeNeeded;
        private System.Windows.Forms.GroupBox gbName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.CheckBox cbActive;
    }
}