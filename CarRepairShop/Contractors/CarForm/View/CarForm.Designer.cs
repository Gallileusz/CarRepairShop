namespace CarRepairShop.Contractors.CarForm.View
{
    partial class CarForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.gbLicensePlate = new System.Windows.Forms.GroupBox();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.gbVIN = new System.Windows.Forms.GroupBox();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.gbModelName = new System.Windows.Forms.GroupBox();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.gbBrandName = new System.Windows.Forms.GroupBox();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.gbYear = new System.Windows.Forms.GroupBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.gbEngineCapacity = new System.Windows.Forms.GroupBox();
            this.txtEngineCapacity = new System.Windows.Forms.TextBox();
            this.btnAddFuelType = new System.Windows.Forms.Button();
            this.cmbFuelTypes = new System.Windows.Forms.ComboBox();
            this.gbFuelType = new System.Windows.Forms.GroupBox();
            this.gbMileage = new System.Windows.Forms.GroupBox();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.gbLicensePlate.SuspendLayout();
            this.gbVIN.SuspendLayout();
            this.gbModelName.SuspendLayout();
            this.gbBrandName.SuspendLayout();
            this.gbYear.SuspendLayout();
            this.gbEngineCapacity.SuspendLayout();
            this.gbFuelType.SuspendLayout();
            this.gbMileage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(528, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 40);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(412, 150);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(104, 40);
            this.btnConfirm.TabIndex = 27;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // gbLicensePlate
            // 
            this.gbLicensePlate.Controls.Add(this.txtLicensePlate);
            this.gbLicensePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbLicensePlate.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbLicensePlate.Location = new System.Drawing.Point(777, 76);
            this.gbLicensePlate.Name = "gbLicensePlate";
            this.gbLicensePlate.Size = new System.Drawing.Size(249, 58);
            this.gbLicensePlate.TabIndex = 26;
            this.gbLicensePlate.TabStop = false;
            this.gbLicensePlate.Text = "License plate:";
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(6, 23);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(237, 24);
            this.txtLicensePlate.TabIndex = 0;
            // 
            // gbVIN
            // 
            this.gbVIN.Controls.Add(this.txtVIN);
            this.gbVIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbVIN.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbVIN.Location = new System.Drawing.Point(777, 12);
            this.gbVIN.Name = "gbVIN";
            this.gbVIN.Size = new System.Drawing.Size(249, 58);
            this.gbVIN.TabIndex = 25;
            this.gbVIN.TabStop = false;
            this.gbVIN.Text = "VIN:";
            // 
            // txtVIN
            // 
            this.txtVIN.Location = new System.Drawing.Point(6, 23);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(237, 24);
            this.txtVIN.TabIndex = 0;
            // 
            // gbModelName
            // 
            this.gbModelName.Controls.Add(this.txtModelName);
            this.gbModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbModelName.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbModelName.Location = new System.Drawing.Point(267, 12);
            this.gbModelName.Name = "gbModelName";
            this.gbModelName.Size = new System.Drawing.Size(249, 58);
            this.gbModelName.TabIndex = 24;
            this.gbModelName.TabStop = false;
            this.gbModelName.Text = "Model name:";
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(6, 23);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(237, 24);
            this.txtModelName.TabIndex = 0;
            // 
            // gbBrandName
            // 
            this.gbBrandName.Controls.Add(this.txtBrandName);
            this.gbBrandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbBrandName.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbBrandName.Location = new System.Drawing.Point(12, 12);
            this.gbBrandName.Name = "gbBrandName";
            this.gbBrandName.Size = new System.Drawing.Size(249, 58);
            this.gbBrandName.TabIndex = 23;
            this.gbBrandName.TabStop = false;
            this.gbBrandName.Text = "Brand name:";
            // 
            // txtBrandName
            // 
            this.txtBrandName.Location = new System.Drawing.Point(6, 23);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(237, 24);
            this.txtBrandName.TabIndex = 0;
            // 
            // gbYear
            // 
            this.gbYear.Controls.Add(this.txtYear);
            this.gbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbYear.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbYear.Location = new System.Drawing.Point(522, 12);
            this.gbYear.Name = "gbYear";
            this.gbYear.Size = new System.Drawing.Size(249, 58);
            this.gbYear.TabIndex = 29;
            this.gbYear.TabStop = false;
            this.gbYear.Text = "Year:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(6, 23);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(237, 24);
            this.txtYear.TabIndex = 0;
            // 
            // gbEngineCapacity
            // 
            this.gbEngineCapacity.Controls.Add(this.txtEngineCapacity);
            this.gbEngineCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbEngineCapacity.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbEngineCapacity.Location = new System.Drawing.Point(267, 76);
            this.gbEngineCapacity.Name = "gbEngineCapacity";
            this.gbEngineCapacity.Size = new System.Drawing.Size(249, 58);
            this.gbEngineCapacity.TabIndex = 31;
            this.gbEngineCapacity.TabStop = false;
            this.gbEngineCapacity.Text = "Engine capacity:";
            // 
            // txtEngineCapacity
            // 
            this.txtEngineCapacity.Location = new System.Drawing.Point(6, 23);
            this.txtEngineCapacity.Name = "txtEngineCapacity";
            this.txtEngineCapacity.Size = new System.Drawing.Size(237, 24);
            this.txtEngineCapacity.TabIndex = 0;
            // 
            // btnAddFuelType
            // 
            this.btnAddFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddFuelType.Location = new System.Drawing.Point(164, 15);
            this.btnAddFuelType.Name = "btnAddFuelType";
            this.btnAddFuelType.Size = new System.Drawing.Size(80, 38);
            this.btnAddFuelType.TabIndex = 1;
            this.btnAddFuelType.Text = "Add new fuel type";
            this.btnAddFuelType.UseVisualStyleBackColor = true;
            this.btnAddFuelType.Click += new System.EventHandler(this.btnAddFuelType_Click);
            // 
            // cmbFuelTypes
            // 
            this.cmbFuelTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbFuelTypes.FormattingEnabled = true;
            this.cmbFuelTypes.Location = new System.Drawing.Point(6, 21);
            this.cmbFuelTypes.Name = "cmbFuelTypes";
            this.cmbFuelTypes.Size = new System.Drawing.Size(152, 26);
            this.cmbFuelTypes.TabIndex = 0;
            // 
            // gbFuelType
            // 
            this.gbFuelType.Controls.Add(this.btnAddFuelType);
            this.gbFuelType.Controls.Add(this.cmbFuelTypes);
            this.gbFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbFuelType.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbFuelType.Location = new System.Drawing.Point(12, 76);
            this.gbFuelType.Name = "gbFuelType";
            this.gbFuelType.Size = new System.Drawing.Size(249, 58);
            this.gbFuelType.TabIndex = 32;
            this.gbFuelType.TabStop = false;
            this.gbFuelType.Text = "Fuel type:";
            // 
            // gbMileage
            // 
            this.gbMileage.Controls.Add(this.txtMileage);
            this.gbMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbMileage.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbMileage.Location = new System.Drawing.Point(522, 76);
            this.gbMileage.Name = "gbMileage";
            this.gbMileage.Size = new System.Drawing.Size(249, 58);
            this.gbMileage.TabIndex = 33;
            this.gbMileage.TabStop = false;
            this.gbMileage.Text = "Mileage:";
            // 
            // txtMileage
            // 
            this.txtMileage.Location = new System.Drawing.Point(6, 23);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(237, 24);
            this.txtMileage.TabIndex = 0;
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 199);
            this.Controls.Add(this.gbMileage);
            this.Controls.Add(this.gbFuelType);
            this.Controls.Add(this.gbEngineCapacity);
            this.Controls.Add(this.gbYear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gbLicensePlate);
            this.Controls.Add(this.gbVIN);
            this.Controls.Add(this.gbModelName);
            this.Controls.Add(this.gbBrandName);
            this.Name = "CarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CarForm_FormClosing);
            this.Load += new System.EventHandler(this.CarForm_Load);
            this.gbLicensePlate.ResumeLayout(false);
            this.gbLicensePlate.PerformLayout();
            this.gbVIN.ResumeLayout(false);
            this.gbVIN.PerformLayout();
            this.gbModelName.ResumeLayout(false);
            this.gbModelName.PerformLayout();
            this.gbBrandName.ResumeLayout(false);
            this.gbBrandName.PerformLayout();
            this.gbYear.ResumeLayout(false);
            this.gbYear.PerformLayout();
            this.gbEngineCapacity.ResumeLayout(false);
            this.gbEngineCapacity.PerformLayout();
            this.gbFuelType.ResumeLayout(false);
            this.gbMileage.ResumeLayout(false);
            this.gbMileage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox gbLicensePlate;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.GroupBox gbVIN;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.GroupBox gbModelName;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.GroupBox gbBrandName;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.GroupBox gbYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.GroupBox gbEngineCapacity;
        private System.Windows.Forms.TextBox txtEngineCapacity;
        private System.Windows.Forms.Button btnAddFuelType;
        private System.Windows.Forms.ComboBox cmbFuelTypes;
        private System.Windows.Forms.GroupBox gbFuelType;
        private System.Windows.Forms.GroupBox gbMileage;
        private System.Windows.Forms.TextBox txtMileage;
    }
}