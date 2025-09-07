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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsTab));
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
            resources.ApplyResources(gbAppSettings, "gbAppSettings");
            gbAppSettings.ForeColor = System.Drawing.Color.SteelBlue;
            gbAppSettings.Name = "gbAppSettings";
            gbAppSettings.TabStop = false;
            // 
            // btnLanguage
            // 
            resources.ApplyResources(btnLanguage, "btnLanguage");
            btnLanguage.Name = "btnLanguage";
            btnLanguage.UseVisualStyleBackColor = true;
            btnLanguage.Click += btnLanguage_Click;
            // 
            // gbUserSettings
            // 
            gbUserSettings.Controls.Add(btnChangeCurrentUserPassword);
            resources.ApplyResources(gbUserSettings, "gbUserSettings");
            gbUserSettings.ForeColor = System.Drawing.Color.SteelBlue;
            gbUserSettings.Name = "gbUserSettings";
            gbUserSettings.TabStop = false;
            // 
            // btnChangeCurrentUserPassword
            // 
            resources.ApplyResources(btnChangeCurrentUserPassword, "btnChangeCurrentUserPassword");
            btnChangeCurrentUserPassword.Name = "btnChangeCurrentUserPassword";
            btnChangeCurrentUserPassword.UseVisualStyleBackColor = true;
            btnChangeCurrentUserPassword.Click += btnChangeCurrentUserPassword_Click;
            // 
            // SettingsTab
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gbUserSettings);
            Controls.Add(gbAppSettings);
            Name = "SettingsTab";
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
