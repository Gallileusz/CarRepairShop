namespace CarRepairShop.MainForm.Views.Tabs.Services
{
    partial class ServicesTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesTab));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            pnlSeparator = new System.Windows.Forms.Panel();
            lblActions = new System.Windows.Forms.Label();
            pnlButtonDelete = new System.Windows.Forms.Panel();
            btnDeleteService = new System.Windows.Forms.Button();
            pnlButtonEdit = new System.Windows.Forms.Panel();
            btnEditService = new System.Windows.Forms.Button();
            pnlButtonAdd = new System.Windows.Forms.Panel();
            btnAddService = new System.Windows.Forms.Button();
            gbServiceName = new System.Windows.Forms.GroupBox();
            txtServiceName = new System.Windows.Forms.TextBox();
            lblFilters = new System.Windows.Forms.Label();
            Debounce = new System.Windows.Forms.Timer(components);
            groupBox5 = new System.Windows.Forms.GroupBox();
            dgv = new System.Windows.Forms.DataGridView();
            gbStatuses = new System.Windows.Forms.GroupBox();
            rbInactive = new System.Windows.Forms.RadioButton();
            rbActive = new System.Windows.Forms.RadioButton();
            rbAll = new System.Windows.Forms.RadioButton();
            pnlButtonDelete.SuspendLayout();
            pnlButtonEdit.SuspendLayout();
            pnlButtonAdd.SuspendLayout();
            gbServiceName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            gbStatuses.SuspendLayout();
            SuspendLayout();
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
            // pnlButtonDelete
            // 
            pnlButtonDelete.BackColor = System.Drawing.SystemColors.Control;
            pnlButtonDelete.Controls.Add(btnDeleteService);
            resources.ApplyResources(pnlButtonDelete, "pnlButtonDelete");
            pnlButtonDelete.ForeColor = System.Drawing.Color.Black;
            pnlButtonDelete.Name = "pnlButtonDelete";
            // 
            // btnDeleteService
            // 
            resources.ApplyResources(btnDeleteService, "btnDeleteService");
            btnDeleteService.Image = Properties.Resources.delete;
            btnDeleteService.Name = "btnDeleteService";
            btnDeleteService.UseVisualStyleBackColor = true;
            btnDeleteService.Click += btnDeleteService_Click;
            // 
            // pnlButtonEdit
            // 
            pnlButtonEdit.BackColor = System.Drawing.SystemColors.Control;
            pnlButtonEdit.Controls.Add(btnEditService);
            resources.ApplyResources(pnlButtonEdit, "pnlButtonEdit");
            pnlButtonEdit.ForeColor = System.Drawing.Color.Black;
            pnlButtonEdit.Name = "pnlButtonEdit";
            // 
            // btnEditService
            // 
            resources.ApplyResources(btnEditService, "btnEditService");
            btnEditService.Image = Properties.Resources.edit;
            btnEditService.Name = "btnEditService";
            btnEditService.UseVisualStyleBackColor = true;
            btnEditService.Click += btnEditService_Click;
            // 
            // pnlButtonAdd
            // 
            pnlButtonAdd.BackColor = System.Drawing.SystemColors.Control;
            pnlButtonAdd.Controls.Add(btnAddService);
            resources.ApplyResources(pnlButtonAdd, "pnlButtonAdd");
            pnlButtonAdd.ForeColor = System.Drawing.Color.Black;
            pnlButtonAdd.Name = "pnlButtonAdd";
            // 
            // btnAddService
            // 
            resources.ApplyResources(btnAddService, "btnAddService");
            btnAddService.Image = Properties.Resources.add;
            btnAddService.Name = "btnAddService";
            btnAddService.UseVisualStyleBackColor = true;
            btnAddService.Click += btnAddService_Click;
            // 
            // gbServiceName
            // 
            gbServiceName.Controls.Add(txtServiceName);
            resources.ApplyResources(gbServiceName, "gbServiceName");
            gbServiceName.ForeColor = System.Drawing.Color.SteelBlue;
            gbServiceName.Name = "gbServiceName";
            gbServiceName.TabStop = false;
            // 
            // txtServiceName
            // 
            resources.ApplyResources(txtServiceName, "txtServiceName");
            txtServiceName.Name = "txtServiceName";
            txtServiceName.TextChanged += txtServiceName_TextChanged;
            // 
            // lblFilters
            // 
            resources.ApplyResources(lblFilters, "lblFilters");
            lblFilters.ForeColor = System.Drawing.Color.SteelBlue;
            lblFilters.Name = "lblFilters";
            // 
            // Debounce
            // 
            Debounce.Interval = 400;
            Debounce.Tick += Debounce_Tick;
            // 
            // groupBox5
            // 
            resources.ApplyResources(groupBox5, "groupBox5");
            groupBox5.ForeColor = System.Drawing.Color.Coral;
            groupBox5.Name = "groupBox5";
            groupBox5.TabStop = false;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            resources.ApplyResources(dgv, "dgv");
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle2;
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // gbStatuses
            // 
            gbStatuses.Controls.Add(rbInactive);
            gbStatuses.Controls.Add(rbActive);
            gbStatuses.Controls.Add(rbAll);
            resources.ApplyResources(gbStatuses, "gbStatuses");
            gbStatuses.ForeColor = System.Drawing.Color.SteelBlue;
            gbStatuses.Name = "gbStatuses";
            gbStatuses.TabStop = false;
            // 
            // rbInactive
            // 
            resources.ApplyResources(rbInactive, "rbInactive");
            rbInactive.Name = "rbInactive";
            rbInactive.UseVisualStyleBackColor = true;
            rbInactive.CheckedChanged += rbInactive_CheckedChanged;
            // 
            // rbActive
            // 
            resources.ApplyResources(rbActive, "rbActive");
            rbActive.Checked = true;
            rbActive.Name = "rbActive";
            rbActive.TabStop = true;
            rbActive.UseVisualStyleBackColor = true;
            rbActive.CheckedChanged += rbActive_CheckedChanged;
            // 
            // rbAll
            // 
            resources.ApplyResources(rbAll, "rbAll");
            rbAll.Name = "rbAll";
            rbAll.UseVisualStyleBackColor = true;
            rbAll.CheckedChanged += rbAll_CheckedChanged;
            // 
            // ServicesTab
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gbStatuses);
            Controls.Add(dgv);
            Controls.Add(lblFilters);
            Controls.Add(gbServiceName);
            Controls.Add(pnlSeparator);
            Controls.Add(lblActions);
            Controls.Add(pnlButtonDelete);
            Controls.Add(pnlButtonEdit);
            Controls.Add(pnlButtonAdd);
            Name = "ServicesTab";
            Load += ServicesTab_Load;
            pnlButtonDelete.ResumeLayout(false);
            pnlButtonEdit.ResumeLayout(false);
            pnlButtonAdd.ResumeLayout(false);
            gbServiceName.ResumeLayout(false);
            gbServiceName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            gbStatuses.ResumeLayout(false);
            gbStatuses.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel pnlSeparator;
        private System.Windows.Forms.Label lblActions;
        private System.Windows.Forms.Panel pnlButtonDelete;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Panel pnlButtonEdit;
        private System.Windows.Forms.Button btnEditService;
        private System.Windows.Forms.Panel pnlButtonAdd;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.GroupBox gbServiceName;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Label lblFilters;
        private System.Windows.Forms.Timer Debounce;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox gbStatuses;
        private System.Windows.Forms.RadioButton rbInactive;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.RadioButton rbAll;
    }
}
