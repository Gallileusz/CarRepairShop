namespace CarRepairShop.Utilities.ComboboxForm.View
{
    partial class ComboboxForm
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
            cmb = new System.Windows.Forms.ComboBox();
            btnOK = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // cmb
            // 
            cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmb.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
            cmb.ForeColor = System.Drawing.Color.SteelBlue;
            cmb.FormattingEnabled = true;
            cmb.Location = new System.Drawing.Point(26, 18);
            cmb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmb.Name = "cmb";
            cmb.Size = new System.Drawing.Size(268, 26);
            cmb.TabIndex = 0;
            // 
            // btnOK
            // 
            btnOK.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            btnOK.Location = new System.Drawing.Point(119, 55);
            btnOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(88, 24);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // ComboboxForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(326, 94);
            Controls.Add(btnOK);
            Controls.Add(cmb);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ComboboxForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            FormClosing += ComboboxForm_FormClosing;
            Load += ComboboxForm_Load;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Button btnOK;
    }
}