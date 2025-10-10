using CarRepairShop.Authentication.ConnectionSettings.DTO;
using CarRepairShop.Authentication.ConnectionSettings.Presenter;
using CarRepairShop.Domain.Entities;
using CarRepairShop.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarRepairShop.Authentication.ConnectionSettings.View
{
    public partial class ConnectionSettingsView : Form, IConnectionSettingsView
    {
        public event EventHandler FormLoaded;
        public event EventHandler<ConnectionType> ConnectionTypeChanged;
        public event EventHandler SaveButtonClicked;
        public event EventHandler CancelButtonClicked;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DialogResult ChangesAccured { get => DialogResult; set => DialogResult = value; }

        public int SelectedLanguageID => cmbLanguage.SelectedItem is Languages language ? language.ID : 0;

        public string DemoConnectionString => txtDemoConnectionString.Text;

        private readonly ConnectionSettingsPresenter _presenter;

        public ConnectionSettingsView()
        {
            InitializeComponent();
            _presenter = new ConnectionSettingsPresenter(this, new GenericRepository());
        }

        private void ConnectionSettingsView_Load(object sender, EventArgs e) => FormLoaded?.Invoke(sender, e);

        private void rbProduction_CheckedChanged(object sender, EventArgs e) => ConnectionTypeChanged?.Invoke(sender, new ConnectionType(rbProduction.Checked, rbDemo.Checked));

        private void rbDemo_CheckedChanged(object sender, EventArgs e) => ConnectionTypeChanged?.Invoke(sender, new ConnectionType(rbProduction.Checked, rbDemo.Checked));

        private void btnSave_Click(object sender, EventArgs e) => SaveButtonClicked?.Invoke(sender, e);

        private void btnCancel_Click(object sender, EventArgs e) => CancelButtonClicked?.Invoke(sender, e);

        public void SetConnectionType(ConnectionType connectionType)
        {
            if (connectionType.ProductionConnection)
            {
                rbProduction.Checked = true;
                txtDemoConnectionString.Enabled = false;
            }
            else if (connectionType.DemoConnection)
            {
                rbDemo.Checked = true;
                txtDemoConnectionString.Enabled = true;
            }
        }

        public void PopulateDemoConnectionString(string demoConnectionString) => txtDemoConnectionString.Text = demoConnectionString;

        public void CloseForm() => this.Close();

        public void ShowErrorMessage(string message) => MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        public void PopulateLanguages(List<Languages> languages, Languages currentLanguage)
        {
            cmbLanguage.DataSource = null;
            cmbLanguage.DataSource = languages;

            cmbLanguage.DisplayMember = nameof(Languages.Name);
            cmbLanguage.ValueMember = nameof(Languages.ID);
            cmbLanguage.SelectedValue = currentLanguage.ID;
        }
    }
}
