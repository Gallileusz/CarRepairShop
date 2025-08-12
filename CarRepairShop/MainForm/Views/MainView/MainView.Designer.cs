namespace CarRepairShop.MainForm.Views.MainView
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            pnlNavigation = new System.Windows.Forms.Panel();
            panel8 = new System.Windows.Forms.Panel();
            btnHome = new System.Windows.Forms.Button();
            panel7 = new System.Windows.Forms.Panel();
            btnSettings = new System.Windows.Forms.Button();
            panel6 = new System.Windows.Forms.Panel();
            btnUsers = new System.Windows.Forms.Button();
            panel4 = new System.Windows.Forms.Panel();
            btnWarehouse = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            btnServices = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            btnCRM = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            btnContractors = new System.Windows.Forms.Button();
            pnlBody = new System.Windows.Forms.Panel();
            pnlNavigation.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNavigation
            // 
            pnlNavigation.BackColor = System.Drawing.Color.SteelBlue;
            pnlNavigation.Controls.Add(panel8);
            pnlNavigation.Controls.Add(panel7);
            pnlNavigation.Controls.Add(panel6);
            pnlNavigation.Controls.Add(panel4);
            pnlNavigation.Controls.Add(panel3);
            pnlNavigation.Controls.Add(panel2);
            pnlNavigation.Controls.Add(panel1);
            resources.ApplyResources(pnlNavigation, "pnlNavigation");
            pnlNavigation.Name = "pnlNavigation";
            // 
            // panel8
            // 
            panel8.Controls.Add(btnHome);
            resources.ApplyResources(panel8, "panel8");
            panel8.ForeColor = System.Drawing.Color.White;
            panel8.Name = "panel8";
            // 
            // btnHome
            // 
            resources.ApplyResources(btnHome, "btnHome");
            btnHome.ForeColor = System.Drawing.Color.Coral;
            btnHome.Image = Properties.Resources.home;
            btnHome.Name = "btnHome";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panel7
            // 
            resources.ApplyResources(panel7, "panel7");
            panel7.Controls.Add(btnSettings);
            panel7.ForeColor = System.Drawing.Color.White;
            panel7.Name = "panel7";
            // 
            // btnSettings
            // 
            resources.ApplyResources(btnSettings, "btnSettings");
            btnSettings.Image = Properties.Resources.settings;
            btnSettings.Name = "btnSettings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnUsers);
            resources.ApplyResources(panel6, "panel6");
            panel6.ForeColor = System.Drawing.Color.White;
            panel6.Name = "panel6";
            // 
            // btnUsers
            // 
            resources.ApplyResources(btnUsers, "btnUsers");
            btnUsers.Image = Properties.Resources.users;
            btnUsers.Name = "btnUsers";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnWarehouse);
            resources.ApplyResources(panel4, "panel4");
            panel4.ForeColor = System.Drawing.Color.White;
            panel4.Name = "panel4";
            // 
            // btnWarehouse
            // 
            resources.ApplyResources(btnWarehouse, "btnWarehouse");
            btnWarehouse.Image = Properties.Resources.warehouse;
            btnWarehouse.Name = "btnWarehouse";
            btnWarehouse.UseVisualStyleBackColor = true;
            btnWarehouse.Click += btnWarehouse_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnServices);
            resources.ApplyResources(panel3, "panel3");
            panel3.ForeColor = System.Drawing.Color.White;
            panel3.Name = "panel3";
            // 
            // btnServices
            // 
            resources.ApplyResources(btnServices, "btnServices");
            btnServices.Image = Properties.Resources.services;
            btnServices.Name = "btnServices";
            btnServices.UseVisualStyleBackColor = true;
            btnServices.Click += btnServices_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCRM);
            resources.ApplyResources(panel2, "panel2");
            panel2.ForeColor = System.Drawing.Color.White;
            panel2.Name = "panel2";
            // 
            // btnCRM
            // 
            resources.ApplyResources(btnCRM, "btnCRM");
            btnCRM.Image = Properties.Resources.crm;
            btnCRM.Name = "btnCRM";
            btnCRM.UseVisualStyleBackColor = true;
            btnCRM.Click += btnCRM_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnContractors);
            resources.ApplyResources(panel1, "panel1");
            panel1.ForeColor = System.Drawing.Color.White;
            panel1.Name = "panel1";
            // 
            // btnContractors
            // 
            resources.ApplyResources(btnContractors, "btnContractors");
            btnContractors.Image = Properties.Resources.contractors;
            btnContractors.Name = "btnContractors";
            btnContractors.UseVisualStyleBackColor = true;
            btnContractors.Click += btnContractors_Click;
            // 
            // pnlBody
            // 
            pnlBody.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(pnlBody, "pnlBody");
            pnlBody.Name = "pnlBody";
            // 
            // MainView
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pnlBody);
            Controls.Add(pnlNavigation);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "MainView";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += MainView_Load;
            pnlNavigation.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnContractors;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnWarehouse;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCRM;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnHome;
    }
}