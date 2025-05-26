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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaterialName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddMaterialType = new System.Windows.Forms.Button();
            this.cmbMaterialTypes = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnReduceQuantity = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnIncrementQuantity = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaterialName);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Material name:";
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMaterialName.Location = new System.Drawing.Point(6, 19);
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.Size = new System.Drawing.Size(288, 24);
            this.txtMaterialName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddMaterialType);
            this.groupBox2.Controls.Add(this.cmbMaterialTypes);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 54);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Material type";
            // 
            // btnAddMaterialType
            // 
            this.btnAddMaterialType.Location = new System.Drawing.Point(214, 10);
            this.btnAddMaterialType.Name = "btnAddMaterialType";
            this.btnAddMaterialType.Size = new System.Drawing.Size(80, 38);
            this.btnAddMaterialType.TabIndex = 1;
            this.btnAddMaterialType.Text = "Add new material type";
            this.btnAddMaterialType.UseVisualStyleBackColor = true;
            this.btnAddMaterialType.Click += new System.EventHandler(this.btnAddMaterialType_Click);
            // 
            // cmbMaterialTypes
            // 
            this.cmbMaterialTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbMaterialTypes.FormattingEnabled = true;
            this.cmbMaterialTypes.Location = new System.Drawing.Point(6, 19);
            this.cmbMaterialTypes.Name = "cmbMaterialTypes";
            this.cmbMaterialTypes.Size = new System.Drawing.Size(188, 26);
            this.cmbMaterialTypes.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnReduceQuantity);
            this.groupBox3.Controls.Add(this.txtQuantity);
            this.groupBox3.Controls.Add(this.btnIncrementQuantity);
            this.groupBox3.Location = new System.Drawing.Point(12, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 57);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quantity";
            // 
            // btnReduceQuantity
            // 
            this.btnReduceQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReduceQuantity.Location = new System.Drawing.Point(264, 17);
            this.btnReduceQuantity.Name = "btnReduceQuantity";
            this.btnReduceQuantity.Size = new System.Drawing.Size(30, 30);
            this.btnReduceQuantity.TabIndex = 2;
            this.btnReduceQuantity.Text = "↓";
            this.btnReduceQuantity.UseVisualStyleBackColor = true;
            this.btnReduceQuantity.Click += new System.EventHandler(this.btnReduceQuantity_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtQuantity.Location = new System.Drawing.Point(6, 19);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(224, 27);
            this.txtQuantity.TabIndex = 0;
            this.txtQuantity.Text = "0";
            // 
            // btnIncrementQuantity
            // 
            this.btnIncrementQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIncrementQuantity.Location = new System.Drawing.Point(236, 17);
            this.btnIncrementQuantity.Name = "btnIncrementQuantity";
            this.btnIncrementQuantity.Size = new System.Drawing.Size(30, 30);
            this.btnIncrementQuantity.TabIndex = 1;
            this.btnIncrementQuantity.Text = "↑";
            this.btnIncrementQuantity.UseVisualStyleBackColor = true;
            this.btnIncrementQuantity.Click += new System.EventHandler(this.btnIncrementQuantity_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(78, 217);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(178, 217);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ConsumableMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 252);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsumableMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                       ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsumableMaterial_FormClosing);
            this.Load += new System.EventHandler(this.ConsumableMaterial_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnAddMaterialType;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}