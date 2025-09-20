using CarRepairShop.AppSettings;
using CarRepairShop.Contractors.CarForm.DTO;
using CarRepairShop.Contractors.CarForm.View;
using CarRepairShop.Contractors.ContractorForm.DTO;
using CarRepairShop.Contractors.ContractorForm.View;
using CarRepairShop.Contractors.FuelTypesList.View;
using CarRepairShop.Domain.Entities;
using CarRepairShop.MainForm.Views.Tabs.Contractors;
using CarRepairShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CarRepairShop.MainForm.Views.Tabs.ContractorsTab
{
    public partial class ContractorsTab : UserControl, IContractorsTab
    {
        public event EventHandler FormIsLoaded;
        public event EventHandler DebounceElapsed;
        public event EventHandler FilterChanged;
        public event EventHandler AddContractorButtonClicked;
        public event EventHandler EditContractorButtonClicked;
        public event EventHandler DeleteContractorButtonClicked;
        public event EventHandler AddCarButtonClicked;
        public event EventHandler EditCarButtonClicked;
        public event EventHandler DeleteCarButtonClicked;
        public event EventHandler ContractorSelectionChanged;
        public event EventHandler FuelTypesButtonClicked;

        private readonly Presenters.Tabs.Contractors.ContractorTabPresenter _presenter;

        public ContractorsTab()
        {
            InitializeComponent();
            _presenter = new Presenters.Tabs.Contractors.ContractorTabPresenter(this, new GenericRepository(), new CurrentUserService());
        }

        public int SelectedContractorID => dgvContractors.CurrentRow?.DataBoundItem is Domain.Entities.Contractors contractor ? contractor.ID : 0;
        public int SelectedCarID => dgvCars.CurrentRow?.DataBoundItem is ContractorsCars car ? car.ID : 0;

        public string SearchedContractorName => txtName.Text;

        public string SearchedContractorSurname => txtSurname.Text;

        public string SearchedCarBrandName => txtBrandName.Text;

        public string SearchedCarModelName => txtModelName.Text;

        public void ShowMessage(string message) => MessageBox.Show(message);

        public bool ConfirmAction(string message, string title) => MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;

        public void SelectContractorByID(int contractorId)
        {
            var row = dgvContractors.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.DataBoundItem is Domain.Entities.Contractors contractor && contractor.ID == contractorId);

            if (row != null)
            {
                dgvContractors.ClearSelection();
                row.Selected = true;
                dgvContractors.FirstDisplayedScrollingRowIndex = row.Index;

                if (row.Cells[row.Index].Displayed)
                    dgvContractors.CurrentCell = row.Cells[row.Index];
            }
        }

        public void SelectCarByID(int carID)
        {
            foreach (DataGridViewRow row in dgvCars.Rows)
            {
                if (row.DataBoundItem is ContractorsCars car && car.ID == carID)
                {
                    row.Selected = true; break;
                }
            }
        }

        public void LoadContractorsCarsToGrid(List<ContractorsCars> cars)
        {
            dgvCars.DataSource = null;
            dgvCars.DataSource = cars;

            dgvCars.Columns[nameof(ContractorsCars.BrandName)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCars.Columns[nameof(ContractorsCars.ModelName)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCars.Columns[nameof(ContractorsCars.LicensePlate)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCars.Columns[nameof(ContractorsCars.VIN)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCars.Columns[nameof(ContractorsCars.FuelType)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCars.Columns[nameof(ContractorsCars.Mileage)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCars.Columns[nameof(ContractorsCars.Year)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCars.Columns[nameof(ContractorsCars.EngineCapacity)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCars.Columns[nameof(ContractorsCars.ID)].Visible = false;
            dgvCars.Columns[nameof(ContractorsCars.ContractorID)].Visible = false;
        }

        public void LoadContractorsToGrid(List<Domain.Entities.Contractors> contractors)
        {
            dgvContractors.DataSource = null;
            dgvContractors.DataSource = contractors;

            dgvContractors.Columns[nameof(Domain.Entities.Contractors.Name)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvContractors.Columns[nameof(Domain.Entities.Contractors.Surname)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvContractors.Columns[nameof(Domain.Entities.Contractors.Email)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvContractors.Columns[nameof(Domain.Entities.Contractors.PhoneNumber)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvContractors.Columns[nameof(Domain.Entities.Contractors.ID)].Visible = false;
        }

        public void ChangeButtonAccess(bool hasPermission)
        {
            btnAddContractor.Enabled = hasPermission;
            btnEditContractor.Enabled = hasPermission;
            btnDeleteContractor.Enabled = hasPermission;
            btnAddVehicle.Enabled = hasPermission;
            btnEditVehicle.Enabled = hasPermission;
            btnDeleteVehicle.Enabled = hasPermission;
        }

        public ContractorFormResult OpenContractorForm(int? id = null, string title = "")
        {
            var form = new ContractorForm(id);
            form.FormTitle = title;

            form.ShowDialog();

            return form.ContractorFormResult;
        }

        public CarFormResult OpenCarForm(int? id = null, string title = "")
        {
            var form = new CarForm(id);
            form.FormTitle = title;

            form.ShowDialog();

            return form.CarFormResult;
        }

        public DialogResult OpenFuelTypesDictionary()
        {
            var form = new FuelTypesList();
            form.ShowDialog();

            return form.ChangesAccured;
        }

        public void StopDebounce() => Debounce.Stop();

        public void StartDebounce()
        {
            Debounce.Stop();
            Debounce.Start();
        }

        public void ResetGridSelections()
        {
            dgvContractors.ClearSelection();
            dgvCars.DataSource = null;
        }

        private void ContractorsTab_Load(object sender, EventArgs e) => FormIsLoaded?.Invoke(sender, e);

        private void btnAddContractor_Click(object sender, EventArgs e) => AddContractorButtonClicked?.Invoke(sender, e);

        private void btnEditContractor_Click(object sender, EventArgs e) => EditContractorButtonClicked?.Invoke(sender, e);

        private void btnDeleteContractor_Click(object sender, EventArgs e) => DeleteContractorButtonClicked?.Invoke(sender, e);

        private void btnAddVehicle_Click(object sender, EventArgs e) => AddCarButtonClicked?.Invoke(sender, e);

        private void btnEditVehicle_Click(object sender, EventArgs e) => EditCarButtonClicked?.Invoke(sender, e);

        private void btnDeleteVehicle_Click(object sender, EventArgs e) => DeleteCarButtonClicked?.Invoke(sender, e);

        private void btnFuelTypes_Click(object sender, EventArgs e) => FuelTypesButtonClicked?.Invoke(sender, e);

        private void dgvContractors_CellClick(object sender, DataGridViewCellEventArgs e) => ContractorSelectionChanged?.Invoke(sender, e);

        private void Debounce_Tick(object sender, EventArgs e) => DebounceElapsed?.Invoke(this, e);

        private void txtName_TextChanged(object sender, EventArgs e) => FilterChanged?.Invoke(sender, e);

        private void txtSurname_TextChanged(object sender, EventArgs e) => FilterChanged?.Invoke(sender, e);

        private void txtBrandName_TextChanged(object sender, EventArgs e) => FilterChanged?.Invoke(sender, e);

        private void txtModelName_TextChanged(object sender, EventArgs e) => FilterChanged?.Invoke(sender, e);
    }
}