using CarRepairShop.AppSettings.CurrentUser.Service;
using CarRepairShop.Contractors.CarForm.DTO;
using CarRepairShop.Contractors.CarForm.View;
using CarRepairShop.Contractors.ContractorForm.DTO;
using CarRepairShop.Contractors.ContractorForm.View;
using CarRepairShop.Contractors.FuelTypesList.View;
using CarRepairShop.Domain.Entities;
using CarRepairShop.MainForm.Models.Tabs.Contractors;
using CarRepairShop.MainForm.Views.Tabs.Contractors;
using CarRepairShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Translations = CarRepairShop.Library.Texts;

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
        public int SelectedCarID => dgvCars.CurrentRow?.DataBoundItem is ContractorCarsVM car ? car.ID : 0;

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

        public void LoadContractorsCarsToGrid(List<ContractorCarsVM> carVMs)
        {
            dgvCars.DataSource = null;
            dgvCars.DataSource = carVMs;

            dgvCars.Columns[nameof(ContractorCarsVM.BrandName)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCars.Columns[nameof(ContractorCarsVM.ModelName)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCars.Columns[nameof(ContractorCarsVM.LicensePlate)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCars.Columns[nameof(ContractorCarsVM.VIN)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCars.Columns[nameof(ContractorCarsVM.FuelType)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCars.Columns[nameof(ContractorCarsVM.Mileage)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCars.Columns[nameof(ContractorCarsVM.Year)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCars.Columns[nameof(ContractorCarsVM.EngineCapacity)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCars.Columns[nameof(ContractorCarsVM.ID)].Visible = false;
            dgvCars.Columns[nameof(ContractorCarsVM.ContractorID)].Visible = false;

            dgvCars.Columns[nameof(ContractorCarsVM.BrandName)].HeaderText = Translations.MainView.Contractors.BrandNameColumn;
            dgvCars.Columns[nameof(ContractorCarsVM.ModelName)].HeaderText = Translations.MainView.Contractors.ModelNameColumn;
            dgvCars.Columns[nameof(ContractorCarsVM.LicensePlate)].HeaderText = Translations.MainView.Contractors.LicensePlateColumn;
            dgvCars.Columns[nameof(ContractorCarsVM.VIN)].HeaderText = Translations.MainView.Contractors.VINColumn;
            dgvCars.Columns[nameof(ContractorCarsVM.FuelType)].HeaderText = Translations.MainView.Contractors.FuelTypeColumn;
            dgvCars.Columns[nameof(ContractorCarsVM.Mileage)].HeaderText = Translations.MainView.Contractors.MileageColumn;
            dgvCars.Columns[nameof(ContractorCarsVM.Year)].HeaderText = Translations.MainView.Contractors.ProductionYearColumn;
            dgvCars.Columns[nameof(ContractorCarsVM.EngineCapacity)].HeaderText = Translations.MainView.Contractors.EngineCapacityColumn;
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

            dgvContractors.Columns[nameof(Domain.Entities.Contractors.Name)].HeaderText = Translations.MainView.Contractors.ContractorNameColumn;
            dgvContractors.Columns[nameof(Domain.Entities.Contractors.Surname)].HeaderText = Translations.MainView.Contractors.ContractorSurnameColumn;
            dgvContractors.Columns[nameof(Domain.Entities.Contractors.Email)].HeaderText = Translations.MainView.Contractors.EmailColumn;
            dgvContractors.Columns[nameof(Domain.Entities.Contractors.PhoneNumber)].HeaderText = Translations.MainView.Contractors.PhoneNumberColumn;
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