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
            panel1.Controls.Add(pnlNavigation);
            panel1.Controls.Add(txt);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(lblVersion);
            panel1.Controls.Add(lblVersionTitle);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1136, 767);
            panel1.TabIndex = 0;
            // 
            // pnlNavigation
            // 
            pnlNavigation.Controls.Add(panel5);
            pnlNavigation.Controls.Add(panel4);
            pnlNavigation.Controls.Add(panel7);
            pnlNavigation.Controls.Add(panel3);
            pnlNavigation.Location = new System.Drawing.Point(0, 75);
            pnlNavigation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlNavigation.Name = "pnlNavigation";
            pnlNavigation.Size = new System.Drawing.Size(215, 332);
            pnlNavigation.TabIndex = 29;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnSources);
            panel5.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            panel5.ForeColor = System.Drawing.Color.White;
            panel5.Location = new System.Drawing.Point(4, 171);
            panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(208, 74);
            panel5.TabIndex = 27;
            // 
            // btnSources
            // 
            btnSources.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnSources.BackColor = System.Drawing.Color.SteelBlue;
            btnSources.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSources.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSources.Image = Properties.Resources.sources;
            btnSources.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnSources.Location = new System.Drawing.Point(-7, -3);
            btnSources.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSources.Name = "btnSources";
            btnSources.Size = new System.Drawing.Size(223, 97);
            btnSources.TabIndex = 0;
            btnSources.Text = "Sources";
            btnSources.UseVisualStyleBackColor = false;
            btnSources.Click += btnSources_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnAcknowledgements);
            panel4.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            panel4.ForeColor = System.Drawing.Color.White;
            panel4.Location = new System.Drawing.Point(4, 88);
            panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(208, 74);
            panel4.TabIndex = 26;
            // 
            // btnAcknowledgements
            // 
            btnAcknowledgements.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnAcknowledgements.BackColor = System.Drawing.Color.SteelBlue;
            btnAcknowledgements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAcknowledgements.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAcknowledgements.Image = Properties.Resources.acknowledgement;
            btnAcknowledgements.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnAcknowledgements.Location = new System.Drawing.Point(-7, -3);
            btnAcknowledgements.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAcknowledgements.Name = "btnAcknowledgements";
            btnAcknowledgements.Size = new System.Drawing.Size(223, 97);
            btnAcknowledgements.TabIndex = 0;
            btnAcknowledgements.Text = "Acknowledgements";
            btnAcknowledgements.UseVisualStyleBackColor = false;
            btnAcknowledgements.Click += btnAcknowledgements_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnChangelog);
            panel7.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            panel7.ForeColor = System.Drawing.Color.White;
            panel7.Location = new System.Drawing.Point(4, 254);
            panel7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(208, 74);
            panel7.TabIndex = 28;
            // 
            // btnChangelog
            // 
            btnChangelog.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnChangelog.BackColor = System.Drawing.Color.SteelBlue;
            btnChangelog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnChangelog.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnChangelog.Image = Properties.Resources.changelog;
            btnChangelog.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnChangelog.Location = new System.Drawing.Point(-7, -3);
            btnChangelog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnChangelog.Name = "btnChangelog";
            btnChangelog.Size = new System.Drawing.Size(223, 97);
            btnChangelog.TabIndex = 0;
            btnChangelog.Text = "Changelog";
            btnChangelog.UseVisualStyleBackColor = false;
            btnChangelog.Click += btnChangelog_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAboutThisProject);
            panel3.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            panel3.ForeColor = System.Drawing.Color.White;
            panel3.Location = new System.Drawing.Point(4, 5);
            panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(208, 74);
            panel3.TabIndex = 25;
            // 
            // btnAboutThisProject
            // 
            btnAboutThisProject.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnAboutThisProject.BackColor = System.Drawing.Color.SteelBlue;
            btnAboutThisProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAboutThisProject.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAboutThisProject.ForeColor = System.Drawing.Color.Coral;
            btnAboutThisProject.Image = Properties.Resources.info;
            btnAboutThisProject.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnAboutThisProject.Location = new System.Drawing.Point(-7, -1);
            btnAboutThisProject.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAboutThisProject.Name = "btnAboutThisProject";
            btnAboutThisProject.Size = new System.Drawing.Size(223, 95);
            btnAboutThisProject.TabIndex = 0;
            btnAboutThisProject.Text = "About this project";
            btnAboutThisProject.UseVisualStyleBackColor = false;
            btnAboutThisProject.Click += btnAboutThisProject_Click;
            // 
            // txt
            // 
            txt.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            txt.Location = new System.Drawing.Point(222, 80);
            txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt.Multiline = true;
            txt.Name = "txt";
            txt.ReadOnly = true;
            txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txt.Size = new System.Drawing.Size(916, 647);
            txt.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblTitle);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1136, 73);
            panel2.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            pictureBox1.Image = Properties.Resources.users;
            pictureBox1.Location = new System.Drawing.Point(206, 10);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.MinimumSize = new System.Drawing.Size(56, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(56, 58);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
            lblTitle.ForeColor = System.Drawing.Color.SteelBlue;
            lblTitle.Location = new System.Drawing.Point(270, 23);
            lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(678, 33);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Michał Galli - \"Car repair shop\" engineer project";
            // 
            // panel6
            // 
            panel6.Controls.Add(btnGitHub);
            panel6.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            panel6.ForeColor = System.Drawing.Color.White;
            panel6.Location = new System.Drawing.Point(4, 414);
            panel6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(208, 74);
            panel6.TabIndex = 18;
            // 
            // btnGitHub
            // 
            btnGitHub.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnGitHub.BackColor = System.Drawing.Color.SlateBlue;
            btnGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGitHub.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnGitHub.Image = Properties.Resources.githubLogo;
            btnGitHub.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnGitHub.Location = new System.Drawing.Point(-4, -1);
            btnGitHub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnGitHub.Name = "btnGitHub";
            btnGitHub.Size = new System.Drawing.Size(220, 98);
            btnGitHub.TabIndex = 0;
            btnGitHub.Text = "Open github";
            btnGitHub.UseVisualStyleBackColor = false;
            btnGitHub.Click += btnGitHub_Click;
            // 
            // lblVersion
            // 
            lblVersion.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblVersion.AutoSize = true;
            lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
            lblVersion.ForeColor = System.Drawing.Color.Black;
            lblVersion.Location = new System.Drawing.Point(88, 735);
            lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new System.Drawing.Size(55, 24);
            lblVersion.TabIndex = 17;
            lblVersion.Text = "1.0.0";
            // 
            // lblVersionTitle
            // 
            lblVersionTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblVersionTitle.AutoSize = true;
            lblVersionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
            lblVersionTitle.ForeColor = System.Drawing.Color.SteelBlue;
            lblVersionTitle.Location = new System.Drawing.Point(2, 735);
            lblVersionTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVersionTitle.Name = "lblVersionTitle";
            lblVersionTitle.Size = new System.Drawing.Size(88, 24);
            lblVersionTitle.TabIndex = 15;
            lblVersionTitle.Text = "Version:";
            // 
            // HomeTab
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "HomeTab";
            Size = new System.Drawing.Size(1136, 767);
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
