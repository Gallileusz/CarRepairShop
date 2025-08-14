using System.Windows.Forms;

namespace CarRepairShop.MainForm.Views.Tabs.CRM
{
    partial class UsersTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersTab));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel2 = new Panel();
            btnDelete = new Button();
            panel1 = new Panel();
            btnEdit = new Button();
            panel5 = new Panel();
            btnAdd = new Button();
            dgvUsers = new DataGridView();
            pnlSeparator = new Panel();
            gbName = new GroupBox();
            txtName = new TextBox();
            lblActions = new Label();
            lblFilters = new Label();
            groupBox1 = new GroupBox();
            txtSurname = new TextBox();
            Debounce = new Timer(components);
            panel3 = new Panel();
            btnPermissions = new Button();
            panel4 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            gbName.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
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
            // dgvUsers
            // 
            resources.ApplyResources(dgvUsers, "dgvUsers");
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // pnlSeparator
            // 
            pnlSeparator.BackColor = System.Drawing.Color.Coral;
            resources.ApplyResources(pnlSeparator, "pnlSeparator");
            pnlSeparator.Name = "pnlSeparator";
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
            // Debounce
            // 
            Debounce.Interval = 500;
            Debounce.Tick += Debounce_Tick;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.SystemColors.Control;
            panel3.Controls.Add(btnPermissions);
            resources.ApplyResources(panel3, "panel3");
            panel3.ForeColor = System.Drawing.Color.Black;
            panel3.Name = "panel3";
            // 
            // btnPermissions
            // 
            resources.ApplyResources(btnPermissions, "btnPermissions");
            btnPermissions.Image = Properties.Resources.edit;
            btnPermissions.Name = "btnPermissions";
            btnPermissions.UseVisualStyleBackColor = true;
            btnPermissions.Click += btnPermissions_Click;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.Coral;
            resources.ApplyResources(panel4, "panel4");
            panel4.Name = "panel4";
            // 
            // UsersTab
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(groupBox1);
            Controls.Add(lblFilters);
            Controls.Add(lblActions);
            Controls.Add(pnlSeparator);
            Controls.Add(gbName);
            Controls.Add(dgvUsers);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Name = "UsersTab";
            Load += UsersTab_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            gbName.ResumeLayout(false);
            gbName.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel pnlSeparator;
        private System.Windows.Forms.GroupBox gbName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblActions;
        private System.Windows.Forms.Label lblFilters;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Timer Debounce;
        private Panel panel3;
        private Button btnPermissions;
        private Panel panel4;
    }
}
