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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSeparator = new System.Windows.Forms.Panel();
            this.lblActions = new System.Windows.Forms.Label();
            this.pnlButtonDelete = new System.Windows.Forms.Panel();
            this.btnDeleteContractor = new System.Windows.Forms.Button();
            this.pnlButtonEdit = new System.Windows.Forms.Panel();
            this.btnEditContractor = new System.Windows.Forms.Button();
            this.pnlButtonAdd = new System.Windows.Forms.Panel();
            this.btnAddContractor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteVehicle = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEditVehicle = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbCars = new System.Windows.Forms.GroupBox();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.gbContractors = new System.Windows.Forms.GroupBox();
            this.dgvContractors = new System.Windows.Forms.DataGridView();
            this.gbName = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblFilters = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.Debounce = new System.Windows.Forms.Timer(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pnlButtonDelete.SuspendLayout();
            this.pnlButtonEdit.SuspendLayout();
            this.pnlButtonAdd.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.gbContractors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractors)).BeginInit();
            this.gbName.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSeparator
            // 
            this.pnlSeparator.BackColor = System.Drawing.Color.Coral;
            this.pnlSeparator.Location = new System.Drawing.Point(0, 130);
            this.pnlSeparator.Name = "pnlSeparator";
            this.pnlSeparator.Size = new System.Drawing.Size(163, 2);
            this.pnlSeparator.TabIndex = 26;
            // 
            // lblActions
            // 
            this.lblActions.AutoSize = true;
            this.lblActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblActions.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblActions.Location = new System.Drawing.Point(3, 4);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(154, 18);
            this.lblActions.TabIndex = 22;
            this.lblActions.Text = "Contractor actions:";
            // 
            // pnlButtonDelete
            // 
            this.pnlButtonDelete.BackColor = System.Drawing.SystemColors.Control;
            this.pnlButtonDelete.Controls.Add(this.btnDeleteContractor);
            this.pnlButtonDelete.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlButtonDelete.ForeColor = System.Drawing.Color.Black;
            this.pnlButtonDelete.Location = new System.Drawing.Point(5, 91);
            this.pnlButtonDelete.Name = "pnlButtonDelete";
            this.pnlButtonDelete.Size = new System.Drawing.Size(159, 33);
            this.pnlButtonDelete.TabIndex = 21;
            // 
            // btnDeleteContractor
            // 
            this.btnDeleteContractor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteContractor.Image = global::CarRepairShop.Properties.Resources.delete;
            this.btnDeleteContractor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteContractor.Location = new System.Drawing.Point(-5, -8);
            this.btnDeleteContractor.Name = "btnDeleteContractor";
            this.btnDeleteContractor.Size = new System.Drawing.Size(168, 48);
            this.btnDeleteContractor.TabIndex = 0;
            this.btnDeleteContractor.Text = "Delete contractor";
            this.btnDeleteContractor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteContractor.UseVisualStyleBackColor = true;
            this.btnDeleteContractor.Click += new System.EventHandler(this.btnDeleteContractor_Click);
            // 
            // pnlButtonEdit
            // 
            this.pnlButtonEdit.BackColor = System.Drawing.SystemColors.Control;
            this.pnlButtonEdit.Controls.Add(this.btnEditContractor);
            this.pnlButtonEdit.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlButtonEdit.ForeColor = System.Drawing.Color.Black;
            this.pnlButtonEdit.Location = new System.Drawing.Point(4, 58);
            this.pnlButtonEdit.Name = "pnlButtonEdit";
            this.pnlButtonEdit.Size = new System.Drawing.Size(160, 33);
            this.pnlButtonEdit.TabIndex = 20;
            // 
            // btnEditContractor
            // 
            this.btnEditContractor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditContractor.Image = global::CarRepairShop.Properties.Resources.edit;
            this.btnEditContractor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditContractor.Location = new System.Drawing.Point(-4, -8);
            this.btnEditContractor.Name = "btnEditContractor";
            this.btnEditContractor.Size = new System.Drawing.Size(168, 48);
            this.btnEditContractor.TabIndex = 0;
            this.btnEditContractor.Text = "Edit contractor";
            this.btnEditContractor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditContractor.UseVisualStyleBackColor = true;
            this.btnEditContractor.Click += new System.EventHandler(this.btnEditContractor_Click);
            // 
            // pnlButtonAdd
            // 
            this.pnlButtonAdd.BackColor = System.Drawing.SystemColors.Control;
            this.pnlButtonAdd.Controls.Add(this.btnAddContractor);
            this.pnlButtonAdd.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlButtonAdd.ForeColor = System.Drawing.Color.Black;
            this.pnlButtonAdd.Location = new System.Drawing.Point(3, 25);
            this.pnlButtonAdd.Name = "pnlButtonAdd";
            this.pnlButtonAdd.Size = new System.Drawing.Size(161, 33);
            this.pnlButtonAdd.TabIndex = 19;
            // 
            // btnAddContractor
            // 
            this.btnAddContractor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddContractor.Image = global::CarRepairShop.Properties.Resources.add;
            this.btnAddContractor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddContractor.Location = new System.Drawing.Point(-2, -4);
            this.btnAddContractor.Name = "btnAddContractor";
            this.btnAddContractor.Size = new System.Drawing.Size(168, 48);
            this.btnAddContractor.TabIndex = 0;
            this.btnAddContractor.Text = "Add contractor";
            this.btnAddContractor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddContractor.UseVisualStyleBackColor = true;
            this.btnAddContractor.Click += new System.EventHandler(this.btnAddContractor_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Location = new System.Drawing.Point(3, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 2);
            this.panel2.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(6, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Car actions:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btnDeleteVehicle);
            this.panel3.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(7, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(159, 33);
            this.panel3.TabIndex = 30;
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteVehicle.Image = global::CarRepairShop.Properties.Resources.delete;
            this.btnDeleteVehicle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteVehicle.Location = new System.Drawing.Point(-5, -8);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Size = new System.Drawing.Size(166, 48);
            this.btnDeleteVehicle.TabIndex = 0;
            this.btnDeleteVehicle.Text = "Delete vehicle";
            this.btnDeleteVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteVehicle.UseVisualStyleBackColor = true;
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.btnEditVehicle);
            this.panel4.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(6, 193);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 33);
            this.panel4.TabIndex = 29;
            // 
            // btnEditVehicle
            // 
            this.btnEditVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditVehicle.Image = global::CarRepairShop.Properties.Resources.edit;
            this.btnEditVehicle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditVehicle.Location = new System.Drawing.Point(-4, -8);
            this.btnEditVehicle.Name = "btnEditVehicle";
            this.btnEditVehicle.Size = new System.Drawing.Size(168, 48);
            this.btnEditVehicle.TabIndex = 0;
            this.btnEditVehicle.Text = "Edit vehicle";
            this.btnEditVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditVehicle.UseVisualStyleBackColor = true;
            this.btnEditVehicle.Click += new System.EventHandler(this.btnEditVehicle_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.btnAddVehicle);
            this.panel5.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.ForeColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(5, 160);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(161, 33);
            this.panel5.TabIndex = 28;
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVehicle.Image = global::CarRepairShop.Properties.Resources.add;
            this.btnAddVehicle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddVehicle.Location = new System.Drawing.Point(-2, -4);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(167, 48);
            this.btnAddVehicle.TabIndex = 0;
            this.btnAddVehicle.Text = "Add vehicle";
            this.btnAddVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gbCars, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gbContractors, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(163, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(538, 672);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // gbCars
            // 
            this.gbCars.Controls.Add(this.dgvCars);
            this.gbCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbCars.ForeColor = System.Drawing.Color.Coral;
            this.gbCars.Location = new System.Drawing.Point(3, 341);
            this.gbCars.Name = "gbCars";
            this.gbCars.Size = new System.Drawing.Size(532, 328);
            this.gbCars.TabIndex = 37;
            this.gbCars.TabStop = false;
            this.gbCars.Text = "Contractor cars";
            // 
            // dgvCars
            // 
            this.dgvCars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCars.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCars.Location = new System.Drawing.Point(6, 23);
            this.dgvCars.MultiSelect = false;
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.ReadOnly = true;
            this.dgvCars.RowHeadersVisible = false;
            this.dgvCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCars.Size = new System.Drawing.Size(520, 299);
            this.dgvCars.TabIndex = 0;
            // 
            // gbContractors
            // 
            this.gbContractors.Controls.Add(this.dgvContractors);
            this.gbContractors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbContractors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbContractors.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbContractors.Location = new System.Drawing.Point(3, 3);
            this.gbContractors.Name = "gbContractors";
            this.gbContractors.Size = new System.Drawing.Size(532, 327);
            this.gbContractors.TabIndex = 25;
            this.gbContractors.TabStop = false;
            this.gbContractors.Text = "Contractor";
            // 
            // dgvContractors
            // 
            this.dgvContractors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContractors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContractors.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContractors.Location = new System.Drawing.Point(6, 23);
            this.dgvContractors.MultiSelect = false;
            this.dgvContractors.Name = "dgvContractors";
            this.dgvContractors.ReadOnly = true;
            this.dgvContractors.RowHeadersVisible = false;
            this.dgvContractors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContractors.Size = new System.Drawing.Size(520, 298);
            this.dgvContractors.TabIndex = 0;
            this.dgvContractors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContractors_CellClick);
            // 
            // gbName
            // 
            this.gbName.Controls.Add(this.txtName);
            this.gbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbName.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbName.Location = new System.Drawing.Point(7, 302);
            this.gbName.Name = "gbName";
            this.gbName.Size = new System.Drawing.Size(150, 58);
            this.gbName.TabIndex = 34;
            this.gbName.TabStop = false;
            this.gbName.Text = "Contractor name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 22);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblFilters
            // 
            this.lblFilters.AutoSize = true;
            this.lblFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFilters.ForeColor = System.Drawing.Color.Black;
            this.lblFilters.Location = new System.Drawing.Point(6, 275);
            this.lblFilters.Name = "lblFilters";
            this.lblFilters.Size = new System.Drawing.Size(60, 18);
            this.lblFilters.TabIndex = 35;
            this.lblFilters.Text = "Filters:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(7, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 58);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contractor surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(6, 19);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(138, 22);
            this.txtSurname.TabIndex = 0;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtModelName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.Color.Coral;
            this.groupBox2.Location = new System.Drawing.Point(7, 488);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 58);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Car model name:";
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(6, 19);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(138, 22);
            this.txtModelName.TabIndex = 0;
            this.txtModelName.TextChanged += new System.EventHandler(this.txtModelName_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBrandName);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.ForeColor = System.Drawing.Color.Coral;
            this.groupBox3.Location = new System.Drawing.Point(7, 427);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 58);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Car brand name:";
            // 
            // txtBrandName
            // 
            this.txtBrandName.Location = new System.Drawing.Point(6, 19);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(138, 22);
            this.txtBrandName.TabIndex = 0;
            this.txtBrandName.TextChanged += new System.EventHandler(this.txtBrandName_TextChanged);
            // 
            // Debounce
            // 
            this.Debounce.Interval = 500;
            this.Debounce.Tick += new System.EventHandler(this.Debounce_Tick);
            // 
            // groupBox5
            // 
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox5.ForeColor = System.Drawing.Color.Coral;
            this.groupBox5.Location = new System.Drawing.Point(3, 366);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(532, 1);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Contractor cars:";
            // 
            // ContractorsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFilters);
            this.Controls.Add(this.gbName);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnlSeparator);
            this.Controls.Add(this.lblActions);
            this.Controls.Add(this.pnlButtonDelete);
            this.Controls.Add(this.pnlButtonEdit);
            this.Controls.Add(this.pnlButtonAdd);
            this.Name = "ContractorsTab";
            this.Size = new System.Drawing.Size(701, 672);
            this.Load += new System.EventHandler(this.ContractorsTab_Load);
            this.pnlButtonDelete.ResumeLayout(false);
            this.pnlButtonEdit.ResumeLayout(false);
            this.pnlButtonAdd.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbCars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.gbContractors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractors)).EndInit();
            this.gbName.ResumeLayout(false);
            this.gbName.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
