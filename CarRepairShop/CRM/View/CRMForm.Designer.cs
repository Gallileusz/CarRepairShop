namespace CarRepairShop.CRM.View
{
    partial class CRMForm
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
            this.lblSelectedVehicle = new System.Windows.Forms.Label();
            this.dgvContractorCars = new System.Windows.Forms.DataGridView();
            this.lblContractorFullName = new System.Windows.Forms.Label();
            this.cmbContractor = new System.Windows.Forms.ComboBox();
            this.gbMechanicData = new System.Windows.Forms.GroupBox();
            this.txtMechanicSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMechanicName = new System.Windows.Forms.TextBox();
            this.gbTaskData = new System.Windows.Forms.GroupBox();
            this.cbTaskClosed = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDateClosed = new System.Windows.Forms.TextBox();
            this.rtbTaskComment = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDateCreated = new System.Windows.Forms.TextBox();
            this.gbRequiredServices = new System.Windows.Forms.GroupBox();
            this.dgvRequiredServices = new System.Windows.Forms.DataGridView();
            this.gbSelectedServices = new System.Windows.Forms.GroupBox();
            this.btnDecrement = new System.Windows.Forms.Button();
            this.btnIncrement = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtExpectedPrice = new System.Windows.Forms.TextBox();
            this.dgvSelectedServices = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.gbName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractorCars)).BeginInit();
            this.gbMechanicData.SuspendLayout();
            this.gbTaskData.SuspendLayout();
            this.gbRequiredServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequiredServices)).BeginInit();
            this.gbSelectedServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedServices)).BeginInit();
            this.SuspendLayout();
            // 
            // gbName
            // 
            this.gbName.Controls.Add(this.lblSelectedVehicle);
            this.gbName.Controls.Add(this.dgvContractorCars);
            this.gbName.Controls.Add(this.lblContractorFullName);
            this.gbName.Controls.Add(this.cmbContractor);
            this.gbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbName.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbName.Location = new System.Drawing.Point(12, 12);
            this.gbName.Name = "gbName";
            this.gbName.Size = new System.Drawing.Size(428, 208);
            this.gbName.TabIndex = 41;
            this.gbName.TabStop = false;
            this.gbName.Text = "Contractor data:";
            // 
            // lblSelectedVehicle
            // 
            this.lblSelectedVehicle.AutoSize = true;
            this.lblSelectedVehicle.Location = new System.Drawing.Point(5, 58);
            this.lblSelectedVehicle.Name = "lblSelectedVehicle";
            this.lblSelectedVehicle.Size = new System.Drawing.Size(110, 16);
            this.lblSelectedVehicle.TabIndex = 4;
            this.lblSelectedVehicle.Text = "Selected vehicle:";
            // 
            // dgvContractorCars
            // 
            this.dgvContractorCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContractorCars.Location = new System.Drawing.Point(8, 81);
            this.dgvContractorCars.MultiSelect = false;
            this.dgvContractorCars.Name = "dgvContractorCars";
            this.dgvContractorCars.ReadOnly = true;
            this.dgvContractorCars.RowHeadersVisible = false;
            this.dgvContractorCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContractorCars.Size = new System.Drawing.Size(412, 121);
            this.dgvContractorCars.TabIndex = 3;
            this.dgvContractorCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContractorCars_CellClick);
            // 
            // lblContractorFullName
            // 
            this.lblContractorFullName.AutoSize = true;
            this.lblContractorFullName.Location = new System.Drawing.Point(6, 28);
            this.lblContractorFullName.Name = "lblContractorFullName";
            this.lblContractorFullName.Size = new System.Drawing.Size(65, 16);
            this.lblContractorFullName.TabIndex = 2;
            this.lblContractorFullName.Text = "Fullname:";
            // 
            // cmbContractor
            // 
            this.cmbContractor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContractor.FormattingEnabled = true;
            this.cmbContractor.Location = new System.Drawing.Point(77, 25);
            this.cmbContractor.Name = "cmbContractor";
            this.cmbContractor.Size = new System.Drawing.Size(343, 24);
            this.cmbContractor.TabIndex = 0;
            this.cmbContractor.SelectedValueChanged += new System.EventHandler(this.cmbContractor_SelectedValueChanged);
            // 
            // gbMechanicData
            // 
            this.gbMechanicData.Controls.Add(this.txtMechanicSurname);
            this.gbMechanicData.Controls.Add(this.label3);
            this.gbMechanicData.Controls.Add(this.label4);
            this.gbMechanicData.Controls.Add(this.txtMechanicName);
            this.gbMechanicData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbMechanicData.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbMechanicData.Location = new System.Drawing.Point(457, 285);
            this.gbMechanicData.Name = "gbMechanicData";
            this.gbMechanicData.Size = new System.Drawing.Size(329, 97);
            this.gbMechanicData.TabIndex = 42;
            this.gbMechanicData.TabStop = false;
            this.gbMechanicData.Text = "Mechanic data:";
            // 
            // txtMechanicSurname
            // 
            this.txtMechanicSurname.Location = new System.Drawing.Point(76, 59);
            this.txtMechanicSurname.Name = "txtMechanicSurname";
            this.txtMechanicSurname.ReadOnly = true;
            this.txtMechanicSurname.Size = new System.Drawing.Size(245, 22);
            this.txtMechanicSurname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name:";
            // 
            // txtMechanicName
            // 
            this.txtMechanicName.Location = new System.Drawing.Point(76, 24);
            this.txtMechanicName.Name = "txtMechanicName";
            this.txtMechanicName.ReadOnly = true;
            this.txtMechanicName.Size = new System.Drawing.Size(245, 22);
            this.txtMechanicName.TabIndex = 0;
            // 
            // gbTaskData
            // 
            this.gbTaskData.Controls.Add(this.cbTaskClosed);
            this.gbTaskData.Controls.Add(this.label2);
            this.gbTaskData.Controls.Add(this.txtDateClosed);
            this.gbTaskData.Controls.Add(this.rtbTaskComment);
            this.gbTaskData.Controls.Add(this.label7);
            this.gbTaskData.Controls.Add(this.label5);
            this.gbTaskData.Controls.Add(this.label6);
            this.gbTaskData.Controls.Add(this.txtDateCreated);
            this.gbTaskData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbTaskData.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbTaskData.Location = new System.Drawing.Point(457, 12);
            this.gbTaskData.Name = "gbTaskData";
            this.gbTaskData.Size = new System.Drawing.Size(331, 258);
            this.gbTaskData.TabIndex = 43;
            this.gbTaskData.TabStop = false;
            this.gbTaskData.Text = "Task data:";
            // 
            // cbTaskClosed
            // 
            this.cbTaskClosed.AutoSize = true;
            this.cbTaskClosed.ForeColor = System.Drawing.Color.Red;
            this.cbTaskClosed.Location = new System.Drawing.Point(101, 52);
            this.cbTaskClosed.Name = "cbTaskClosed";
            this.cbTaskClosed.Size = new System.Drawing.Size(44, 20);
            this.cbTaskClosed.TabIndex = 8;
            this.cbTaskClosed.Text = "No";
            this.cbTaskClosed.UseVisualStyleBackColor = true;
            this.cbTaskClosed.CheckedChanged += new System.EventHandler(this.cbTaskClosed_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date closed:";
            // 
            // txtDateClosed
            // 
            this.txtDateClosed.Location = new System.Drawing.Point(101, 78);
            this.txtDateClosed.Name = "txtDateClosed";
            this.txtDateClosed.ReadOnly = true;
            this.txtDateClosed.Size = new System.Drawing.Size(222, 22);
            this.txtDateClosed.TabIndex = 6;
            // 
            // rtbTaskComment
            // 
            this.rtbTaskComment.Location = new System.Drawing.Point(6, 133);
            this.rtbTaskComment.Name = "rtbTaskComment";
            this.rtbTaskComment.Size = new System.Drawing.Size(315, 118);
            this.rtbTaskComment.TabIndex = 5;
            this.rtbTaskComment.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Comment to the problem:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Task closed:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Date created:";
            // 
            // txtDateCreated
            // 
            this.txtDateCreated.Location = new System.Drawing.Point(101, 24);
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.ReadOnly = true;
            this.txtDateCreated.Size = new System.Drawing.Size(222, 22);
            this.txtDateCreated.TabIndex = 0;
            // 
            // gbRequiredServices
            // 
            this.gbRequiredServices.Controls.Add(this.dgvRequiredServices);
            this.gbRequiredServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbRequiredServices.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbRequiredServices.Location = new System.Drawing.Point(12, 226);
            this.gbRequiredServices.Name = "gbRequiredServices";
            this.gbRequiredServices.Size = new System.Drawing.Size(428, 156);
            this.gbRequiredServices.TabIndex = 44;
            this.gbRequiredServices.TabStop = false;
            this.gbRequiredServices.Text = "Required services:";
            // 
            // dgvRequiredServices
            // 
            this.dgvRequiredServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequiredServices.Location = new System.Drawing.Point(8, 21);
            this.dgvRequiredServices.Name = "dgvRequiredServices";
            this.dgvRequiredServices.ReadOnly = true;
            this.dgvRequiredServices.RowHeadersVisible = false;
            this.dgvRequiredServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequiredServices.Size = new System.Drawing.Size(412, 129);
            this.dgvRequiredServices.TabIndex = 0;
            this.dgvRequiredServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequiredServices_CellClick);
            // 
            // gbSelectedServices
            // 
            this.gbSelectedServices.Controls.Add(this.btnDecrement);
            this.gbSelectedServices.Controls.Add(this.btnIncrement);
            this.gbSelectedServices.Controls.Add(this.lblQuantity);
            this.gbSelectedServices.Controls.Add(this.label8);
            this.gbSelectedServices.Controls.Add(this.txtExpectedPrice);
            this.gbSelectedServices.Controls.Add(this.dgvSelectedServices);
            this.gbSelectedServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbSelectedServices.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbSelectedServices.Location = new System.Drawing.Point(12, 388);
            this.gbSelectedServices.Name = "gbSelectedServices";
            this.gbSelectedServices.Size = new System.Drawing.Size(776, 192);
            this.gbSelectedServices.TabIndex = 45;
            this.gbSelectedServices.TabStop = false;
            this.gbSelectedServices.Text = "Selected services:";
            // 
            // btnDecrement
            // 
            this.btnDecrement.Location = new System.Drawing.Point(429, 122);
            this.btnDecrement.Name = "btnDecrement";
            this.btnDecrement.Size = new System.Drawing.Size(41, 43);
            this.btnDecrement.TabIndex = 13;
            this.btnDecrement.Text = "- 1";
            this.btnDecrement.UseVisualStyleBackColor = true;
            this.btnDecrement.Click += new System.EventHandler(this.btnDecrement_Click);
            // 
            // btnIncrement
            // 
            this.btnIncrement.Location = new System.Drawing.Point(429, 57);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(41, 43);
            this.btnIncrement.TabIndex = 11;
            this.btnIncrement.Text = "+ 1";
            this.btnIncrement.UseVisualStyleBackColor = true;
            this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(426, 103);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(55, 16);
            this.lblQuantity.TabIndex = 10;
            this.lblQuantity.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(437, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Expected price:";
            // 
            // txtExpectedPrice
            // 
            this.txtExpectedPrice.Location = new System.Drawing.Point(556, 166);
            this.txtExpectedPrice.Name = "txtExpectedPrice";
            this.txtExpectedPrice.ReadOnly = true;
            this.txtExpectedPrice.Size = new System.Drawing.Size(215, 22);
            this.txtExpectedPrice.TabIndex = 8;
            // 
            // dgvSelectedServices
            // 
            this.dgvSelectedServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedServices.Location = new System.Drawing.Point(8, 21);
            this.dgvSelectedServices.MultiSelect = false;
            this.dgvSelectedServices.Name = "dgvSelectedServices";
            this.dgvSelectedServices.ReadOnly = true;
            this.dgvSelectedServices.RowHeadersVisible = false;
            this.dgvSelectedServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectedServices.Size = new System.Drawing.Size(412, 165);
            this.dgvSelectedServices.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(408, 586);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 27);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnConfirm.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnConfirm.Location = new System.Drawing.Point(277, 586);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(104, 27);
            this.btnConfirm.TabIndex = 46;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // CRMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 621);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gbSelectedServices);
            this.Controls.Add(this.gbRequiredServices);
            this.Controls.Add(this.gbTaskData);
            this.Controls.Add(this.gbMechanicData);
            this.Controls.Add(this.gbName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CRMForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRMForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CRMForm_FormClosed);
            this.Load += new System.EventHandler(this.CRMForm_Load);
            this.gbName.ResumeLayout(false);
            this.gbName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractorCars)).EndInit();
            this.gbMechanicData.ResumeLayout(false);
            this.gbMechanicData.PerformLayout();
            this.gbTaskData.ResumeLayout(false);
            this.gbTaskData.PerformLayout();
            this.gbRequiredServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequiredServices)).EndInit();
            this.gbSelectedServices.ResumeLayout(false);
            this.gbSelectedServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbName;
        private System.Windows.Forms.GroupBox gbMechanicData;
        private System.Windows.Forms.TextBox txtMechanicSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMechanicName;
        private System.Windows.Forms.GroupBox gbTaskData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDateCreated;
        private System.Windows.Forms.RichTextBox rtbTaskComment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbRequiredServices;
        private System.Windows.Forms.DataGridView dgvRequiredServices;
        private System.Windows.Forms.GroupBox gbSelectedServices;
        private System.Windows.Forms.DataGridView dgvSelectedServices;
        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtExpectedPrice;
        private System.Windows.Forms.Button btnDecrement;
        private System.Windows.Forms.Label lblContractorFullName;
        private System.Windows.Forms.ComboBox cmbContractor;
        private System.Windows.Forms.Label lblSelectedVehicle;
        private System.Windows.Forms.DataGridView dgvContractorCars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDateClosed;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.CheckBox cbTaskClosed;
    }
}