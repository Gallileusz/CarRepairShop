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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRMForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            gbName = new System.Windows.Forms.GroupBox();
            lblSelectedVehicle = new System.Windows.Forms.Label();
            dgvContractorCars = new System.Windows.Forms.DataGridView();
            lblContractorFullName = new System.Windows.Forms.Label();
            cmbContractor = new System.Windows.Forms.ComboBox();
            gbMechanicData = new System.Windows.Forms.GroupBox();
            txtMechanicSurname = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtMechanicName = new System.Windows.Forms.TextBox();
            gbTaskData = new System.Windows.Forms.GroupBox();
            cbTaskClosed = new System.Windows.Forms.CheckBox();
            label2 = new System.Windows.Forms.Label();
            txtDateClosed = new System.Windows.Forms.TextBox();
            rtbTaskComment = new System.Windows.Forms.RichTextBox();
            label7 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtDateCreated = new System.Windows.Forms.TextBox();
            gbRequiredServices = new System.Windows.Forms.GroupBox();
            dgvRequiredServices = new System.Windows.Forms.DataGridView();
            gbSelectedServices = new System.Windows.Forms.GroupBox();
            btnDecrement = new System.Windows.Forms.Button();
            btnIncrement = new System.Windows.Forms.Button();
            lblQuantity = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            txtExpectedPrice = new System.Windows.Forms.TextBox();
            dgvSelectedServices = new System.Windows.Forms.DataGridView();
            btnCancel = new System.Windows.Forms.Button();
            btnConfirm = new System.Windows.Forms.Button();
            gbName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContractorCars).BeginInit();
            gbMechanicData.SuspendLayout();
            gbTaskData.SuspendLayout();
            gbRequiredServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequiredServices).BeginInit();
            gbSelectedServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSelectedServices).BeginInit();
            SuspendLayout();
            // 
            // gbName
            // 
            gbName.Controls.Add(lblSelectedVehicle);
            gbName.Controls.Add(dgvContractorCars);
            gbName.Controls.Add(lblContractorFullName);
            gbName.Controls.Add(cmbContractor);
            resources.ApplyResources(gbName, "gbName");
            gbName.ForeColor = System.Drawing.Color.SteelBlue;
            gbName.Name = "gbName";
            gbName.TabStop = false;
            // 
            // lblSelectedVehicle
            // 
            resources.ApplyResources(lblSelectedVehicle, "lblSelectedVehicle");
            lblSelectedVehicle.Name = "lblSelectedVehicle";
            // 
            // dgvContractorCars
            // 
            dgvContractorCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvContractorCars.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(dgvContractorCars, "dgvContractorCars");
            dgvContractorCars.MultiSelect = false;
            dgvContractorCars.Name = "dgvContractorCars";
            dgvContractorCars.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvContractorCars.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvContractorCars.RowHeadersVisible = false;
            dgvContractorCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvContractorCars.CellClick += dgvContractorCars_CellClick;
            // 
            // lblContractorFullName
            // 
            resources.ApplyResources(lblContractorFullName, "lblContractorFullName");
            lblContractorFullName.Name = "lblContractorFullName";
            // 
            // cmbContractor
            // 
            cmbContractor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbContractor.FormattingEnabled = true;
            resources.ApplyResources(cmbContractor, "cmbContractor");
            cmbContractor.Name = "cmbContractor";
            cmbContractor.SelectedValueChanged += cmbContractor_SelectedValueChanged;
            // 
            // gbMechanicData
            // 
            gbMechanicData.Controls.Add(txtMechanicSurname);
            gbMechanicData.Controls.Add(label3);
            gbMechanicData.Controls.Add(label4);
            gbMechanicData.Controls.Add(txtMechanicName);
            resources.ApplyResources(gbMechanicData, "gbMechanicData");
            gbMechanicData.ForeColor = System.Drawing.Color.SteelBlue;
            gbMechanicData.Name = "gbMechanicData";
            gbMechanicData.TabStop = false;
            // 
            // txtMechanicSurname
            // 
            resources.ApplyResources(txtMechanicSurname, "txtMechanicSurname");
            txtMechanicSurname.Name = "txtMechanicSurname";
            txtMechanicSurname.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // txtMechanicName
            // 
            resources.ApplyResources(txtMechanicName, "txtMechanicName");
            txtMechanicName.Name = "txtMechanicName";
            txtMechanicName.ReadOnly = true;
            // 
            // gbTaskData
            // 
            gbTaskData.Controls.Add(cbTaskClosed);
            gbTaskData.Controls.Add(label2);
            gbTaskData.Controls.Add(txtDateClosed);
            gbTaskData.Controls.Add(rtbTaskComment);
            gbTaskData.Controls.Add(label7);
            gbTaskData.Controls.Add(label5);
            gbTaskData.Controls.Add(label6);
            gbTaskData.Controls.Add(txtDateCreated);
            resources.ApplyResources(gbTaskData, "gbTaskData");
            gbTaskData.ForeColor = System.Drawing.Color.SteelBlue;
            gbTaskData.Name = "gbTaskData";
            gbTaskData.TabStop = false;
            // 
            // cbTaskClosed
            // 
            resources.ApplyResources(cbTaskClosed, "cbTaskClosed");
            cbTaskClosed.ForeColor = System.Drawing.Color.Red;
            cbTaskClosed.Name = "cbTaskClosed";
            cbTaskClosed.UseVisualStyleBackColor = true;
            cbTaskClosed.CheckedChanged += cbTaskClosed_CheckedChanged;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // txtDateClosed
            // 
            resources.ApplyResources(txtDateClosed, "txtDateClosed");
            txtDateClosed.Name = "txtDateClosed";
            txtDateClosed.ReadOnly = true;
            // 
            // rtbTaskComment
            // 
            resources.ApplyResources(rtbTaskComment, "rtbTaskComment");
            rtbTaskComment.Name = "rtbTaskComment";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // txtDateCreated
            // 
            resources.ApplyResources(txtDateCreated, "txtDateCreated");
            txtDateCreated.Name = "txtDateCreated";
            txtDateCreated.ReadOnly = true;
            // 
            // gbRequiredServices
            // 
            gbRequiredServices.Controls.Add(dgvRequiredServices);
            resources.ApplyResources(gbRequiredServices, "gbRequiredServices");
            gbRequiredServices.ForeColor = System.Drawing.Color.SteelBlue;
            gbRequiredServices.Name = "gbRequiredServices";
            gbRequiredServices.TabStop = false;
            // 
            // dgvRequiredServices
            // 
            dgvRequiredServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvRequiredServices.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(dgvRequiredServices, "dgvRequiredServices");
            dgvRequiredServices.Name = "dgvRequiredServices";
            dgvRequiredServices.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvRequiredServices.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvRequiredServices.RowHeadersVisible = false;
            dgvRequiredServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvRequiredServices.CellClick += dgvRequiredServices_CellClick;
            // 
            // gbSelectedServices
            // 
            gbSelectedServices.Controls.Add(btnDecrement);
            gbSelectedServices.Controls.Add(btnIncrement);
            gbSelectedServices.Controls.Add(lblQuantity);
            gbSelectedServices.Controls.Add(label8);
            gbSelectedServices.Controls.Add(txtExpectedPrice);
            gbSelectedServices.Controls.Add(dgvSelectedServices);
            resources.ApplyResources(gbSelectedServices, "gbSelectedServices");
            gbSelectedServices.ForeColor = System.Drawing.Color.SteelBlue;
            gbSelectedServices.Name = "gbSelectedServices";
            gbSelectedServices.TabStop = false;
            // 
            // btnDecrement
            // 
            resources.ApplyResources(btnDecrement, "btnDecrement");
            btnDecrement.Name = "btnDecrement";
            btnDecrement.UseVisualStyleBackColor = true;
            btnDecrement.Click += btnDecrement_Click;
            // 
            // btnIncrement
            // 
            resources.ApplyResources(btnIncrement, "btnIncrement");
            btnIncrement.Name = "btnIncrement";
            btnIncrement.UseVisualStyleBackColor = true;
            btnIncrement.Click += btnIncrement_Click;
            // 
            // lblQuantity
            // 
            resources.ApplyResources(lblQuantity, "lblQuantity");
            lblQuantity.Name = "lblQuantity";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // txtExpectedPrice
            // 
            resources.ApplyResources(txtExpectedPrice, "txtExpectedPrice");
            txtExpectedPrice.Name = "txtExpectedPrice";
            txtExpectedPrice.ReadOnly = true;
            // 
            // dgvSelectedServices
            // 
            dgvSelectedServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvSelectedServices.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(dgvSelectedServices, "dgvSelectedServices");
            dgvSelectedServices.MultiSelect = false;
            dgvSelectedServices.Name = "dgvSelectedServices";
            dgvSelectedServices.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvSelectedServices.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvSelectedServices.RowHeadersVisible = false;
            dgvSelectedServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnCancel
            // 
            resources.ApplyResources(btnCancel, "btnCancel");
            btnCancel.ForeColor = System.Drawing.Color.Red;
            btnCancel.Name = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            resources.ApplyResources(btnConfirm, "btnConfirm");
            btnConfirm.ForeColor = System.Drawing.Color.SteelBlue;
            btnConfirm.Name = "btnConfirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // CRMForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(gbSelectedServices);
            Controls.Add(gbRequiredServices);
            Controls.Add(gbTaskData);
            Controls.Add(gbMechanicData);
            Controls.Add(gbName);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CRMForm";
            FormClosed += CRMForm_FormClosed;
            Load += CRMForm_Load;
            gbName.ResumeLayout(false);
            gbName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContractorCars).EndInit();
            gbMechanicData.ResumeLayout(false);
            gbMechanicData.PerformLayout();
            gbTaskData.ResumeLayout(false);
            gbTaskData.PerformLayout();
            gbRequiredServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRequiredServices).EndInit();
            gbSelectedServices.ResumeLayout(false);
            gbSelectedServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSelectedServices).EndInit();
            ResumeLayout(false);

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