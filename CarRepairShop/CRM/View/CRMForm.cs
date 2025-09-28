using CarRepairShop.CRM.DTO;
using CarRepairShop.CRM.Models;
using CarRepairShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Translations = CarRepairShop.Library.Texts;

namespace CarRepairShop.CRM.View
{
    public partial class CRMForm : Form, ICRMForm
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedContractorID
        {
            get { return cmbContractor.SelectedItem is ContractorModel contractor ? contractor.ID : 0; }
            set { cmbContractor.SelectedItem = cmbContractor.Items.OfType<ContractorModel>().FirstOrDefault(c => c.ID == value); }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedVehicleID
        {
            get => dgvContractorCars.SelectedRows
                .Cast<DataGridViewRow>()
                .Select(row => row.DataBoundItem as ContractorsCars)
                .Where(car => car != null)
                .Select(car => car.ID).FirstOrDefault();
            set
            {
                dgvContractorCars.Rows
                    .Cast<DataGridViewRow>()
                    .FirstOrDefault(r => (r.DataBoundItem as ContractorsCars).ID == value).Selected = true;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<int> SelectedRequiredServiceID
        {
            get => dgvRequiredServices.SelectedRows
                .Cast<DataGridViewRow>()
                .Select(row => row.DataBoundItem as Domain.Entities.Services)
                .Where(service => service != null)
                .Select(service => service.ID)
                .ToList();
            set
            {
                var selectedIds = new HashSet<int>(value);

                var rowsToSelect = dgvRequiredServices.Rows
                    .Cast<DataGridViewRow>()
                    .Where(row => selectedIds.Contains((row.DataBoundItem as Domain.Entities.Services).ID));

                rowsToSelect.ToList().ForEach(row => row.Selected = true);
            }
        }

        public int SelectedServiceID => dgvSelectedServices.SelectedRows
            .Cast<DataGridViewRow>()
            .Select(row => row.DataBoundItem as RequiredServicesModel)
            .Where(service => service != null)
            .Select(service => service.ID).FirstOrDefault();

        public Dictionary<int, int> SelectedServiceQuantities
        {
            get
            {
                var list = dgvSelectedServices.DataSource as List<RequiredServicesModel>;
                if (list == null)
                    return new Dictionary<int, int>();

                return list.ToDictionary(s => s.ID, s => s.Quantity);
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime CreationDate
        {
            get => DateTime.Parse(txtDateCreated.Text);
            set => txtDateCreated.Text = value.ToString("dd.MM.yyyy HH:mm");
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime CloseDate
        {
            get => DateTime.Parse(txtDateClosed.Text);
            set => txtDateClosed.Text = value.ToString("dd.MM.yyyy HH:mm");
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MechanicName { get => txtMechanicName.Text; set => txtMechanicName.Text = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MechanicSurname { get => txtMechanicSurname.Text; set => txtMechanicSurname.Text = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TaskComment { get => rtbTaskComment.Text; set => rtbTaskComment.Text = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public decimal TotalPrice { get => Convert.ToDecimal(string.IsNullOrEmpty(txtExpectedPrice.Text) ? null : txtExpectedPrice.Text); set => txtExpectedPrice.Text = Convert.ToDecimal(value).ToString(); }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool TaskClosed { get => cbTaskClosed.Checked; set => cbTaskClosed.Checked = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DialogResult OperationConfirmed { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int MechanicID { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public CRMFormResult Result
        {
            get => new CRMFormResult
            {
                OperationConfirmed = OperationConfirmed,
                CRM_Task = new CRM_Task
                {
                    ContractorID = SelectedContractorID,
                    CarID = SelectedVehicleID,
                    StartDate = CreationDate,
                    EndDate = TaskClosed ? DateTime.Now : (DateTime?)null,
                    MechanicID = MechanicID,
                    Comment = TaskComment,
                    Completed = TaskClosed,
                    Price = Convert.ToDouble(TotalPrice)
                },
                CRM_Services = SelectedServiceQuantities.Select(kv => new CRM_Services
                {
                    ServiceID = kv.Key,
                    Quantity = kv.Value
                }).ToList()
            };
        }

        public event EventHandler FormIsLoaded;
        public event EventHandler ComboboxSelectionChanged;
        public event EventHandler VehiclesDataGridViewCellClick;
        public event EventHandler RequiredServicesDataGridViewCellClick;
        public event EventHandler IncreaseQuantityButtonClicked;
        public event EventHandler DecreaseQuantityButtonClicked;
        public event EventHandler ConfirmButtonClicked;
        public event EventHandler CancelButtonClicked;
        public event EventHandler TaskClosedCheckBoxCheckedChanged;
        public event EventHandler<FormClosedEventArgs> FormIsClosed;

        private Presenter.CRMFormPresenter _presenter;

        public CRMForm(int? taskID)
        {
            InitializeComponent();
            _presenter = new Presenter.CRMFormPresenter(this, taskID);
        }

        public void LoadContractors(List<ContractorModel> contractors)
        {
            cmbContractor.DataSource = null;
            cmbContractor.DataSource = contractors;

            cmbContractor.DisplayMember = nameof(ContractorModel.FullName);
            cmbContractor.ValueMember = nameof(ContractorModel.ID);
        }

        public void LoadContractorVehicles(List<ContractorsCars> contractorsCars)
        {
            dgvContractorCars.DataSource = null;
            dgvContractorCars.DataSource = contractorsCars;

            dgvContractorCars.Columns[nameof(ContractorsCars.ID)].Visible = false;
            dgvContractorCars.Columns[nameof(ContractorsCars.ContractorID)].Visible = false;
            dgvContractorCars.Columns[nameof(ContractorsCars.ModelName)].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvContractorCars.Columns[nameof(ContractorsCars.EngineCapacity)].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvContractorCars.Columns[nameof(ContractorsCars.BrandName)].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvContractorCars.Columns[nameof(ContractorsCars.FuelTypeID)].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvContractorCars.Columns[nameof(ContractorsCars.LicensePlate)].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvContractorCars.Columns[nameof(ContractorsCars.Mileage)].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvContractorCars.Columns[nameof(ContractorsCars.Year)].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvContractorCars.Columns[nameof(ContractorsCars.ModelName)].HeaderText = Translations.CRMForm.ModelColumn;
            dgvContractorCars.Columns[nameof(ContractorsCars.EngineCapacity)].HeaderText = Translations.CRMForm.EngineCapacityColumn;
            dgvContractorCars.Columns[nameof(ContractorsCars.BrandName)].HeaderText = Translations.CRMForm.BrandColumn;
            dgvContractorCars.Columns[nameof(ContractorsCars.FuelTypeID)].HeaderText = Translations.CRMForm.FuelTypeColumn;
            dgvContractorCars.Columns[nameof(ContractorsCars.LicensePlate)].HeaderText = Translations.CRMForm.LicensePlateColumn;
            dgvContractorCars.Columns[nameof(ContractorsCars.Mileage)].HeaderText = Translations.CRMForm.MileageColumn;
            dgvContractorCars.Columns[nameof(ContractorsCars.Year)].HeaderText = Translations.CRMForm.ProductionYearColumn;

            dgvContractorCars.ClearSelection();
        }

        public void LoadRequiredServices(List<Domain.Entities.Services> services)
        {
            dgvRequiredServices.DataSource = null;
            dgvRequiredServices.DataSource = services;

            dgvRequiredServices.Columns[nameof(Domain.Entities.Services.Name)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRequiredServices.Columns[nameof(Domain.Entities.Services.ID)].Visible = false;
            dgvRequiredServices.Columns[nameof(Domain.Entities.Services.IsActive)].Visible = false;
            dgvRequiredServices.Columns[nameof(Domain.Entities.Services.Duration)].Visible = false;
            dgvRequiredServices.Columns[nameof(Domain.Entities.Services.WarrantyMonths)].Visible = false;
            dgvRequiredServices.Columns[nameof(Domain.Entities.Services.Name)].HeaderText = Translations.CRMForm.NameColumn;
            dgvRequiredServices.Columns[nameof(Domain.Entities.Services.StandardCost)].HeaderText = Translations.CRMForm.PriceColumn;

            dgvRequiredServices.ClearSelection();
        }

        public void LoadSelectedServices(List<RequiredServicesModel> services)
        {
            dgvSelectedServices.DataSource = null;
            dgvSelectedServices.DataSource = services;

            dgvSelectedServices.Columns[nameof(RequiredServicesModel.Name)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSelectedServices.Columns[nameof(RequiredServicesModel.ID)].Visible = false;
            dgvSelectedServices.Columns[nameof(RequiredServicesModel.Name)].HeaderText = Translations.CRMForm.NameColumn;
            dgvSelectedServices.Columns[nameof(RequiredServicesModel.Quantity)].HeaderText = Translations.CRMForm.QuantityColumn;
            dgvSelectedServices.Columns[nameof(RequiredServicesModel.Price)].HeaderText = Translations.CRMForm.PriceColumn;

            dgvSelectedServices.ClearSelection();
        }

        public void SelectAllSelectedServices() => dgvSelectedServices.Rows
            .Cast<DataGridViewRow>()
            .Where(row => row.DataBoundItem is RequiredServicesModel)
            .ToList()
            .ForEach(row => row.Selected = true);

        public void ChangeTaskStatus(bool taskClosed)
        {
            cbTaskClosed.Text = taskClosed ? Translations.CRMForm.Yes : Translations.CRMForm.No;
            cbTaskClosed.Checked = taskClosed;
            cbTaskClosed.ForeColor = taskClosed ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        }

        public void CloseForm() => this.Close();

        public void ShowMessage(string message, string title) => MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public bool ConfirmAction(string message, string title) => MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

        public void ChangeTaskClosedAccesability(bool enabled) => cbTaskClosed.Enabled = enabled;

        private void CRMForm_Load(object sender, EventArgs e) => FormIsLoaded?.Invoke(sender, e);

        private void cmbContractor_SelectedValueChanged(object sender, EventArgs e) => ComboboxSelectionChanged?.Invoke(sender, e);

        private void dgvContractorCars_CellClick(object sender, DataGridViewCellEventArgs e) => VehiclesDataGridViewCellClick?.Invoke(sender, e);

        private void dgvRequiredServices_CellClick(object sender, DataGridViewCellEventArgs e) => RequiredServicesDataGridViewCellClick?.Invoke(sender, e);

        private void btnIncrement_Click(object sender, EventArgs e) => IncreaseQuantityButtonClicked?.Invoke(sender, e);

        private void btnDecrement_Click(object sender, EventArgs e) => DecreaseQuantityButtonClicked?.Invoke(sender, e);

        private void btnConfirm_Click(object sender, EventArgs e) => ConfirmButtonClicked?.Invoke(sender, e);

        private void btnCancel_Click(object sender, EventArgs e) => CancelButtonClicked?.Invoke(sender, e);

        private void cbTaskClosed_CheckedChanged(object sender, EventArgs e) => TaskClosedCheckBoxCheckedChanged?.Invoke(sender, e);

        private void CRMForm_FormClosed(object sender, FormClosedEventArgs e) => FormIsClosed?.Invoke(sender, e);
    }
}
