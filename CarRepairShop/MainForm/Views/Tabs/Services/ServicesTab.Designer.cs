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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesTab));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSeparator = new System.Windows.Forms.Panel();
            this.lblActions = new System.Windows.Forms.Label();
            this.pnlButtonDelete = new System.Windows.Forms.Panel();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.pnlButtonEdit = new System.Windows.Forms.Panel();
            this.btnEditService = new System.Windows.Forms.Button();
            this.pnlButtonAdd = new System.Windows.Forms.Panel();
            this.btnAddService = new System.Windows.Forms.Button();
            this.gbServiceName = new System.Windows.Forms.GroupBox();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.lblFilters = new System.Windows.Forms.Label();
            this.Debounce = new System.Windows.Forms.Timer(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.gbStatuses = new System.Windows.Forms.GroupBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.rbInactive = new System.Windows.Forms.RadioButton();
            this.pnlButtonDelete.SuspendLayout();
            this.pnlButtonEdit.SuspendLayout();
            this.pnlButtonAdd.SuspendLayout();
            this.gbServiceName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gbStatuses.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSeparator
            // 
            this.pnlSeparator.BackColor = System.Drawing.Color.Coral;
            resources.ApplyResources(this.pnlSeparator, "pnlSeparator");
            this.pnlSeparator.Name = "pnlSeparator";
            // 
            // lblActions
            // 
            resources.ApplyResources(this.lblActions, "lblActions");
            this.lblActions.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblActions.Name = "lblActions";
            // 
            // pnlButtonDelete
            // 
            this.pnlButtonDelete.BackColor = System.Drawing.SystemColors.Control;
            this.pnlButtonDelete.Controls.Add(this.btnDeleteService);
            resources.ApplyResources(this.pnlButtonDelete, "pnlButtonDelete");
            this.pnlButtonDelete.ForeColor = System.Drawing.Color.Black;
            this.pnlButtonDelete.Name = "pnlButtonDelete";
            // 
            // btnDeleteService
            // 
            resources.ApplyResources(this.btnDeleteService, "btnDeleteService");
            this.btnDeleteService.Image = global::CarRepairShop.Properties.Resources.delete;
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // pnlButtonEdit
            // 
            this.pnlButtonEdit.BackColor = System.Drawing.SystemColors.Control;
            this.pnlButtonEdit.Controls.Add(this.btnEditService);
            resources.ApplyResources(this.pnlButtonEdit, "pnlButtonEdit");
            this.pnlButtonEdit.ForeColor = System.Drawing.Color.Black;
            this.pnlButtonEdit.Name = "pnlButtonEdit";
            // 
            // btnEditService
            // 
            resources.ApplyResources(this.btnEditService, "btnEditService");
            this.btnEditService.Image = global::CarRepairShop.Properties.Resources.edit;
            this.btnEditService.Name = "btnEditService";
            this.btnEditService.UseVisualStyleBackColor = true;
            this.btnEditService.Click += new System.EventHandler(this.btnEditService_Click);
            // 
            // pnlButtonAdd
            // 
            this.pnlButtonAdd.BackColor = System.Drawing.SystemColors.Control;
            this.pnlButtonAdd.Controls.Add(this.btnAddService);
            resources.ApplyResources(this.pnlButtonAdd, "pnlButtonAdd");
            this.pnlButtonAdd.ForeColor = System.Drawing.Color.Black;
            this.pnlButtonAdd.Name = "pnlButtonAdd";
            // 
            // btnAddService
            // 
            resources.ApplyResources(this.btnAddService, "btnAddService");
            this.btnAddService.Image = global::CarRepairShop.Properties.Resources.add;
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // gbServiceName
            // 
            this.gbServiceName.Controls.Add(this.txtServiceName);
            resources.ApplyResources(this.gbServiceName, "gbServiceName");
            this.gbServiceName.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbServiceName.Name = "gbServiceName";
            this.gbServiceName.TabStop = false;
            // 
            // txtServiceName
            // 
            resources.ApplyResources(this.txtServiceName, "txtServiceName");
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.TextChanged += new System.EventHandler(this.txtServiceName_TextChanged);
            // 
            // lblFilters
            // 
            resources.ApplyResources(this.lblFilters, "lblFilters"); 
            this.lblFilters.ForeColor = System.Drawing.Color.Black;
            this.lblFilters.Name = "lblFilters";
            // 
            // Debounce
            // 
            this.Debounce.Interval = 400;
            this.Debounce.Tick += new System.EventHandler(this.Debounce_Tick);
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.ForeColor = System.Drawing.Color.Coral;
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dgv, "dgv");
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // gbStatuses
            // 
            this.gbStatuses.Controls.Add(this.rbInactive);
            this.gbStatuses.Controls.Add(this.rbActive);
            this.gbStatuses.Controls.Add(this.rbAll);
            resources.ApplyResources(this.gbStatuses, "gbStatuses");
            this.gbStatuses.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbStatuses.Name = "gbStatuses";
            this.gbStatuses.TabStop = false;
            // 
            // rbAll
            // 
            resources.ApplyResources(this.rbAll, "rbAll");
            this.rbAll.Name = "rbAll";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbActive
            // 
            resources.ApplyResources(this.rbActive, "rbActive");
            this.rbActive.Checked = true;
            this.rbActive.Name = "rbActive";
            this.rbActive.TabStop = true;
            this.rbActive.UseVisualStyleBackColor = true;
            this.rbActive.CheckedChanged += new System.EventHandler(this.rbActive_CheckedChanged);
            // 
            // rbInactive
            // 
            resources.ApplyResources(this.rbInactive, "rbInactive");
            this.rbInactive.Name = "rbInactive";
            this.rbInactive.UseVisualStyleBackColor = true;
            this.rbInactive.CheckedChanged += new System.EventHandler(this.rbInactive_CheckedChanged);
            // 
            // ServicesTab
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbStatuses);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblFilters);
            this.Controls.Add(this.gbServiceName);
            this.Controls.Add(this.pnlSeparator);
            this.Controls.Add(this.lblActions);
            this.Controls.Add(this.pnlButtonDelete);
            this.Controls.Add(this.pnlButtonEdit);
            this.Controls.Add(this.pnlButtonAdd);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "ServicesTab";
            this.Load += new System.EventHandler(this.ServicesTab_Load);
            this.pnlButtonDelete.ResumeLayout(false);
            this.pnlButtonEdit.ResumeLayout(false);
            this.pnlButtonAdd.ResumeLayout(false);
            this.gbServiceName.ResumeLayout(false);
            this.gbServiceName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gbStatuses.ResumeLayout(false);
            this.gbStatuses.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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
