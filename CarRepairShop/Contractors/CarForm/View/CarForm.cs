using CarRepairShop.Contractors.CarForm.Presenter;
using CarRepairShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CarRepairShop.Contractors.CarForm.View
{
    public partial class CarForm : Form, ICarForm
    {
        private CarFormPresenter _presenter;

        public string FormTitle { get => this.Text; set => this.Text = value; }
        public ContractorsCars Car
        {
            get
            {
                return new ContractorsCars
                {
                    BrandName = txtBrandName.Text,
                    ModelName = txtModelName.Text,
                    VIN = int.TryParse(txtVIN.Text, out int vin) ? vin : 0,
                    Year = int.TryParse(txtYear.Text, out int year) ? year : 0,
                    LicensePlate = txtLicensePlate.Text,
                    EngineCapacity = int.TryParse(txtEngineCapacity.Text, out int engineCapacity) ? engineCapacity : 0,
                    FuelType = cmbFuelTypes.SelectedItem is FuelTypes selected ? selected.Name : string.Empty,
                    Mileage = int.TryParse(txtMileage.Text, out int mileage) ? mileage : 0
                };
            }
            set
            {
                if (value == null)
                {
                    txtBrandName.Text = "";
                    txtModelName.Text = "";
                    txtVIN.Text = "";
                    txtYear.Text = "";
                    txtLicensePlate.Text = "";
                    txtEngineCapacity.Text = "";
                    txtMileage.Text = "";
                }
                else
                {
                    txtBrandName.Text = value.BrandName ?? "";
                    txtModelName.Text = value.ModelName ?? "";
                    txtVIN.Text = value.VIN.ToString();
                    txtYear.Text = value.Year.ToString();
                    txtLicensePlate.Text = value.LicensePlate ?? "";
                    txtEngineCapacity.Text = value.EngineCapacity.ToString();
                    txtMileage.Text = value.Mileage.ToString();
                    if (cmbFuelTypes.DataSource is List<FuelTypes> fuelList)
                    {
                        var fuel = fuelList.FirstOrDefault(f => f.Name == value.FuelType);
                        cmbFuelTypes.SelectedItem = fuel;
                    }
                    else
                        cmbFuelTypes.Text = value.FuelType ?? "";
                }
            }
        }


        public event EventHandler FormIsLoaded;
        public event EventHandler FormIsClosing;
        public event EventHandler ConfirmButtonClicked;
        public event EventHandler CancelButtonClicked;
        public event EventHandler AddFuelTypeButtonClicked;

        public CarForm(ContractorsCars car)
        {
            InitializeComponent();

            _presenter = new CarFormPresenter(this);
            _presenter.SetCarData(car);
        }

        public void PopulateFuelTypesCombobox(List<FuelTypes> fuelTypes)
        {
            cmbFuelTypes.DataSource = null;
            cmbFuelTypes.DataSource = fuelTypes;

            cmbFuelTypes.ValueMember = nameof(FuelTypes.ID);
            cmbFuelTypes.DisplayMember = nameof(FuelTypes.Name);
        }

        public ContractorsCars GetCarData() => _presenter.GetCarData();

        private void btnConfirm_Click(object sender, EventArgs e) => ConfirmButtonClicked?.Invoke(sender, e);

        private void btnCancel_Click(object sender, EventArgs e) => CancelButtonClicked?.Invoke(sender, e);

        private void CarForm_Load(object sender, EventArgs e) => FormIsLoaded?.Invoke(sender, e);

        private void CarForm_FormClosing(object sender, FormClosingEventArgs e) => FormIsClosing?.Invoke(sender, e);

        public void ShowMessage(string message) => MessageBox.Show(message);

        public bool ConfirmAction(string message, string title) => MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;

        public void CloseForm() => this.Close();

        private void btnAddFuelType_Click(object sender, EventArgs e) => AddFuelTypeButtonClicked?.Invoke(sender, e);
    }
}
