using CarRepairShop.AppSettings;
using CarRepairShop.Domain.Entities;
using CarRepairShop.MainForm.Presenters.Tabs.Settings;
using CarRepairShop.Repositories;
using CarRepairShop.Utilities.ComboboxForm.View;
using CarRepairShop.Utilities.SingleInputForm.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarRepairShop.MainForm.Views.Tabs.Settings
{
    public partial class SettingsTab : UserControl, ISettingsTab
    {
        public event EventHandler LanguageButtonClicked;
        public event EventHandler ChangePasswordButtonClicked;

        private readonly SettingsTabPresenter _presenter;

        public SettingsTab()
        {
            InitializeComponent();
            _presenter = new SettingsTabPresenter(this, new GenericRepository(), new CurrentUserService());
        }

        public void ShowMessage(string message) => MessageBox.Show(message);

        public bool ConfirmAction(string message, string title) => MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;

        private void btnLanguage_Click(object sender, EventArgs e) => LanguageButtonClicked?.Invoke(sender, e);

        private void btnChangeCurrentUserPassword_Click(object sender, EventArgs e) => ChangePasswordButtonClicked?.Invoke(sender, e);

#nullable enable
        public string? ShowSingleInputForm(string title, string valueOnLoad)
        {
            var form = new SingleInputForm(title, valueOnLoad);
            form.ShowDialog();

            return form.Value;
        }

#nullable enable
        public Languages? ShowComboboxForm(IEnumerable<object> itemsSource, string formTitle, string displayMember, string valueMember, object selectedItem)
        {
            var cmbForm = new ComboboxForm(itemsSource, selectedItem);
            cmbForm.Title = formTitle;
            cmbForm.ComboboxDisplayValue = displayMember;
            cmbForm.ComboboxValueMember = valueMember;
            cmbForm.ShowDialog();

            return cmbForm.SelectedItem as Languages;
        }
    }
}
