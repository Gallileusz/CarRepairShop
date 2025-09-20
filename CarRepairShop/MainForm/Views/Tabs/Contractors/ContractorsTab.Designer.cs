namespace CarRepairShop.MainForm.Views.Tabs.ContractorsTab
{
    partial class ContractorsTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractorsTab));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            pnlSeparator = new System.Windows.Forms.Panel();
            lblActions = new System.Windows.Forms.Label();
            pnlButtonDelete = new System.Windows.Forms.Panel();
            btnDeleteContractor = new System.Windows.Forms.Button();
            pnlButtonEdit = new System.Windows.Forms.Panel();
            btnEditContractor = new System.Windows.Forms.Button();
            pnlButtonAdd = new System.Windows.Forms.Panel();
            btnAddContractor = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            btnDeleteVehicle = new System.Windows.Forms.Button();
            panel4 = new System.Windows.Forms.Panel();
            btnEditVehicle = new System.Windows.Forms.Button();
            panel5 = new System.Windows.Forms.Panel();
            btnAddVehicle = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            gbCars = new System.Windows.Forms.GroupBox();
            dgvCars = new System.Windows.Forms.DataGridView();
            gbContractors = new System.Windows.Forms.GroupBox();
            dgvContractors = new System.Windows.Forms.DataGridView();
            gbName = new System.Windows.Forms.GroupBox();
            txtName = new System.Windows.Forms.TextBox();
            lblFilters = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            txtSurname = new System.Windows.Forms.TextBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            txtModelName = new System.Windows.Forms.TextBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            txtBrandName = new System.Windows.Forms.TextBox();
            Debounce = new System.Windows.Forms.Timer(components);
            groupBox5 = new System.Windows.Forms.GroupBox();
            panel1 = new System.Windows.Forms.Panel();
            btnFuelTypes = new System.Windows.Forms.Button();
            panel6 = new System.Windows.Forms.Panel();
            pnlButtonDelete.SuspendLayout();
            pnlButtonEdit.SuspendLayout();
            pnlButtonAdd.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            gbCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            gbContractors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContractors).BeginInit();
            gbName.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
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
            pnlButtonDelete.Controls.Add(btnDeleteContractor);
            resources.ApplyResources(pnlButtonDelete, "pnlButtonDelete");
            pnlButtonDelete.ForeColor = System.Drawing.Color.Black;
            pnlButtonDelete.Name = "pnlButtonDelete";
            // 
            // btnDeleteContractor
            // 
            resources.ApplyResources(btnDeleteContractor, "btnDeleteContractor");
            btnDeleteContractor.ForeColor = System.Drawing.Color.SteelBlue;
            btnDeleteContractor.Image = Properties.Resources.delete;
            btnDeleteContractor.Name = "btnDeleteContractor";
            btnDeleteContractor.UseVisualStyleBackColor = true;
            btnDeleteContractor.Click += btnDeleteContractor_Click;
            // 
            // pnlButtonEdit
            // 
            pnlButtonEdit.BackColor = System.Drawing.SystemColors.Control;
            pnlButtonEdit.Controls.Add(btnEditContractor);
            resources.ApplyResources(pnlButtonEdit, "pnlButtonEdit");
            pnlButtonEdit.ForeColor = System.Drawing.Color.Black;
            pnlButtonEdit.Name = "pnlButtonEdit";
            // 
            // btnEditContractor
            // 
            resources.ApplyResources(btnEditContractor, "btnEditContractor");
            btnEditContractor.ForeColor = System.Drawing.Color.SteelBlue;
            btnEditContractor.Image = Properties.Resources.edit;
            btnEditContractor.Name = "btnEditContractor";
            btnEditContractor.UseVisualStyleBackColor = true;
            btnEditContractor.Click += btnEditContractor_Click;
            // 
            // pnlButtonAdd
            // 
            pnlButtonAdd.BackColor = System.Drawing.SystemColors.Control;
            pnlButtonAdd.Controls.Add(btnAddContractor);
            resources.ApplyResources(pnlButtonAdd, "pnlButtonAdd");
            pnlButtonAdd.ForeColor = System.Drawing.Color.Black;
            pnlButtonAdd.Name = "pnlButtonAdd";
            // 
            // btnAddContractor
            // 
            resources.ApplyResources(btnAddContractor, "btnAddContractor");
            btnAddContractor.ForeColor = System.Drawing.Color.SteelBlue;
            btnAddContractor.Image = Properties.Resources.add;
            btnAddContractor.Name = "btnAddContractor";
            btnAddContractor.UseVisualStyleBackColor = true;
            btnAddContractor.Click += btnAddContractor_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Coral;
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = System.Drawing.Color.Coral;
            label1.Name = "label1";
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.SystemColors.Control;
            panel3.Controls.Add(btnDeleteVehicle);
            resources.ApplyResources(panel3, "panel3");
            panel3.ForeColor = System.Drawing.Color.Black;
            panel3.Name = "panel3";
            // 
            // btnDeleteVehicle
            // 
            resources.ApplyResources(btnDeleteVehicle, "btnDeleteVehicle");
            btnDeleteVehicle.ForeColor = System.Drawing.Color.Coral;
            btnDeleteVehicle.Image = Properties.Resources.delete;
            btnDeleteVehicle.Name = "btnDeleteVehicle";
            btnDeleteVehicle.UseVisualStyleBackColor = true;
            btnDeleteVehicle.Click += btnDeleteVehicle_Click;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.SystemColors.Control;
            panel4.Controls.Add(btnEditVehicle);
            resources.ApplyResources(panel4, "panel4");
            panel4.ForeColor = System.Drawing.Color.Black;
            panel4.Name = "panel4";
            // 
            // btnEditVehicle
            // 
            resources.ApplyResources(btnEditVehicle, "btnEditVehicle");
            btnEditVehicle.ForeColor = System.Drawing.Color.Coral;
            btnEditVehicle.Image = Properties.Resources.edit;
            btnEditVehicle.Name = "btnEditVehicle";
            btnEditVehicle.UseVisualStyleBackColor = true;
            btnEditVehicle.Click += btnEditVehicle_Click;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.SystemColors.Control;
            panel5.Controls.Add(btnAddVehicle);
            resources.ApplyResources(panel5, "panel5");
            panel5.ForeColor = System.Drawing.Color.Black;
            panel5.Name = "panel5";
            // 
            // btnAddVehicle
            // 
            resources.ApplyResources(btnAddVehicle, "btnAddVehicle");
            btnAddVehicle.ForeColor = System.Drawing.Color.Coral;
            btnAddVehicle.Image = Properties.Resources.add;
            btnAddVehicle.Name = "btnAddVehicle";
            btnAddVehicle.UseVisualStyleBackColor = true;
            btnAddVehicle.Click += btnAddVehicle_Click;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(gbCars, 0, 2);
            tableLayoutPanel1.Controls.Add(gbContractors, 0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // gbCars
            // 
            gbCars.Controls.Add(dgvCars);
            resources.ApplyResources(gbCars, "gbCars");
            gbCars.ForeColor = System.Drawing.Color.Coral;
            gbCars.Name = "gbCars";
            gbCars.TabStop = false;
            // 
            // dgvCars
            // 
            resources.ApplyResources(dgvCars, "dgvCars");
            dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvCars.DefaultCellStyle = dataGridViewCellStyle6;
            dgvCars.MultiSelect = false;
            dgvCars.Name = "dgvCars";
            dgvCars.ReadOnly = true;
            dgvCars.RowHeadersVisible = false;
            dgvCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // gbContractors
            // 
            gbContractors.Controls.Add(dgvContractors);
            resources.ApplyResources(gbContractors, "gbContractors");
            gbContractors.ForeColor = System.Drawing.Color.SteelBlue;
            gbContractors.Name = "gbContractors";
            gbContractors.TabStop = false;
            // 
            // dgvContractors
            // 
            resources.ApplyResources(dgvContractors, "dgvContractors");
            dgvContractors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvContractors.DefaultCellStyle = dataGridViewCellStyle5;
            dgvContractors.MultiSelect = false;
            dgvContractors.Name = "dgvContractors";
            dgvContractors.ReadOnly = true;
            dgvContractors.RowHeadersVisible = false;
            dgvContractors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvContractors.CellClick += dgvContractors_CellClick;
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
            // lblFilters
            // 
            resources.ApplyResources(lblFilters, "lblFilters");
            lblFilters.ForeColor = System.Drawing.Color.Black;
            lblFilters.Name = "lblFilters";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSurname);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // txtSurname
            // 
            resources.ApplyResources(txtSurname, "txtSurname");
            txtSurname.Name = "txtSurname";
            txtSurname.TextChanged += txtSurname_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtModelName);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.ForeColor = System.Drawing.Color.Coral;
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // txtModelName
            // 
            resources.ApplyResources(txtModelName, "txtModelName");
            txtModelName.Name = "txtModelName";
            txtModelName.TextChanged += txtModelName_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtBrandName);
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.ForeColor = System.Drawing.Color.Coral;
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            // 
            // txtBrandName
            // 
            resources.ApplyResources(txtBrandName, "txtBrandName");
            txtBrandName.Name = "txtBrandName";
            txtBrandName.TextChanged += txtBrandName_TextChanged;
            // 
            // Debounce
            // 
            Debounce.Interval = 500;
            Debounce.Tick += Debounce_Tick;
            // 
            // groupBox5
            // 
            resources.ApplyResources(groupBox5, "groupBox5");
            groupBox5.ForeColor = System.Drawing.Color.Coral;
            groupBox5.Name = "groupBox5";
            groupBox5.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.Control;
            panel1.Controls.Add(btnFuelTypes);
            resources.ApplyResources(panel1, "panel1");
            panel1.ForeColor = System.Drawing.Color.Black;
            panel1.Name = "panel1";
            // 
            // btnFuelTypes
            // 
            resources.ApplyResources(btnFuelTypes, "btnFuelTypes");
            btnFuelTypes.ForeColor = System.Drawing.Color.Black;
            btnFuelTypes.Image = Properties.Resources.warehouse;
            btnFuelTypes.Name = "btnFuelTypes";
            btnFuelTypes.UseVisualStyleBackColor = true;
            btnFuelTypes.Click += btnFuelTypes_Click;
            // 
            // panel6
            // 
            panel6.BackColor = System.Drawing.Color.Coral;
            resources.ApplyResources(panel6, "panel6");
            panel6.Name = "panel6";
            // 
            // ContractorsTab
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel6);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(lblFilters);
            Controls.Add(gbName);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(pnlSeparator);
            Controls.Add(lblActions);
            Controls.Add(pnlButtonDelete);
            Controls.Add(pnlButtonEdit);
            Controls.Add(pnlButtonAdd);
            Name = "ContractorsTab";
            Load += ContractorsTab_Load;
            pnlButtonDelete.ResumeLayout(false);
            pnlButtonEdit.ResumeLayout(false);
            pnlButtonAdd.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            gbCars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            gbContractors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvContractors).EndInit();
            gbName.ResumeLayout(false);
            gbName.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlSeparator;
        private System.Windows.Forms.Label lblActions;
        private System.Windows.Forms.Panel pnlButtonDelete;
        private System.Windows.Forms.Button btnDeleteContractor;
        private System.Windows.Forms.Panel pnlButtonEdit;
        private System.Windows.Forms.Button btnEditContractor;
        private System.Windows.Forms.Panel pnlButtonAdd;
        private System.Windows.Forms.Button btnAddContractor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDeleteVehicle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnEditVehicle;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbContractors;
        private System.Windows.Forms.DataGridView dgvContractors;
        private System.Windows.Forms.GroupBox gbName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblFilters;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.Timer Debounce;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox gbCars;
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFuelTypes;
        private System.Windows.Forms.Panel panel6;
    }
}
