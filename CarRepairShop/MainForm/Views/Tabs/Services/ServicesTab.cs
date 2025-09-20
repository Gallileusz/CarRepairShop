using CarRepairShop.AppSettings;
using CarRepairShop.MainForm.Presenters.Tabs.Services;
using CarRepairShop.Repositories;
using CarRepairShop.Services.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Translations = CarRepairShop.Library.Texts;

namespace CarRepairShop.MainForm.Views.Tabs.Services
{
    public partial class ServicesTab : UserControl, IServicesTab
    {
        private ServicesTabPresenter _presenter;

        public event EventHandler FormIsLoaded;
        public event EventHandler DebounceElapsed;
        public event EventHandler FilterChanged;
        public event EventHandler AddServiceButtonClicked;
        public event EventHandler EditServiceButtonClicked;
        public event EventHandler DeleteServiceButtonClicked;
        public event EventHandler ServiceStatusCheckboxClicked;

        public int SelectedServiceID => dgv.CurrentRow?.DataBoundItem is Domain.Entities.Services service ? service.ID : 0;

        public string SearchedServiceName => txtServiceName.Text;

        public bool AllStatusesRadioButtonStatus => rbAll.Checked;

        public bool ActiveServicesRadioButtonStatus => rbActive.Checked;

        public bool InactiveServicesRadioButtonStatus => rbInactive.Checked;

        public ServicesTab()
        {
            InitializeComponent();
            _presenter = new ServicesTabPresenter(this, new GenericRepository(), new CurrentUserService());
        }

        public void LoadServicesToGrid(List<Domain.Entities.Services> services)
        {
            dgv.DataSource = null;
            dgv.DataSource = services;

            dgv.Columns[nameof(Domain.Entities.Services.ID)].Visible = false;
            dgv.Columns[nameof(Domain.Entities.Services.Name)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[nameof(Domain.Entities.Services.IsActive)].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgv.Columns[nameof(Domain.Entities.Services.Duration)].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgv.Columns[nameof(Domain.Entities.Services.WarrantyMonths)].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgv.Columns[nameof(Domain.Entities.Services.StandardCost)].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgv.Columns[nameof(Domain.Entities.Services.Name)].HeaderText = Translations.MainView.Services.NameHeaderText;
            dgv.Columns[nameof(Domain.Entities.Services.IsActive)].HeaderText = Translations.MainView.Services.StatusHeaderText;
            dgv.Columns[nameof(Domain.Entities.Services.Duration)].HeaderText = Translations.MainView.Services.DurationHeaderText;
            dgv.Columns[nameof(Domain.Entities.Services.WarrantyMonths)].HeaderText = Translations.MainView.Services.WarrantyHeaderText;
            dgv.Columns[nameof(Domain.Entities.Services.StandardCost)].HeaderText = Translations.MainView.Services.CostHeaderText;
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

        public ServiceFormResult ShowServiceForm(int? serviceID)
        {
            var form = new CarRepairShop.Services.View.SerivcesForm(serviceID);
            form.ShowDialog();

            return new ServiceFormResult
            {
                OperationConfirmed = form.OperationConfirmed,
                Service = new Domain.Entities.Services
                {
                    Name = form.ServiceName,
                    StandardCost = form.ServiceCost,
                    Duration = form.ServiceDuration,
                    WarrantyMonths = form.ServiceWarrantyMonths,
                    IsActive = form.Active
                }
            };
        }

        public void StartDebounce()
        {
            Debounce.Stop();
            Debounce.Start();
        }

        public void StopDebounce() => Debounce.Stop();

        private void Debounce_Tick(object sender, EventArgs e) => DebounceElapsed?.Invoke(this, e);

        private void ServicesTab_Load(object sender, EventArgs e) => FormIsLoaded?.Invoke(sender, e);

        private void btnAddService_Click(object sender, EventArgs e) => AddServiceButtonClicked?.Invoke(sender, e);

        private void btnEditService_Click(object sender, EventArgs e) => EditServiceButtonClicked?.Invoke(sender, e);

        private void btnDeleteService_Click(object sender, EventArgs e) => DeleteServiceButtonClicked?.Invoke(sender, e);

        private void txtServiceName_TextChanged(object sender, EventArgs e) => FilterChanged?.Invoke(sender, e);

        private void rbAll_CheckedChanged(object sender, EventArgs e) => FilterChanged?.Invoke(sender, e);

        private void rbActive_CheckedChanged(object sender, EventArgs e) => FilterChanged?.Invoke(sender, e);

        private void rbInactive_CheckedChanged(object sender, EventArgs e) => FilterChanged?.Invoke(sender, e);

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != dgv.Columns[nameof(Domain.Entities.Services.IsActive)].Index || e.RowIndex < 0) return;

            ServiceStatusCheckboxClicked?.Invoke(sender, e);
        }
    }
}
