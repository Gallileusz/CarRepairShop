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
            this.gbName = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gbSurname = new System.Windows.Forms.GroupBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.gmEmail = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.gbPhoneNumber = new System.Windows.Forms.GroupBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbName.SuspendLayout();
            this.gbSurname.SuspendLayout();
            this.gmEmail.SuspendLayout();
            this.gbPhoneNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbName
            // 
            this.gbName.Controls.Add(this.txtName);
            this.gbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbName.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbName.Location = new System.Drawing.Point(12, 12);
            this.gbName.Name = "gbName";
            this.gbName.Size = new System.Drawing.Size(249, 58);
            this.gbName.TabIndex = 17;
            this.gbName.TabStop = false;
            this.gbName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 24);
            this.txtName.TabIndex = 0;
            // 
            // gbSurname
            // 
            this.gbSurname.Controls.Add(this.txtSurname);
            this.gbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbSurname.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbSurname.Location = new System.Drawing.Point(276, 12);
            this.gbSurname.Name = "gbSurname";
            this.gbSurname.Size = new System.Drawing.Size(249, 58);
            this.gbSurname.TabIndex = 18;
            this.gbSurname.TabStop = false;
            this.gbSurname.Text = "Surname:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(6, 23);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(237, 24);
            this.txtSurname.TabIndex = 0;
            // 
            // gmEmail
            // 
            this.gmEmail.Controls.Add(this.txtEmail);
            this.gmEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gmEmail.ForeColor = System.Drawing.Color.SteelBlue;
            this.gmEmail.Location = new System.Drawing.Point(12, 90);
            this.gmEmail.Name = "gmEmail";
            this.gmEmail.Size = new System.Drawing.Size(249, 58);
            this.gmEmail.TabIndex = 19;
            this.gmEmail.TabStop = false;
            this.gmEmail.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 23);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(237, 24);
            this.txtEmail.TabIndex = 0;
            // 
            // gbPhoneNumber
            // 
            this.gbPhoneNumber.Controls.Add(this.txtPhoneNumber);
            this.gbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPhoneNumber.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbPhoneNumber.Location = new System.Drawing.Point(276, 90);
            this.gbPhoneNumber.Name = "gbPhoneNumber";
            this.gbPhoneNumber.Size = new System.Drawing.Size(249, 58);
            this.gbPhoneNumber.TabIndex = 20;
            this.gbPhoneNumber.TabStop = false;
            this.gbPhoneNumber.Text = "Phone number:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(6, 23);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(237, 24);
            this.txtPhoneNumber.TabIndex = 0;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(151, 158);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(104, 40);
            this.btnConfirm.TabIndex = 21;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(282, 158);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 40);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ContractorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 211);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gbPhoneNumber);
            this.Controls.Add(this.gmEmail);
            this.Controls.Add(this.gbSurname);
            this.Controls.Add(this.gbName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContractorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContractorForm_FormClosing);
            this.Load += new System.EventHandler(this.ContractorForm_Load);
            this.gbName.ResumeLayout(false);
            this.gbName.PerformLayout();
            this.gbSurname.ResumeLayout(false);
            this.gbSurname.PerformLayout();
            this.gmEmail.ResumeLayout(false);
            this.gmEmail.PerformLayout();
            this.gbPhoneNumber.ResumeLayout(false);
            this.gbPhoneNumber.PerformLayout();
            this.ResumeLayout(false);

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