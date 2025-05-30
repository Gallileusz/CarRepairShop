using CarRepairShop.MainForm.Presenters.Tabs.Settings;
using System;
using System.Windows.Forms;

namespace CarRepairShop.MainForm.Views.Tabs.Settings
{
    public partial class SettingsTab : UserControl, ISettingsTab
    {
        private SettingsTabPresenter _presenter;

        public event EventHandler LanguageButtonClicked;
        public event EventHandler ChangePasswordButtonClicked;
        public event EventHandler ChangeDefaultPasswordButtonClicked;
        public event EventHandler TabIsLoaded;

        public SettingsTab()
        {
            InitializeComponent();
            _presenter = new SettingsTabPresenter(this);
        }

        public void ShowMessage(string message) => MessageBox.Show(message);

        public bool ConfirmAction(string message, string title) => MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;

        public void UnableDefaultSettingsButtonIfUserIsNotAdmin() => btnChangeDefaultPassword.Enabled = AppSettings.CurrentUser.Data.Admin;

        private void btnLanguage_Click(object sender, EventArgs e) => LanguageButtonClicked?.Invoke(sender, e);

        private void btnChangeCurrentUserPassword_Click(object sender, EventArgs e) => ChangePasswordButtonClicked?.Invoke(sender, e);

        private void btnChangeDefaultPassword_Click(object sender, EventArgs e) => ChangeDefaultPasswordButtonClicked?.Invoke(sender, e);

        private void SettingsTab_Load(object sender, EventArgs e) => TabIsLoaded?.Invoke(sender, e);
    }
}
