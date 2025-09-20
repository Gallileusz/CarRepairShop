namespace CarRepairShop.Contractors.FuelTypesList.View
{
    partial class FuelTypesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuelTypesList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            btnClose = new System.Windows.Forms.Button();
            pnlButtonDelete = new System.Windows.Forms.Panel();
            btnDelete = new System.Windows.Forms.Button();
            pnlButtonEdit = new System.Windows.Forms.Panel();
            btnEdit = new System.Windows.Forms.Button();
            pnlButtonAdd = new System.Windows.Forms.Panel();
            btnAdd = new System.Windows.Forms.Button();
            dgv = new System.Windows.Forms.DataGridView();
            pnlButtonDelete.SuspendLayout();
            pnlButtonEdit.SuspendLayout();
            pnlButtonAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            resources.ApplyResources(btnClose, "btnClose");
            btnClose.Name = "btnClose";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
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
            // dgv
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(dgv, "dgv");
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            // 
            // FuelTypesList
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnClose);
            Controls.Add(pnlButtonDelete);
            Controls.Add(pnlButtonEdit);
            Controls.Add(pnlButtonAdd);
            Controls.Add(dgv);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "FuelTypesList";
            Load += FuelTypesList_Load;
            pnlButtonDelete.ResumeLayout(false);
            pnlButtonEdit.ResumeLayout(false);
            pnlButtonAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlButtonDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlButtonEdit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel pnlButtonAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgv;
    }
}