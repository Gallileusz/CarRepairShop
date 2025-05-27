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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlButtonDelete = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlButtonEdit = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlButtonAdd = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvWarehouse = new System.Windows.Forms.DataGridView();
            this.lblActions = new System.Windows.Forms.Label();
            this.lblFilters = new System.Windows.Forms.Label();
            this.gbName = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gbMaterialType = new System.Windows.Forms.GroupBox();
            this.cmbMaterialType = new System.Windows.Forms.ComboBox();
            this.pnlSeparator = new System.Windows.Forms.Panel();
            this.Debounce = new System.Windows.Forms.Timer(this.components);
            this.pnlButtonDelete.SuspendLayout();
            this.pnlButtonEdit.SuspendLayout();
            this.pnlButtonAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouse)).BeginInit();
            this.gbName.SuspendLayout();
            this.gbMaterialType.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtonDelete
            // 
            this.pnlButtonDelete.BackColor = System.Drawing.SystemColors.Control;
            this.pnlButtonDelete.Controls.Add(this.btnDelete);
            this.pnlButtonDelete.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlButtonDelete.ForeColor = System.Drawing.Color.Black;
            this.pnlButtonDelete.Location = new System.Drawing.Point(5, 95);
            this.pnlButtonDelete.Name = "pnlButtonDelete";
            this.pnlButtonDelete.Size = new System.Drawing.Size(159, 33);
            this.pnlButtonDelete.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::CarRepairShop.Properties.Resources.delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(-5, -8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(168, 48);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlButtonEdit
            // 
            this.pnlButtonEdit.BackColor = System.Drawing.SystemColors.Control;
            this.pnlButtonEdit.Controls.Add(this.btnEdit);
            this.pnlButtonEdit.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlButtonEdit.ForeColor = System.Drawing.Color.Black;
            this.pnlButtonEdit.Location = new System.Drawing.Point(4, 62);
            this.pnlButtonEdit.Name = "pnlButtonEdit";
            this.pnlButtonEdit.Size = new System.Drawing.Size(160, 33);
            this.pnlButtonEdit.TabIndex = 11;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::CarRepairShop.Properties.Resources.edit;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(-4, -8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(168, 48);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnlButtonAdd
            // 
            this.pnlButtonAdd.BackColor = System.Drawing.SystemColors.Control;
            this.pnlButtonAdd.Controls.Add(this.btnAdd);
            this.pnlButtonAdd.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlButtonAdd.ForeColor = System.Drawing.Color.Black;
            this.pnlButtonAdd.Location = new System.Drawing.Point(3, 29);
            this.pnlButtonAdd.Name = "pnlButtonAdd";
            this.pnlButtonAdd.Size = new System.Drawing.Size(161, 33);
            this.pnlButtonAdd.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::CarRepairShop.Properties.Resources.add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(-2, -4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 48);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvWarehouse
            // 
            this.dgvWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarehouse.Location = new System.Drawing.Point(162, -1);
            this.dgvWarehouse.Name = "dgvWarehouse";
            this.dgvWarehouse.ReadOnly = true;
            this.dgvWarehouse.RowHeadersVisible = false;
            this.dgvWarehouse.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWarehouse.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWarehouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWarehouse.Size = new System.Drawing.Size(605, 363);
            this.dgvWarehouse.TabIndex = 13;
            // 
            // lblActions
            // 
            this.lblActions.AutoSize = true;
            this.lblActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblActions.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblActions.Location = new System.Drawing.Point(3, 8);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(69, 18);
            this.lblActions.TabIndex = 14;
            this.lblActions.Text = "Actions:";
            // 
            // lblFilters
            // 
            this.lblFilters.AutoSize = true;
            this.lblFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFilters.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblFilters.Location = new System.Drawing.Point(3, 143);
            this.lblFilters.Name = "lblFilters";
            this.lblFilters.Size = new System.Drawing.Size(60, 18);
            this.lblFilters.TabIndex = 15;
            this.lblFilters.Text = "Filters:";
            // 
            // gbName
            // 
            this.gbName.Controls.Add(this.txtName);
            this.gbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbName.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbName.Location = new System.Drawing.Point(6, 173);
            this.gbName.Name = "gbName";
            this.gbName.Size = new System.Drawing.Size(150, 58);
            this.gbName.TabIndex = 16;
            this.gbName.TabStop = false;
            this.gbName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 24);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // gbMaterialType
            // 
            this.gbMaterialType.Controls.Add(this.cmbMaterialType);
            this.gbMaterialType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbMaterialType.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbMaterialType.Location = new System.Drawing.Point(6, 235);
            this.gbMaterialType.Name = "gbMaterialType";
            this.gbMaterialType.Size = new System.Drawing.Size(150, 58);
            this.gbMaterialType.TabIndex = 17;
            this.gbMaterialType.TabStop = false;
            this.gbMaterialType.Text = "Material type:";
            // 
            // cmbMaterialType
            // 
            this.cmbMaterialType.FormattingEnabled = true;
            this.cmbMaterialType.Location = new System.Drawing.Point(7, 23);
            this.cmbMaterialType.Name = "cmbMaterialType";
            this.cmbMaterialType.Size = new System.Drawing.Size(137, 26);
            this.cmbMaterialType.TabIndex = 0;
            this.cmbMaterialType.SelectedIndexChanged += new System.EventHandler(this.cmbMaterialType_SelectedIndexChanged);
            // 
            // pnlSeparator
            // 
            this.pnlSeparator.BackColor = System.Drawing.Color.Coral;
            this.pnlSeparator.Location = new System.Drawing.Point(0, 134);
            this.pnlSeparator.Name = "pnlSeparator";
            this.pnlSeparator.Size = new System.Drawing.Size(163, 2);
            this.pnlSeparator.TabIndex = 18;
            // 
            // Debounce
            // 
            this.Debounce.Interval = 700;
            this.Debounce.Tick += new System.EventHandler(this.Debounce_Tick);
            // 
            // WarehouseTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSeparator);
            this.Controls.Add(this.gbMaterialType);
            this.Controls.Add(this.gbName);
            this.Controls.Add(this.lblFilters);
            this.Controls.Add(this.lblActions);
            this.Controls.Add(this.dgvWarehouse);
            this.Controls.Add(this.pnlButtonDelete);
            this.Controls.Add(this.pnlButtonEdit);
            this.Controls.Add(this.pnlButtonAdd);
            this.Name = "WarehouseTab";
            this.Size = new System.Drawing.Size(767, 362);
            this.Load += new System.EventHandler(this.WarehouseTab_Load);
            this.pnlButtonDelete.ResumeLayout(false);
            this.pnlButtonEdit.ResumeLayout(false);
            this.pnlButtonAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouse)).EndInit();
            this.gbName.ResumeLayout(false);
            this.gbName.PerformLayout();
            this.gbMaterialType.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
