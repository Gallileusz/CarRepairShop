namespace CarRepairShop.MainForm.Views.Tabs.CRM
{
    partial class CRMTab
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRMTab));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            panel2 = new System.Windows.Forms.Panel();
            btnDelete = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            btnEdit = new System.Windows.Forms.Button();
            panel5 = new System.Windows.Forms.Panel();
            btnAdd = new System.Windows.Forms.Button();
            dgvCRM = new System.Windows.Forms.DataGridView();
            pnlSeparator = new System.Windows.Forms.Panel();
            lblActions = new System.Windows.Forms.Label();
            lblFilters = new System.Windows.Forms.Label();
            dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            gbDateFrom = new System.Windows.Forms.GroupBox();
            gbDateTo = new System.Windows.Forms.GroupBox();
            dtpDateTo = new System.Windows.Forms.DateTimePicker();
            gbContractorName = new System.Windows.Forms.GroupBox();
            txtContractorFullname = new System.Windows.Forms.TextBox();
            gbMechanicName = new System.Windows.Forms.GroupBox();
            txtMechanicFullname = new System.Windows.Forms.TextBox();
            Debounce = new System.Windows.Forms.Timer(components);
            gbTaskStatus = new System.Windows.Forms.GroupBox();
            rbNotClosed = new System.Windows.Forms.RadioButton();
            rbClosed = new System.Windows.Forms.RadioButton();
            rbAll = new System.Windows.Forms.RadioButton();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCRM).BeginInit();
            gbDateFrom.SuspendLayout();
            gbDateTo.SuspendLayout();
            gbContractorName.SuspendLayout();
            gbMechanicName.SuspendLayout();
            gbTaskStatus.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.Control;
            panel2.Controls.Add(btnDelete);
            resources.ApplyResources(panel2, "panel2");
            panel2.ForeColor = System.Drawing.Color.Black;
            panel2.Name = "panel2";
            // 
            // btnDelete
            // 
            resources.ApplyResources(btnDelete, "btnDelete");
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Name = "btnDelete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.Control;
            panel1.Controls.Add(btnEdit);
            resources.ApplyResources(panel1, "panel1");
            panel1.ForeColor = System.Drawing.Color.Black;
            panel1.Name = "panel1";
            // 
            // btnEdit
            // 
            resources.ApplyResources(btnEdit, "btnEdit");
            btnEdit.Image = Properties.Resources.edit;
            btnEdit.Name = "btnEdit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.SystemColors.Control;
            panel5.Controls.Add(btnAdd);
            resources.ApplyResources(panel5, "panel5");
            panel5.ForeColor = System.Drawing.Color.Black;
            panel5.Name = "panel5";
            // 
            // btnAdd
            // 
            resources.ApplyResources(btnAdd, "btnAdd");
            btnAdd.Image = Properties.Resources.add;
            btnAdd.Name = "btnAdd";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvCRM
            // 
            resources.ApplyResources(dgvCRM, "dgvCRM");
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvCRM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCRM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvCRM.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCRM.MultiSelect = false;
            dgvCRM.Name = "dgvCRM";
            dgvCRM.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvCRM.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCRM.RowHeadersVisible = false;
            dgvCRM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvCRM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // pnlSeparator
            // 
            pnlSeparator.BackColor = System.Drawing.Color.Coral;
            resources.ApplyResources(pnlSeparator, "pnlSeparator");
            pnlSeparator.Name = "pnlSeparator";
            // 
            // lblActions
            // 
            resources.ApplyResources(lblActions, "lblActions");
            lblActions.ForeColor = System.Drawing.Color.SteelBlue;
            lblActions.Name = "lblActions";
            // 
            // lblFilters
            // 
            resources.ApplyResources(lblFilters, "lblFilters");
            lblFilters.ForeColor = System.Drawing.Color.SteelBlue;
            lblFilters.Name = "lblFilters";
            // 
            // dtpDateFrom
            // 
            dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(dtpDateFrom, "dtpDateFrom");
            dtpDateFrom.Name = "dtpDateFrom";
            dtpDateFrom.ValueChanged += dtpDateFrom_ValueChanged;
            // 
            // gbDateFrom
            // 
            gbDateFrom.Controls.Add(dtpDateFrom);
            resources.ApplyResources(gbDateFrom, "gbDateFrom");
            gbDateFrom.ForeColor = System.Drawing.Color.SteelBlue;
            gbDateFrom.Name = "gbDateFrom";
            gbDateFrom.TabStop = false;
            // 
            // gbDateTo
            // 
            gbDateTo.Controls.Add(dtpDateTo);
            resources.ApplyResources(gbDateTo, "gbDateTo");
            gbDateTo.ForeColor = System.Drawing.Color.SteelBlue;
            gbDateTo.Name = "gbDateTo";
            gbDateTo.TabStop = false;
            // 
            // dtpDateTo
            // 
            dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(dtpDateTo, "dtpDateTo");
            dtpDateTo.Name = "dtpDateTo";
            dtpDateTo.ValueChanged += dtpDateTo_ValueChanged;
            // 
            // gbContractorName
            // 
            gbContractorName.Controls.Add(txtContractorFullname);
            resources.ApplyResources(gbContractorName, "gbContractorName");
            gbContractorName.ForeColor = System.Drawing.Color.SteelBlue;
            gbContractorName.Name = "gbContractorName";
            gbContractorName.TabStop = false;
            // 
            // txtContractorFullname
            // 
            resources.ApplyResources(txtContractorFullname, "txtContractorFullname");
            txtContractorFullname.Name = "txtContractorFullname";
            txtContractorFullname.TextChanged += txtContractorFullname_TextChanged;
            // 
            // gbMechanicName
            // 
            gbMechanicName.Controls.Add(txtMechanicFullname);
            resources.ApplyResources(gbMechanicName, "gbMechanicName");
            gbMechanicName.ForeColor = System.Drawing.Color.SteelBlue;
            gbMechanicName.Name = "gbMechanicName";
            gbMechanicName.TabStop = false;
            // 
            // txtMechanicFullname
            // 
            resources.ApplyResources(txtMechanicFullname, "txtMechanicFullname");
            txtMechanicFullname.Name = "txtMechanicFullname";
            txtMechanicFullname.TextChanged += txtMechanicFullname_TextChanged;
            // 
            // Debounce
            // 
            Debounce.Interval = 500;
            Debounce.Tick += Debounce_Tick;
            // 
            // gbTaskStatus
            // 
            gbTaskStatus.Controls.Add(rbNotClosed);
            gbTaskStatus.Controls.Add(rbClosed);
            gbTaskStatus.Controls.Add(rbAll);
            resources.ApplyResources(gbTaskStatus, "gbTaskStatus");
            gbTaskStatus.ForeColor = System.Drawing.Color.SteelBlue;
            gbTaskStatus.Name = "gbTaskStatus";
            gbTaskStatus.TabStop = false;
            // 
            // rbNotClosed
            // 
            resources.ApplyResources(rbNotClosed, "rbNotClosed");
            rbNotClosed.Name = "rbNotClosed";
            rbNotClosed.UseVisualStyleBackColor = true;
            rbNotClosed.CheckedChanged += rbNotClosed_CheckedChanged;
            // 
            // rbClosed
            // 
            resources.ApplyResources(rbClosed, "rbClosed");
            rbClosed.Name = "rbClosed";
            rbClosed.UseVisualStyleBackColor = true;
            rbClosed.CheckedChanged += rbClosed_CheckedChanged;
            // 
            // rbAll
            // 
            resources.ApplyResources(rbAll, "rbAll");
            rbAll.Checked = true;
            rbAll.Name = "rbAll";
            rbAll.TabStop = true;
            rbAll.UseVisualStyleBackColor = true;
            rbAll.CheckedChanged += rbAll_CheckedChanged;
            // 
            // CRMTab
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gbTaskStatus);
            Controls.Add(gbMechanicName);
            Controls.Add(gbContractorName);
            Controls.Add(gbDateTo);
            Controls.Add(gbDateFrom);
            Controls.Add(lblFilters);
            Controls.Add(lblActions);
            Controls.Add(pnlSeparator);
            Controls.Add(dgvCRM);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Name = "CRMTab";
            Load += CRMTab_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCRM).EndInit();
            gbDateFrom.ResumeLayout(false);
            gbDateTo.ResumeLayout(false);
            gbContractorName.ResumeLayout(false);
            gbContractorName.PerformLayout();
            gbMechanicName.ResumeLayout(false);
            gbMechanicName.PerformLayout();
            gbTaskStatus.ResumeLayout(false);
            gbTaskStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvCRM;
        private System.Windows.Forms.Panel pnlSeparator;
        private System.Windows.Forms.Label lblActions;
        private System.Windows.Forms.Label lblFilters;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.GroupBox gbDateFrom;
        private System.Windows.Forms.GroupBox gbDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.GroupBox gbContractorName;
        private System.Windows.Forms.TextBox txtContractorFullname;
        private System.Windows.Forms.GroupBox gbMechanicName;
        private System.Windows.Forms.TextBox txtMechanicFullname;
        private System.Windows.Forms.Timer Debounce;
        private System.Windows.Forms.GroupBox gbTaskStatus;
        private System.Windows.Forms.RadioButton rbNotClosed;
        private System.Windows.Forms.RadioButton rbClosed;
        private System.Windows.Forms.RadioButton rbAll;
    }
}
