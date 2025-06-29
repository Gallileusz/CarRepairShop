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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.gbPhoneNumber = new System.Windows.Forms.GroupBox();
            this.txtWarrantyTime = new System.Windows.Forms.TextBox();
            this.gmEmail = new System.Windows.Forms.GroupBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.gbSurname = new System.Windows.Forms.GroupBox();
            this.txtTimeNeeded = new System.Windows.Forms.TextBox();
            this.gbName = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gbPhoneNumber.SuspendLayout();
            this.gmEmail.SuspendLayout();
            this.gbSurname.SuspendLayout();
            this.gbName.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            resources.ApplyResources(this.btnConfirm, "btnConfirm");
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // gbPhoneNumber
            // 
            this.gbPhoneNumber.Controls.Add(this.txtWarrantyTime);
            resources.ApplyResources(this.gbPhoneNumber, "gbPhoneNumber");
            this.gbPhoneNumber.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbPhoneNumber.Name = "gbPhoneNumber";
            this.gbPhoneNumber.TabStop = false;
            // 
            // txtWarrantyTime
            // 
            resources.ApplyResources(this.txtWarrantyTime, "txtWarrantyTime");
            this.txtWarrantyTime.Name = "txtWarrantyTime";
            // 
            // gmEmail
            // 
            this.gmEmail.Controls.Add(this.txtCost);
            resources.ApplyResources(this.gmEmail, "gmEmail");
            this.gmEmail.ForeColor = System.Drawing.Color.SteelBlue;
            this.gmEmail.Name = "gmEmail";
            this.gmEmail.TabStop = false;
            // 
            // txtCost
            // 
            resources.ApplyResources(this.txtCost, "txtCost");
            this.txtCost.Name = "txtCost";
            // 
            // gbSurname
            // 
            this.gbSurname.Controls.Add(this.txtTimeNeeded);
            resources.ApplyResources(this.gbSurname, "gbSurname");
            this.gbSurname.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbSurname.Name = "gbSurname";
            this.gbSurname.TabStop = false;
            // 
            // txtTimeNeeded
            // 
            resources.ApplyResources(this.txtTimeNeeded, "txtTimeNeeded");
            this.txtTimeNeeded.Name = "txtTimeNeeded";
            // 
            // gbName
            // 
            this.gbName.Controls.Add(this.txtName);
            resources.ApplyResources(this.gbName, "gbName");
            this.gbName.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbName.Name = "gbName";
            this.gbName.TabStop = false;
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // SerivcesForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gbPhoneNumber);
            this.Controls.Add(this.gmEmail);
            this.Controls.Add(this.gbSurname);
            this.Controls.Add(this.gbName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SerivcesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SerivcesForm_FormClosing);
            this.Load += new System.EventHandler(this.SerivcesForm_Load);
            this.gbPhoneNumber.ResumeLayout(false);
            this.gbPhoneNumber.PerformLayout();
            this.gmEmail.ResumeLayout(false);
            this.gmEmail.PerformLayout();
            this.gbSurname.ResumeLayout(false);
            this.gbSurname.PerformLayout();
            this.gbName.ResumeLayout(false);
            this.gbName.PerformLayout();
            this.ResumeLayout(false);

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
    }
}