namespace CarRepairShop.Warehouse.MaterialsTypesList.View
{
    partial class MaterialsTypesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialsTypesList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            dgv = new System.Windows.Forms.DataGridView();
            pnlButtonDelete = new System.Windows.Forms.Panel();
            btnDelete = new System.Windows.Forms.Button();
            pnlButtonEdit = new System.Windows.Forms.Panel();
            btnEdit = new System.Windows.Forms.Button();
            pnlButtonAdd = new System.Windows.Forms.Panel();
            btnAdd = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            pnlButtonDelete.SuspendLayout();
            pnlButtonEdit.SuspendLayout();
            pnlButtonAdd.SuspendLayout();
            SuspendLayout();
            // 
            // dgv
            // 
            resources.ApplyResources(dgv, "dgv");
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle4;
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            // 
            // pnlButtonDelete
            // 
            resources.ApplyResources(pnlButtonDelete, "pnlButtonDelete");
            pnlButtonDelete.BackColor = System.Drawing.SystemColors.Control;
            pnlButtonDelete.Controls.Add(btnDelete);
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
            resources.ApplyResources(pnlButtonEdit, "pnlButtonEdit");
            pnlButtonEdit.BackColor = System.Drawing.SystemColors.Control;
            pnlButtonEdit.Controls.Add(btnEdit);
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
            resources.ApplyResources(pnlButtonAdd, "pnlButtonAdd");
            pnlButtonAdd.BackColor = System.Drawing.SystemColors.Control;
            pnlButtonAdd.Controls.Add(btnAdd);
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
            // btnClose
            // 
            resources.ApplyResources(btnClose, "btnClose");
            btnClose.Name = "btnClose";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // MaterialsTypesList
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnClose);
            Controls.Add(pnlButtonDelete);
            Controls.Add(pnlButtonEdit);
            Controls.Add(pnlButtonAdd);
            Controls.Add(dgv);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MaterialsTypesList";
            FormClosing += MaterialsTypesList_FormClosing;
            Load += MaterialsTypesList_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            pnlButtonDelete.ResumeLayout(false);
            pnlButtonEdit.ResumeLayout(false);
            pnlButtonAdd.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel pnlButtonDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlButtonEdit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel pnlButtonAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}