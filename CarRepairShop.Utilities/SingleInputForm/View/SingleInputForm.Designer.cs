namespace CarRepairShop.Utilities.SingleInputForm.View
{
    partial class SingleInputForm
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
            txt = new System.Windows.Forms.TextBox();
            btnOK = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txt
            // 
            txt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            txt.ForeColor = System.Drawing.Color.SteelBlue;
            txt.Location = new System.Drawing.Point(14, 17);
            txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt.Name = "txt";
            txt.Size = new System.Drawing.Size(326, 27);
            txt.TabIndex = 0;
            // 
            // btnOK
            // 
            btnOK.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            btnOK.Location = new System.Drawing.Point(134, 53);
            btnOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(88, 23);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // SingleInputForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(355, 88);
            Controls.Add(btnOK);
            Controls.Add(txt);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SingleInputForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += SingleInputForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btnOK;
    }
}