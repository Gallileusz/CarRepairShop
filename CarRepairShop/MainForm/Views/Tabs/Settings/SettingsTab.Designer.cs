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
            gbAppSettings = new System.Windows.Forms.GroupBox();
            btnLanguage = new System.Windows.Forms.Button();
            gbUserSettings = new System.Windows.Forms.GroupBox();
            btnChangeCurrentUserPassword = new System.Windows.Forms.Button();
            gbAppSettings.SuspendLayout();
            gbUserSettings.SuspendLayout();
            SuspendLayout();
            // 
            // gbAppSettings
            // 
            gbAppSettings.Controls.Add(btnLanguage);
            gbAppSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            gbAppSettings.ForeColor = System.Drawing.Color.SteelBlue;
            gbAppSettings.Location = new System.Drawing.Point(4, 3);
            gbAppSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbAppSettings.Name = "gbAppSettings";
            gbAppSettings.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbAppSettings.Size = new System.Drawing.Size(301, 483);
            gbAppSettings.TabIndex = 35;
            gbAppSettings.TabStop = false;
            gbAppSettings.Text = "App settings:";
            // 
            // btnLanguage
            // 
            btnLanguage.Location = new System.Drawing.Point(7, 39);
            btnLanguage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLanguage.Name = "btnLanguage";
            btnLanguage.Size = new System.Drawing.Size(287, 43);
            btnLanguage.TabIndex = 0;
            btnLanguage.Text = "Language";
            btnLanguage.UseVisualStyleBackColor = true;
            btnLanguage.Click += btnLanguage_Click;
            // 
            // gbUserSettings
            // 
            gbUserSettings.Controls.Add(btnChangeCurrentUserPassword);
            gbUserSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            gbUserSettings.ForeColor = System.Drawing.Color.SteelBlue;
            gbUserSettings.Location = new System.Drawing.Point(322, 3);
            gbUserSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbUserSettings.Name = "gbUserSettings";
            gbUserSettings.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbUserSettings.Size = new System.Drawing.Size(301, 483);
            gbUserSettings.TabIndex = 36;
            gbUserSettings.TabStop = false;
            gbUserSettings.Text = "User settings:";
            // 
            // btnChangeCurrentUserPassword
            // 
            btnChangeCurrentUserPassword.Location = new System.Drawing.Point(7, 39);
            btnChangeCurrentUserPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnChangeCurrentUserPassword.Name = "btnChangeCurrentUserPassword";
            btnChangeCurrentUserPassword.Size = new System.Drawing.Size(287, 43);
            btnChangeCurrentUserPassword.TabIndex = 2;
            btnChangeCurrentUserPassword.Text = "Change my password";
            btnChangeCurrentUserPassword.UseVisualStyleBackColor = true;
            btnChangeCurrentUserPassword.Click += btnChangeCurrentUserPassword_Click;
            // 
            // SettingsTab
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gbUserSettings);
            Controls.Add(gbAppSettings);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "SettingsTab";
            Size = new System.Drawing.Size(1086, 490);
            gbAppSettings.ResumeLayout(false);
            gbUserSettings.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAppSettings;
        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.GroupBox gbUserSettings;
        private System.Windows.Forms.Button btnChangeCurrentUserPassword;
    }
}
