using CarRepairShop.MainForm.Presenters.Tabs.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarRepairShop.MainForm.Views.Tabs.Services
{
    public partial class ServicesTab : UserControl, IServicesTab
    {
        private ServicesTabPresenter _presenter;

        public event EventHandler FormIsLoaded;
        public event EventHandler DebounceTimerElapsed;
        public event EventHandler FilterChanged;
        public event EventHandler AddServiceButtonClicked;
        public event EventHandler EditServiceButtonClicked;
        public event EventHandler DeleteServiceButtonClicked;
        public event EventHandler ServiceStatusCheckboxClicked;

        public int SelectedServiceID
        {
            get
            {
                if (dgv.CurrentRow?.DataBoundItem is Domain.Entities.Services service)
                    return service.ID;
                return 0;
            }
        }

        public string SearchedServiceName => txtServiceName.Text;

        public bool AllStatusesRadioButtonStatus => rbAll.Checked;

        public bool ActiveServicesRadioButtonStatus => rbActive.Checked;

        public bool InactiveServicesRadioButtonStatus => rbInactive.Checked;

        public ServicesTab()
        {
            InitializeComponent();
            _presenter = new ServicesTabPresenter(this);
            Debounce.Stop();
        }

        private void ServicesTab_Load(object sender, EventArgs e) => FormIsLoaded?.Invoke(sender, e);

        private void btnAddService_Click(object sender, EventArgs e) => AddServiceButtonClicked?.Invoke(sender, e);

        private void btnEditService_Click(object sender, EventArgs e) => EditServiceButtonClicked?.Invoke(sender, e);

        private void btnDeleteService_Click(object sender, EventArgs e) => DeleteServiceButtonClicked?.Invoke(sender, e);

        public void LoadServicesToGrid(List<Domain.Entities.Services> services)
        {
            dgv.DataSource = null;
            dgv.DataSource = services;

            dgv.Columns[nameof(Domain.Entities.Services.Name)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[nameof(Domain.Entities.Services.ID)].Visible = false;
        }

        public bool ConfirmAction(string message, string title) => MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;

        public void ShowMessage(string message) => MessageBox.Show(message);

        public void UnableButtonsIfUserDoesntHavePermissions(bool hasEditPermission)
        {
            btnAddService.Enabled = hasEditPermission;
            btnEditService.Enabled = hasEditPermission;
            btnDeleteService.Enabled = hasEditPermission;

            dgv.Columns[nameof(Domain.Entities.Services.IsActive)].ReadOnly = hasEditPermission;
        }

        private void Debounce_Tick(object sender, EventArgs e)
        {
            Debounce.Stop();
            DebounceTimerElapsed?.Invoke(this, e);
        }

        private void txtServiceName_TextChanged(object sender, EventArgs e)
        {
            Debounce.Stop();
            Debounce.Start();

            FilterChanged?.Invoke(sender, e);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != dgv.Columns[nameof(Domain.Entities.Services.IsActive)].Index || e.RowIndex < 0) return;

            ServiceStatusCheckboxClicked?.Invoke(sender, e);
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            Debounce.Stop();
            Debounce.Start();

            FilterChanged?.Invoke(sender, e);
        }

        private void rbActive_CheckedChanged(object sender, EventArgs e)
        {
            Debounce.Stop();
            Debounce.Start();

            FilterChanged?.Invoke(sender, e);
        }

        private void rbInactive_CheckedChanged(object sender, EventArgs e)
        {
            Debounce.Stop();
            Debounce.Start();

            FilterChanged?.Invoke(sender, e);
        }
    }
}
