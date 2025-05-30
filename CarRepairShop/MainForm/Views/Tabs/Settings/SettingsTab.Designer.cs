namespace CarRepairShop.MainForm.Views.Tabs.Settings
{
    partial class SettingsTab
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
            this.gbAppSettings = new System.Windows.Forms.GroupBox();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.btnChangeDefaultPassword = new System.Windows.Forms.Button();
            this.gbUserSettings = new System.Windows.Forms.GroupBox();
            this.btnChangeCurrentUserPassword = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbAppSettings.SuspendLayout();
            this.gbUserSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAppSettings
            // 
            this.gbAppSettings.Controls.Add(this.btnLanguage);
            this.gbAppSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbAppSettings.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbAppSettings.Location = new System.Drawing.Point(3, 3);
            this.gbAppSettings.Name = "gbAppSettings";
            this.gbAppSettings.Size = new System.Drawing.Size(258, 419);
            this.gbAppSettings.TabIndex = 35;
            this.gbAppSettings.TabStop = false;
            this.gbAppSettings.Text = "App settings:";
            // 
            // btnLanguage
            // 
            this.btnLanguage.Location = new System.Drawing.Point(6, 34);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(246, 37);
            this.btnLanguage.TabIndex = 0;
            this.btnLanguage.Text = "Language";
            this.btnLanguage.UseVisualStyleBackColor = true;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // btnChangeDefaultPassword
            // 
            this.btnChangeDefaultPassword.Location = new System.Drawing.Point(6, 31);
            this.btnChangeDefaultPassword.Name = "btnChangeDefaultPassword";
            this.btnChangeDefaultPassword.Size = new System.Drawing.Size(246, 37);
            this.btnChangeDefaultPassword.TabIndex = 1;
            this.btnChangeDefaultPassword.Text = "Default user password";
            this.btnChangeDefaultPassword.UseVisualStyleBackColor = true;
            this.btnChangeDefaultPassword.Click += new System.EventHandler(this.btnChangeDefaultPassword_Click);
            // 
            // gbUserSettings
            // 
            this.gbUserSettings.Controls.Add(this.btnChangeCurrentUserPassword);
            this.gbUserSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbUserSettings.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbUserSettings.Location = new System.Drawing.Point(276, 3);
            this.gbUserSettings.Name = "gbUserSettings";
            this.gbUserSettings.Size = new System.Drawing.Size(258, 419);
            this.gbUserSettings.TabIndex = 36;
            this.gbUserSettings.TabStop = false;
            this.gbUserSettings.Text = "User settings:";
            // 
            // btnChangeCurrentUserPassword
            // 
            this.btnChangeCurrentUserPassword.Location = new System.Drawing.Point(6, 34);
            this.btnChangeCurrentUserPassword.Name = "btnChangeCurrentUserPassword";
            this.btnChangeCurrentUserPassword.Size = new System.Drawing.Size(246, 37);
            this.btnChangeCurrentUserPassword.TabIndex = 2;
            this.btnChangeCurrentUserPassword.Text = "Change my password";
            this.btnChangeCurrentUserPassword.UseVisualStyleBackColor = true;
            this.btnChangeCurrentUserPassword.Click += new System.EventHandler(this.btnChangeCurrentUserPassword_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChangeDefaultPassword);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(550, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 419);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Repair Shop settings:";
            // 
            // SettingsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbUserSettings);
            this.Controls.Add(this.gbAppSettings);
            this.Name = "SettingsTab";
            this.Size = new System.Drawing.Size(931, 425);
            this.Load += new System.EventHandler(this.SettingsTab_Load);
            this.gbAppSettings.ResumeLayout(false);
            this.gbUserSettings.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAppSettings;
        private System.Windows.Forms.Button btnChangeDefaultPassword;
        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.GroupBox gbUserSettings;
        private System.Windows.Forms.Button btnChangeCurrentUserPassword;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
