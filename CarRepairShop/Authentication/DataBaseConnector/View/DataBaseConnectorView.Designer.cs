namespace CarRepairShop.Authentication.DataBaseConnector.View
{
    partial class DataBaseConnectorView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBaseConnectorView));
            pb = new System.Windows.Forms.ProgressBar();
            lblConnectionStateInfo = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            lblDataBaseName = new System.Windows.Forms.Label();
            ProgressTimer = new System.Windows.Forms.Timer(components);
            btnSettings = new System.Windows.Forms.Button();
            pnlSettings = new System.Windows.Forms.Panel();
            pnlSettings.SuspendLayout();
            SuspendLayout();
            // 
            // pb
            // 
            pb.ForeColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(pb, "pb");
            pb.Name = "pb";
            // 
            // lblConnectionStateInfo
            // 
            resources.ApplyResources(lblConnectionStateInfo, "lblConnectionStateInfo");
            lblConnectionStateInfo.Name = "lblConnectionStateInfo";
            // 
            // btnCancel
            // 
            resources.ApplyResources(btnCancel, "btnCancel");
            btnCancel.Name = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblDataBaseName
            // 
            resources.ApplyResources(lblDataBaseName, "lblDataBaseName");
            lblDataBaseName.ForeColor = System.Drawing.Color.SteelBlue;
            lblDataBaseName.Name = "lblDataBaseName";
            // 
            // ProgressTimer
            // 
            ProgressTimer.Interval = 50;
            ProgressTimer.Tick += ProgressTimer_Tick;
            // 
            // btnSettings
            // 
            resources.ApplyResources(btnSettings, "btnSettings");
            btnSettings.ForeColor = System.Drawing.Color.SteelBlue;
            btnSettings.Image = Properties.Resources.settings;
            btnSettings.Name = "btnSettings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // pnlSettings
            // 
            pnlSettings.Controls.Add(btnSettings);
            resources.ApplyResources(pnlSettings, "pnlSettings");
            pnlSettings.Name = "pnlSettings";
            // 
            // DataBaseConnectorView
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pnlSettings);
            Controls.Add(lblDataBaseName);
            Controls.Add(btnCancel);
            Controls.Add(lblConnectionStateInfo);
            Controls.Add(pb);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "DataBaseConnectorView";
            Load += DataBaseConnectorView_Load;
            pnlSettings.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.Label lblConnectionStateInfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDataBaseName;
        private System.Windows.Forms.Timer ProgressTimer;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel pnlSettings;
    }
}