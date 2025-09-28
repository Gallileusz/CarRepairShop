using CarRepairShop.Contractors.CarForm.DTO;
using CarRepairShop.Contractors.CarForm.Presenter;
using CarRepairShop.Domain.Entities;
using CarRepairShop.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CarRepairShop.Contractors.CarForm.View
{
    public partial class CarForm : Form, ICarForm
    {
        public event EventHandler FormIsLoaded;
        public event EventHandler ConfirmButtonClicked;
        public event EventHandler CancelButtonClicked;

        private readonly CarFormPresenter _presenter;

        public CarForm(int? id)
        {
            InitializeComponent();

            _presenter = new CarFormPresenter(this, new GenericRepository(), id);
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FormTitle { get => this.Text; set => this.Text = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DialogResult OperationConfirmed { get => this.DialogResult; set => this.DialogResult = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public CarFormResult CarFormResult
        {
            get
            {
                return new CarFormResult()
                {
                    Data = new ContractorsCars
                    {
                        BrandName = txtBrandName.Text,
                        ModelName = txtModelName.Text,
                        VIN = int.TryParse(txtVIN.Text, out int vin) ? vin : 0,
                        Year = int.TryParse(txtYear.Text, out int year) ? year : 0,
                        LicensePlate = txtLicensePlate.Text,
                        EngineCapacity = int.TryParse(txtEngineCapacity.Text, out int engineCapacity) ? engineCapacity : 0,
                        FuelTypeID = cmbFuelTypes.SelectedItem is FuelTypes selected ? selected.ID : 0,
                        Mileage = int.TryParse(txtMileage.Text, out int mileage) ? mileage : 0
                    },
                    OperationConfirmed = this.OperationConfirmed
                };
            }
            set
            {
                if (value == null || value.Data == null)
                {
                    txtBrandName.Text = string.Empty;
                    txtModelName.Text = string.Empty;
                    txtVIN.Text = string.Empty;
                    txtYear.Text = string.Empty;
                    txtLicensePlate.Text = string.Empty;
                    txtEngineCapacity.Text = string.Empty;
                    txtMileage.Text = string.Empty;
                    cmbFuelTypes.SelectedItem = null;
                    cmbFuelTypes.Text = string.Empty;
                    OperationConfirmed = DialogResult.None;
                }
                else
                {
                    txtBrandName.Text = value.Data.BrandName ?? string.Empty;
                    txtModelName.Text = value.Data.ModelName ?? string.Empty;
                    txtVIN.Text = value.Data.VIN.ToString();
                    txtYear.Text = value.Data.Year.ToString();
                    txtLicensePlate.Text = value.Data.LicensePlate ?? string.Empty;
                    txtEngineCapacity.Text = value.Data.EngineCapacity.ToString();
                    txtMileage.Text = value.Data.Mileage.ToString();

                    if (cmbFuelTypes.DataSource is List<FuelTypes> fuelList)
                    {
                        var fuel = fuelList.FirstOrDefault(f => f.ID == value.Data.FuelTypeID);
                        cmbFuelTypes.SelectedItem = fuel;
                    }
                    else
                        cmbFuelTypes.Text = string.Empty;

                    this.OperationConfirmed = value.OperationConfirmed;
                }
            }
        }

        public void PopulateFuelTypesCombobox(List<FuelTypes> fuelTypes)
        {
            cmbFuelTypes.DataSource = null;
            cmbFuelTypes.DataSource = fuelTypes;

            cmbFuelTypes.ValueMember = nameof(FuelTypes.ID);
            cmbFuelTypes.DisplayMember = nameof(FuelTypes.Name);
        }

        public void ShowMessage(string message) => MessageBox.Show(message);

        public bool ConfirmAction(string message, string title) => MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;

        public void CloseForm() => this.Close();

        private void btnConfirm_Click(object sender, EventArgs e) => ConfirmButtonClicked?.Invoke(sender, e);

        private void btnCancel_Click(object sender, EventArgs e) => CancelButtonClicked?.Invoke(sender, e);

        private void CarForm_Load(object sender, EventArgs e) => FormIsLoaded?.Invoke(sender, e);
    }
}
