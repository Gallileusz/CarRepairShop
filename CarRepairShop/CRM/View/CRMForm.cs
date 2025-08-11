using CarRepairShop.CRM.Model;
using CarRepairShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CarRepairShop.CRM.View
{
    public partial class CRMForm : Form, ICRMForm
    {
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public int SelectedContractorID
        {
            get { return cmbContractor.SelectedItem is Model.ContractorModel contractor ? contractor.ID : 0; }
            set { cmbContractor.SelectedItem = cmbContractor.Items.OfType<Model.ContractorModel>().FirstOrDefault(c => c.ID == value); }
        }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public int SelectedVehicleID
        {
            get
            {
                return dgvContractorCars.SelectedRows
                    .Cast<DataGridViewRow>()
                    .Select(row => row.DataBoundItem as ContractorsCars)
                    .Where(car => car != null)
                    .Select(car => car.ID).FirstOrDefault();
            }
            set
            {
                dgvContractorCars.Rows
                    .Cast<DataGridViewRow>()
                    .FirstOrDefault(r => (r.DataBoundItem as ContractorsCars).ID == value).Selected = true;
            }
        }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public List<int> SelectedRequiredServiceID
        {
            get
            {
                return dgvRequiredServices.SelectedRows
                    .Cast<DataGridViewRow>()
                    .Select(row => row.DataBoundItem as Domain.Entities.Services)
                    .Where(service => service != null)
                    .Select(service => service.ID)
                    .ToList();
            }
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
            .Select(row => row.DataBoundItem as Model.RequiredServicesModel)
            .Where(service => service != null)
            .Select(service => service.ID).FirstOrDefault();

        public Dictionary<int, int> SelectedServiceQuantities
        {
            get
            {
                var list = dgvSelectedServices.DataSource as List<Model.RequiredServicesModel>;
                if (list == null)
                    return new Dictionary<int, int>();

                return list.ToDictionary(s => s.ID, s => s.Quantity);
            }
        }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public DateTime CreationDate
        {
            get => DateTime.Parse(txtDateCreated.Text);
            set => txtDateCreated.Text = value.ToString("yyyy-MM-dd HH:mm");
        }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public DateTime CloseDate
        {
            get => DateTime.Parse(txtDateClosed.Text);
            set => txtDateClosed.Text = value.ToString("yyyy-MM-dd HH:mm");
        }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string MechanicName { get => txtMechanicName.Text; set => txtMechanicName.Text = value; }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string MechanicSurname { get => txtMechanicSurname.Text; set => txtMechanicSurname.Text = value; }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string TaskComment { get => rtbTaskComment.Text; set => rtbTaskComment.Text = value; }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public decimal TotalPrice { get => Convert.ToDecimal(string.IsNullOrEmpty(txtExpectedPrice.Text) ? null : txtExpectedPrice.Text); set => txtExpectedPrice.Text = Convert.ToDecimal(value).ToString(); }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public bool TaskClosed { get => cbTaskClosed.Checked; set => cbTaskClosed.Checked = value; }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public DialogResult OperationConfirmed { get; set; }

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

        public void LoadContractors(List<Model.ContractorModel> contractors)
        {
            cmbContractor.DataSource = null;

            cmbContractor.DataSource = contractors;
            cmbContractor.DisplayMember = nameof(Model.ContractorModel.FullName);
            cmbContractor.ValueMember = nameof(Model.ContractorModel.ID);
        }

        public void LoadContractorVehicles(List<ContractorsCars> contractorsCars)
        {
            dgvContractorCars.DataSource = null;

            dgvContractorCars.DataSource = contractorsCars;
            dgvContractorCars.Columns[nameof(ContractorsCars.ID)].Visible = false;
            dgvContractorCars.Columns[nameof(ContractorsCars.ContractorID)].Visible = false;

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
            dgvRequiredServices.ClearSelection();
        }

        public void LoadSelectedServices(List<Model.RequiredServicesModel> services)
        {
            dgvSelectedServices.DataSource = null;

            dgvSelectedServices.DataSource = services;
            dgvSelectedServices.Columns[nameof(Model.RequiredServicesModel.Name)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSelectedServices.Columns[nameof(Model.RequiredServicesModel.ID)].Visible = false;

            dgvSelectedServices.ClearSelection();
        }

        public void SelectAllSelectedServices() => dgvSelectedServices.Rows
            .Cast<DataGridViewRow>()
            .Where(row => row.DataBoundItem is RequiredServicesModel)
            .ToList()
            .ForEach(row => row.Selected = true);

        public void ChangeTaskStatus(bool taskClosed)
        {
            cbTaskClosed.Text = taskClosed ? "Yes" : "No";
            cbTaskClosed.Checked = taskClosed;
            cbTaskClosed.ForeColor = taskClosed ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        }

        public void CloseForm() => this.Close();

        public void ShowMessage(string message, string title) => MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public bool ConfirmAction(string message, string title) => MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

        public void ChangeTaskClosedAccesability(bool enabled) => cbTaskClosed.Enabled = enabled;

        //
        // Events
        //

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
