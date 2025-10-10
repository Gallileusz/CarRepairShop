namespace CarRepairShop.Authentication.ConnectionSettings.View
{
    partial class ConnectionSettingsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionSettingsView));
            rbProduction = new System.Windows.Forms.RadioButton();
            gbConnection = new System.Windows.Forms.GroupBox();
            lblDemoConnectionString = new System.Windows.Forms.Label();
            txtDemoConnectionString = new System.Windows.Forms.TextBox();
            rbDemo = new System.Windows.Forms.RadioButton();
            gbLanguage = new System.Windows.Forms.GroupBox();
            cmbLanguage = new System.Windows.Forms.ComboBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            gbConnection.SuspendLayout();
            gbLanguage.SuspendLayout();
            SuspendLayout();
            // 
            // rbProduction
            // 
            resources.ApplyResources(rbProduction, "rbProduction");
            rbProduction.Checked = true;
            rbProduction.Name = "rbProduction";
            rbProduction.TabStop = true;
            rbProduction.UseVisualStyleBackColor = true;
            rbProduction.CheckedChanged += rbProduction_CheckedChanged;
            // 
            // gbConnection
            // 
            gbConnection.Controls.Add(lblDemoConnectionString);
            gbConnection.Controls.Add(txtDemoConnectionString);
            gbConnection.Controls.Add(rbDemo);
            gbConnection.Controls.Add(rbProduction);
            resources.ApplyResources(gbConnection, "gbConnection");
            gbConnection.Name = "gbConnection";
            gbConnection.TabStop = false;
            // 
            // lblDemoConnectionString
            // 
            resources.ApplyResources(lblDemoConnectionString, "lblDemoConnectionString");
            lblDemoConnectionString.Name = "lblDemoConnectionString";
            // 
            // txtDemoConnectionString
            // 
            resources.ApplyResources(txtDemoConnectionString, "txtDemoConnectionString");
            txtDemoConnectionString.Name = "txtDemoConnectionString";
            // 
            // rbDemo
            // 
            resources.ApplyResources(rbDemo, "rbDemo");
            rbDemo.Name = "rbDemo";
            rbDemo.UseVisualStyleBackColor = true;
            rbDemo.CheckedChanged += rbDemo_CheckedChanged;
            // 
            // gbLanguage
            // 
            gbLanguage.Controls.Add(cmbLanguage);
            resources.ApplyResources(gbLanguage, "gbLanguage");
            gbLanguage.Name = "gbLanguage";
            gbLanguage.TabStop = false;
            // 
            // cmbLanguage
            // 
            cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbLanguage.FormattingEnabled = true;
            resources.ApplyResources(cmbLanguage, "cmbLanguage");
            cmbLanguage.Name = "cmbLanguage";
            // 
            // btnSave
            // 
            resources.ApplyResources(btnSave, "btnSave");
            btnSave.Name = "btnSave";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            resources.ApplyResources(btnCancel, "btnCancel");
            btnCancel.Name = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ConnectionSettingsView
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(gbLanguage);
            Controls.Add(gbConnection);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "ConnectionSettingsView";
            Load += ConnectionSettingsView_Load;
            gbConnection.ResumeLayout(false);
            gbConnection.PerformLayout();
            gbLanguage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RadioButton rbProduction;
        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.Label lblDemoConnectionString;
        private System.Windows.Forms.TextBox txtDemoConnectionString;
        private System.Windows.Forms.RadioButton rbDemo;
        private System.Windows.Forms.GroupBox gbLanguage;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}