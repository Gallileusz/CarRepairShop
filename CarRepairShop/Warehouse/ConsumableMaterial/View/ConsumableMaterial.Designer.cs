namespace CarRepairShop.ConsumableMaterialForm.View
{
    partial class ConsumableMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsumableMaterial));
            groupBox1 = new System.Windows.Forms.GroupBox();
            txtMaterialName = new System.Windows.Forms.TextBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            cmbMaterialTypes = new System.Windows.Forms.ComboBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            btnReduceQuantity = new System.Windows.Forms.Button();
            txtQuantity = new System.Windows.Forms.TextBox();
            btnIncrementQuantity = new System.Windows.Forms.Button();
            btnConfirm = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(txtMaterialName);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // txtMaterialName
            // 
            resources.ApplyResources(txtMaterialName, "txtMaterialName");
            txtMaterialName.Name = "txtMaterialName";
            // 
            // groupBox2
            // 
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Controls.Add(cmbMaterialTypes);
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // cmbMaterialTypes
            // 
            resources.ApplyResources(cmbMaterialTypes, "cmbMaterialTypes");
            cmbMaterialTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbMaterialTypes.FormattingEnabled = true;
            cmbMaterialTypes.Name = "cmbMaterialTypes";
            // 
            // groupBox3
            // 
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.Controls.Add(btnReduceQuantity);
            groupBox3.Controls.Add(txtQuantity);
            groupBox3.Controls.Add(btnIncrementQuantity);
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            // 
            // btnReduceQuantity
            // 
            resources.ApplyResources(btnReduceQuantity, "btnReduceQuantity");
            btnReduceQuantity.Name = "btnReduceQuantity";
            btnReduceQuantity.UseVisualStyleBackColor = true;
            btnReduceQuantity.Click += btnReduceQuantity_Click;
            // 
            // txtQuantity
            // 
            resources.ApplyResources(txtQuantity, "txtQuantity");
            txtQuantity.Name = "txtQuantity";
            txtQuantity.ReadOnly = true;
            // 
            // btnIncrementQuantity
            // 
            resources.ApplyResources(btnIncrementQuantity, "btnIncrementQuantity");
            btnIncrementQuantity.Name = "btnIncrementQuantity";
            btnIncrementQuantity.UseVisualStyleBackColor = true;
            btnIncrementQuantity.Click += btnIncrementQuantity_Click;
            // 
            // btnConfirm
            // 
            resources.ApplyResources(btnConfirm, "btnConfirm");
            btnConfirm.Name = "btnConfirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            resources.ApplyResources(btnCancel, "btnCancel");
            btnCancel.Name = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ConsumableMaterial
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConsumableMaterial";
            FormClosing += ConsumableMaterial_FormClosing;
            Load += ConsumableMaterial_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaterialName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbMaterialTypes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnReduceQuantity;
        private System.Windows.Forms.Button btnIncrementQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}