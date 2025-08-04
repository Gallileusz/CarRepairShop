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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvCRM = new System.Windows.Forms.DataGridView();
            this.pnlSeparator = new System.Windows.Forms.Panel();
            this.lblActions = new System.Windows.Forms.Label();
            this.lblFilters = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.gbDateFrom = new System.Windows.Forms.GroupBox();
            this.gbDateTo = new System.Windows.Forms.GroupBox();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.gbContractorName = new System.Windows.Forms.GroupBox();
            this.txtContractorFullname = new System.Windows.Forms.TextBox();
            this.gbMechanicName = new System.Windows.Forms.GroupBox();
            this.txtMechanicFullname = new System.Windows.Forms.TextBox();
            this.Debounce = new System.Windows.Forms.Timer(this.components);
            this.gbTaskStatus = new System.Windows.Forms.GroupBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbClosed = new System.Windows.Forms.RadioButton();
            this.rbNotClosed = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCRM)).BeginInit();
            this.gbDateFrom.SuspendLayout();
            this.gbDateTo.SuspendLayout();
            this.gbContractorName.SuspendLayout();
            this.gbMechanicName.SuspendLayout();
            this.gbTaskStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(5, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 33);
            this.panel2.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::CarRepairShop.Properties.Resources.delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(-5, -8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 48);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(4, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 33);
            this.panel1.TabIndex = 11;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::CarRepairShop.Properties.Resources.edit;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(-4, -8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(164, 48);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.btnAdd);
            this.panel5.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.ForeColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(3, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(161, 33);
            this.panel5.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::CarRepairShop.Properties.Resources.add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(-2, -4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 48);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvCRM
            // 
            this.dgvCRM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCRM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCRM.Location = new System.Drawing.Point(163, 0);
            this.dgvCRM.MultiSelect = false;
            this.dgvCRM.Name = "dgvCRM";
            this.dgvCRM.ReadOnly = true;
            this.dgvCRM.RowHeadersVisible = false;
            this.dgvCRM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvCRM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCRM.Size = new System.Drawing.Size(600, 530);
            this.dgvCRM.TabIndex = 13;
            // 
            // pnlSeparator
            // 
            this.pnlSeparator.BackColor = System.Drawing.Color.Coral;
            this.pnlSeparator.Location = new System.Drawing.Point(2, 134);
            this.pnlSeparator.Name = "pnlSeparator";
            this.pnlSeparator.Size = new System.Drawing.Size(163, 2);
            this.pnlSeparator.TabIndex = 27;
            // 
            // lblActions
            // 
            this.lblActions.AutoSize = true;
            this.lblActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblActions.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblActions.Location = new System.Drawing.Point(3, 4);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(69, 18);
            this.lblActions.TabIndex = 28;
            this.lblActions.Text = "Actions:";
            // 
            // lblFilters
            // 
            this.lblFilters.AutoSize = true;
            this.lblFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFilters.ForeColor = System.Drawing.Color.Black;
            this.lblFilters.Location = new System.Drawing.Point(3, 139);
            this.lblFilters.Name = "lblFilters";
            this.lblFilters.Size = new System.Drawing.Size(60, 18);
            this.lblFilters.TabIndex = 36;
            this.lblFilters.Text = "Filters:";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(6, 23);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(132, 22);
            this.dtpDateFrom.TabIndex = 37;
            this.dtpDateFrom.ValueChanged += new System.EventHandler(this.dtpDateFrom_ValueChanged);
            // 
            // gbDateFrom
            // 
            this.gbDateFrom.Controls.Add(this.dtpDateFrom);
            this.gbDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbDateFrom.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbDateFrom.Location = new System.Drawing.Point(7, 170);
            this.gbDateFrom.Name = "gbDateFrom";
            this.gbDateFrom.Size = new System.Drawing.Size(150, 58);
            this.gbDateFrom.TabIndex = 38;
            this.gbDateFrom.TabStop = false;
            this.gbDateFrom.Text = "Date from:";
            // 
            // gbDateTo
            // 
            this.gbDateTo.Controls.Add(this.dtpDateTo);
            this.gbDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbDateTo.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbDateTo.Location = new System.Drawing.Point(7, 234);
            this.gbDateTo.Name = "gbDateTo";
            this.gbDateTo.Size = new System.Drawing.Size(150, 58);
            this.gbDateTo.TabIndex = 39;
            this.gbDateTo.TabStop = false;
            this.gbDateTo.Text = "Date to:";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(6, 23);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(132, 22);
            this.dtpDateTo.TabIndex = 37;
            this.dtpDateTo.ValueChanged += new System.EventHandler(this.dtpDateTo_ValueChanged);
            // 
            // gbContractorName
            // 
            this.gbContractorName.Controls.Add(this.txtContractorFullname);
            this.gbContractorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbContractorName.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbContractorName.Location = new System.Drawing.Point(7, 298);
            this.gbContractorName.Name = "gbContractorName";
            this.gbContractorName.Size = new System.Drawing.Size(150, 58);
            this.gbContractorName.TabIndex = 40;
            this.gbContractorName.TabStop = false;
            this.gbContractorName.Text = "Contractor fullname:";
            // 
            // txtContractorFullname
            // 
            this.txtContractorFullname.Location = new System.Drawing.Point(6, 23);
            this.txtContractorFullname.Name = "txtContractorFullname";
            this.txtContractorFullname.Size = new System.Drawing.Size(138, 22);
            this.txtContractorFullname.TabIndex = 0;
            this.txtContractorFullname.TextChanged += new System.EventHandler(this.txtContractorFullname_TextChanged);
            // 
            // gbMechanicName
            // 
            this.gbMechanicName.Controls.Add(this.txtMechanicFullname);
            this.gbMechanicName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbMechanicName.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbMechanicName.Location = new System.Drawing.Point(7, 362);
            this.gbMechanicName.Name = "gbMechanicName";
            this.gbMechanicName.Size = new System.Drawing.Size(150, 58);
            this.gbMechanicName.TabIndex = 41;
            this.gbMechanicName.TabStop = false;
            this.gbMechanicName.Text = "Mechanic fullname:";
            // 
            // txtMechanicFullname
            // 
            this.txtMechanicFullname.Location = new System.Drawing.Point(6, 23);
            this.txtMechanicFullname.Name = "txtMechanicFullname";
            this.txtMechanicFullname.Size = new System.Drawing.Size(138, 22);
            this.txtMechanicFullname.TabIndex = 0;
            this.txtMechanicFullname.TextChanged += new System.EventHandler(this.txtMechanicFullname_TextChanged);
            // 
            // Debounce
            // 
            this.Debounce.Interval = 500;
            this.Debounce.Tick += new System.EventHandler(this.Debounce_Tick);
            // 
            // gbTaskStatus
            // 
            this.gbTaskStatus.Controls.Add(this.rbNotClosed);
            this.gbTaskStatus.Controls.Add(this.rbClosed);
            this.gbTaskStatus.Controls.Add(this.rbAll);
            this.gbTaskStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbTaskStatus.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbTaskStatus.Location = new System.Drawing.Point(7, 426);
            this.gbTaskStatus.Name = "gbTaskStatus";
            this.gbTaskStatus.Size = new System.Drawing.Size(150, 98);
            this.gbTaskStatus.TabIndex = 43;
            this.gbTaskStatus.TabStop = false;
            this.gbTaskStatus.Text = "Close status:";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(6, 21);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(40, 20);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbClosed
            // 
            this.rbClosed.AutoSize = true;
            this.rbClosed.Location = new System.Drawing.Point(6, 47);
            this.rbClosed.Name = "rbClosed";
            this.rbClosed.Size = new System.Drawing.Size(68, 20);
            this.rbClosed.TabIndex = 1;
            this.rbClosed.Text = "Closed";
            this.rbClosed.UseVisualStyleBackColor = true;
            this.rbClosed.CheckedChanged += new System.EventHandler(this.rbClosed_CheckedChanged);
            // 
            // rbNotClosed
            // 
            this.rbNotClosed.AutoSize = true;
            this.rbNotClosed.Location = new System.Drawing.Point(6, 73);
            this.rbNotClosed.Name = "rbNotClosed";
            this.rbNotClosed.Size = new System.Drawing.Size(90, 20);
            this.rbNotClosed.TabIndex = 2;
            this.rbNotClosed.Text = "Not closed";
            this.rbNotClosed.UseVisualStyleBackColor = true;
            this.rbNotClosed.CheckedChanged += new System.EventHandler(this.rbNotClosed_CheckedChanged);
            // 
            // CRMTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbTaskStatus);
            this.Controls.Add(this.gbMechanicName);
            this.Controls.Add(this.gbContractorName);
            this.Controls.Add(this.gbDateTo);
            this.Controls.Add(this.gbDateFrom);
            this.Controls.Add(this.lblFilters);
            this.Controls.Add(this.lblActions);
            this.Controls.Add(this.pnlSeparator);
            this.Controls.Add(this.dgvCRM);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Name = "CRMTab";
            this.Size = new System.Drawing.Size(763, 530);
            this.Load += new System.EventHandler(this.CRMTab_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCRM)).EndInit();
            this.gbDateFrom.ResumeLayout(false);
            this.gbDateTo.ResumeLayout(false);
            this.gbContractorName.ResumeLayout(false);
            this.gbContractorName.PerformLayout();
            this.gbMechanicName.ResumeLayout(false);
            this.gbMechanicName.PerformLayout();
            this.gbTaskStatus.ResumeLayout(false);
            this.gbTaskStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
