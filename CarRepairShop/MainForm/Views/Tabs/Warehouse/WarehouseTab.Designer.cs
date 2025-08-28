using System.Windows.Forms;

namespace CarRepairShop.MainForm.Views.Tabs.CRM
{
    partial class WarehouseTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseTab));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlButtonDelete = new Panel();
            btnDelete = new Button();
            pnlButtonEdit = new Panel();
            btnEdit = new Button();
            pnlButtonAdd = new Panel();
            btnAdd = new Button();
            dgvWarehouse = new DataGridView();
            lblActions = new Label();
            lblFilters = new Label();
            gbName = new GroupBox();
            txtName = new TextBox();
            gbMaterialType = new GroupBox();
            cmbMaterialType = new ComboBox();
            pnlSeparator = new Panel();
            Debounce = new Timer(components);
            panel1 = new Panel();
            panel2 = new Panel();
            btnMaterialTypes = new Button();
            pnlButtonDelete.SuspendLayout();
            pnlButtonEdit.SuspendLayout();
            pnlButtonAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWarehouse).BeginInit();
            gbName.SuspendLayout();
            gbMaterialType.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlButtonDelete
            // 
            pnlButtonDelete.BackColor = System.Drawing.SystemColors.Control;
            pnlButtonDelete.Controls.Add(btnDelete);
            resources.ApplyResources(pnlButtonDelete, "pnlButtonDelete");
            pnlButtonDelete.ForeColor = System.Drawing.Color.Black;
            pnlButtonDelete.Name = "pnlButtonDelete";
            // 
            // btnDelete
            // 
            resources.ApplyResources(btnDelete, "btnDelete");
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Name = "btnDelete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // pnlButtonEdit
            // 
            pnlButtonEdit.BackColor = System.Drawing.SystemColors.Control;
            pnlButtonEdit.Controls.Add(btnEdit);
            resources.ApplyResources(pnlButtonEdit, "pnlButtonEdit");
            pnlButtonEdit.ForeColor = System.Drawing.Color.Black;
            pnlButtonEdit.Name = "pnlButtonEdit";
            // 
            // btnEdit
            // 
            resources.ApplyResources(btnEdit, "btnEdit");
            btnEdit.Image = Properties.Resources.edit;
            btnEdit.Name = "btnEdit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // pnlButtonAdd
            // 
            pnlButtonAdd.BackColor = System.Drawing.SystemColors.Control;
            pnlButtonAdd.Controls.Add(btnAdd);
            resources.ApplyResources(pnlButtonAdd, "pnlButtonAdd");
            pnlButtonAdd.ForeColor = System.Drawing.Color.Black;
            pnlButtonAdd.Name = "pnlButtonAdd";
            // 
            // btnAdd
            // 
            resources.ApplyResources(btnAdd, "btnAdd");
            btnAdd.Image = Properties.Resources.add;
            btnAdd.Name = "btnAdd";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvWarehouse
            // 
            resources.ApplyResources(dgvWarehouse, "dgvWarehouse");
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvWarehouse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvWarehouse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWarehouse.Name = "dgvWarehouse";
            dgvWarehouse.ReadOnly = true;
            dgvWarehouse.RowHeadersVisible = false;
            dgvWarehouse.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvWarehouse.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvWarehouse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            txtName.TextChanged += txtName_TextChanged;
            // 
            // gbMaterialType
            // 
            gbMaterialType.Controls.Add(cmbMaterialType);
            resources.ApplyResources(gbMaterialType, "gbMaterialType");
            gbMaterialType.ForeColor = System.Drawing.Color.SteelBlue;
            gbMaterialType.Name = "gbMaterialType";
            gbMaterialType.TabStop = false;
            // 
            // cmbMaterialType
            // 
            cmbMaterialType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaterialType.FormattingEnabled = true;
            resources.ApplyResources(cmbMaterialType, "cmbMaterialType");
            cmbMaterialType.Name = "cmbMaterialType";
            cmbMaterialType.SelectedIndexChanged += cmbMaterialType_SelectedIndexChanged;
            // 
            // pnlSeparator
            // 
            pnlSeparator.BackColor = System.Drawing.Color.Coral;
            resources.ApplyResources(pnlSeparator, "pnlSeparator");
            pnlSeparator.Name = "pnlSeparator";
            // 
            // Debounce
            // 
            Debounce.Interval = 700;
            Debounce.Tick += Debounce_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Coral;
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.Control;
            panel2.Controls.Add(btnMaterialTypes);
            resources.ApplyResources(panel2, "panel2");
            panel2.ForeColor = System.Drawing.Color.Black;
            panel2.Name = "panel2";
            // 
            // btnMaterialTypes
            // 
            resources.ApplyResources(btnMaterialTypes, "btnMaterialTypes");
            btnMaterialTypes.Image = Properties.Resources.warehouse;
            btnMaterialTypes.Name = "btnMaterialTypes";
            btnMaterialTypes.UseVisualStyleBackColor = true;
            btnMaterialTypes.Click += btnMaterialTypes_Click;
            // 
            // WarehouseTab
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvWarehouse);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pnlSeparator);
            Controls.Add(gbMaterialType);
            Controls.Add(gbName);
            Controls.Add(lblFilters);
            Controls.Add(lblActions);
            Controls.Add(pnlButtonDelete);
            Controls.Add(pnlButtonEdit);
            Controls.Add(pnlButtonAdd);
            Name = "WarehouseTab";
            Load += WarehouseTab_Load;
            pnlButtonDelete.ResumeLayout(false);
            pnlButtonEdit.ResumeLayout(false);
            pnlButtonAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvWarehouse).EndInit();
            gbName.ResumeLayout(false);
            gbName.PerformLayout();
            gbMaterialType.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtonDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlButtonEdit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel pnlButtonAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvWarehouse;
        private System.Windows.Forms.Label lblActions;
        private System.Windows.Forms.Label lblFilters;
        private System.Windows.Forms.GroupBox gbName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox gbMaterialType;
        private System.Windows.Forms.ComboBox cmbMaterialType;
        private System.Windows.Forms.Panel pnlSeparator;
        private System.Windows.Forms.Timer Debounce;
        private Panel panel1;
        private Panel panel2;
        private Button btnMaterialTypes;
    }
}
