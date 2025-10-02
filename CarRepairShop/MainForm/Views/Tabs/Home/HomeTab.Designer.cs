namespace CarRepairShop.MainForm.Views.Tabs.Home
{
    partial class HomeTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeTab));
            panel1 = new System.Windows.Forms.Panel();
            pnlNavigation = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            btnSources = new System.Windows.Forms.Button();
            panel4 = new System.Windows.Forms.Panel();
            btnAcknowledgements = new System.Windows.Forms.Button();
            panel7 = new System.Windows.Forms.Panel();
            btnChangelog = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            btnAboutThisProject = new System.Windows.Forms.Button();
            txt = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblTitle = new System.Windows.Forms.Label();
            panel6 = new System.Windows.Forms.Panel();
            btnGitHub = new System.Windows.Forms.Button();
            lblVersion = new System.Windows.Forms.Label();
            lblVersionTitle = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            pnlNavigation.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(pnlNavigation);
            panel1.Controls.Add(txt);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(lblVersion);
            panel1.Controls.Add(lblVersionTitle);
            panel1.Name = "panel1";
            // 
            // pnlNavigation
            // 
            resources.ApplyResources(pnlNavigation, "pnlNavigation");
            pnlNavigation.Controls.Add(panel5);
            pnlNavigation.Controls.Add(panel4);
            pnlNavigation.Controls.Add(panel7);
            pnlNavigation.Controls.Add(panel3);
            pnlNavigation.Name = "pnlNavigation";
            // 
            // panel5
            // 
            resources.ApplyResources(panel5, "panel5");
            panel5.Controls.Add(btnSources);
            panel5.ForeColor = System.Drawing.Color.White;
            panel5.Name = "panel5";
            // 
            // btnSources
            // 
            resources.ApplyResources(btnSources, "btnSources");
            btnSources.BackColor = System.Drawing.Color.SteelBlue;
            btnSources.Image = Properties.Resources.sources;
            btnSources.Name = "btnSources";
            btnSources.UseVisualStyleBackColor = false;
            btnSources.Click += btnSources_Click;
            // 
            // panel4
            // 
            resources.ApplyResources(panel4, "panel4");
            panel4.Controls.Add(btnAcknowledgements);
            panel4.ForeColor = System.Drawing.Color.White;
            panel4.Name = "panel4";
            // 
            // btnAcknowledgements
            // 
            resources.ApplyResources(btnAcknowledgements, "btnAcknowledgements");
            btnAcknowledgements.BackColor = System.Drawing.Color.SteelBlue;
            btnAcknowledgements.Image = Properties.Resources.acknowledgement;
            btnAcknowledgements.Name = "btnAcknowledgements";
            btnAcknowledgements.UseVisualStyleBackColor = false;
            btnAcknowledgements.Click += btnAcknowledgements_Click;
            // 
            // panel7
            // 
            resources.ApplyResources(panel7, "panel7");
            panel7.Controls.Add(btnChangelog);
            panel7.ForeColor = System.Drawing.Color.White;
            panel7.Name = "panel7";
            // 
            // btnChangelog
            // 
            resources.ApplyResources(btnChangelog, "btnChangelog");
            btnChangelog.BackColor = System.Drawing.Color.SteelBlue;
            btnChangelog.Image = Properties.Resources.changelog;
            btnChangelog.Name = "btnChangelog";
            btnChangelog.UseVisualStyleBackColor = false;
            btnChangelog.Click += btnChangelog_Click;
            // 
            // panel3
            // 
            resources.ApplyResources(panel3, "panel3");
            panel3.Controls.Add(btnAboutThisProject);
            panel3.ForeColor = System.Drawing.Color.White;
            panel3.Name = "panel3";
            // 
            // btnAboutThisProject
            // 
            resources.ApplyResources(btnAboutThisProject, "btnAboutThisProject");
            btnAboutThisProject.BackColor = System.Drawing.Color.SteelBlue;
            btnAboutThisProject.ForeColor = System.Drawing.Color.Coral;
            btnAboutThisProject.Image = Properties.Resources.info;
            btnAboutThisProject.Name = "btnAboutThisProject";
            btnAboutThisProject.UseVisualStyleBackColor = false;
            btnAboutThisProject.Click += btnAboutThisProject_Click;
            // 
            // txt
            // 
            resources.ApplyResources(txt, "txt");
            txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txt.Name = "txt";
            txt.ReadOnly = true;
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblTitle);
            panel2.Name = "panel2";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Image = Properties.Resources.users;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            resources.ApplyResources(lblTitle, "lblTitle");
            lblTitle.ForeColor = System.Drawing.Color.SteelBlue;
            lblTitle.Name = "lblTitle";
            // 
            // panel6
            // 
            resources.ApplyResources(panel6, "panel6");
            panel6.Controls.Add(btnGitHub);
            panel6.ForeColor = System.Drawing.Color.White;
            panel6.Name = "panel6";
            // 
            // btnGitHub
            // 
            resources.ApplyResources(btnGitHub, "btnGitHub");
            btnGitHub.BackColor = System.Drawing.Color.SlateBlue;
            btnGitHub.Image = Properties.Resources.githubLogo;
            btnGitHub.Name = "btnGitHub";
            btnGitHub.UseVisualStyleBackColor = false;
            btnGitHub.Click += btnGitHub_Click;
            // 
            // lblVersion
            // 
            resources.ApplyResources(lblVersion, "lblVersion");
            lblVersion.ForeColor = System.Drawing.Color.Black;
            lblVersion.Name = "lblVersion";
            // 
            // lblVersionTitle
            // 
            resources.ApplyResources(lblVersionTitle, "lblVersionTitle");
            lblVersionTitle.ForeColor = System.Drawing.Color.SteelBlue;
            lblVersionTitle.Name = "lblVersionTitle";
            // 
            // HomeTab
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "HomeTab";
            Load += HomeTab_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlNavigation.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnGitHub;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVersionTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSources;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAcknowledgements;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAboutThisProject;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnChangelog;
        private System.Windows.Forms.Panel pnlNavigation;
    }
}
