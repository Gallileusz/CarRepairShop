using CarRepairShop.AppSettings.CurrentUser.Service;
using CarRepairShop.CRM.DTO;
using CarRepairShop.CRM.View;
using CarRepairShop.MainForm.Models.Tabs.CRM;
using CarRepairShop.MainForm.Presenters.Tabs.CRM;
using CarRepairShop.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Translations = CarRepairShop.Library.Texts;

namespace CarRepairShop.MainForm.Views.Tabs.CRM
{
    public partial class CRMTab : UserControl, ICRMTab
    {
        public event EventHandler AddButtonClicked;
        public event EventHandler EditButtonClicked;
        public event EventHandler DeleteButtonClicked;
        public event EventHandler FormIsLoaded;
        public event EventHandler DebounceElapsed;
        public event EventHandler FilterChanged;

        public int SelectedCRMTaskID => dgvCRM.SelectedRows
            .Cast<DataGridViewRow>()
            .Select(row => row.DataBoundItem as CRM_Model)
            .Where(crm => crm != null)
            .Select(crm => crm.ID)
            .FirstOrDefault();

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public DateTime FilterDateFrom { get => dtpDateFrom.Value; set => dtpDateFrom.Value = value; }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public DateTime FilterDateTo => dtpDateTo.Value;

        public string FilterContractorFullName => txtContractorFullname.Text;

        public string FilterMechanicFullName => txtMechanicFullname.Text;

        public bool FilterShowAllChecked => rbAll.Checked;

        public bool FilterShowCompletedChecked => rbClosed.Checked;

        public bool FilterShowNotCompletedChecked => rbNotClosed.Checked;

        private readonly CRMTabPresenter _presenter;

        public CRMTab()
        {
            InitializeComponent();
            _presenter = new CRMTabPresenter(this, new GenericRepository(), new CurrentUserService());
        }

        public CRMFormResult OpenCRMForm(int? crmTaskID = null)
        {
            var form = new CRMForm(crmTaskID);
            form.ShowDialog();

            return form.Result;
        }

        public void PopulateCRMTasksGrid(List<CRM_Model> crms)
        {
            dgvCRM.DataSource = null;
            dgvCRM.DataSource = crms;

            dgvCRM.Columns[nameof(CRM_Model.ID)].Visible = false;
            dgvCRM.Columns[nameof(CRM_Model.TaskCreatorFullname)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCRM.Columns[nameof(CRM_Model.CustomerFullname)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCRM.Columns[nameof(CRM_Model.Description)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCRM.Columns[nameof(CRM_Model.VehicleDetails)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCRM.Columns[nameof(CRM_Model.Services)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCRM.Columns[nameof(CRM_Model.StartDate)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCRM.Columns[nameof(CRM_Model.EndDate)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCRM.Columns[nameof(CRM_Model.Price)].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCRM.Columns[nameof(CRM_Model.Completed)].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            dgvCRM.Columns[nameof(CRM_Model.TaskCreatorFullname)].HeaderText = Translations.MainView.CRM.ColumnMechanic;
            dgvCRM.Columns[nameof(CRM_Model.CustomerFullname)].HeaderText = Translations.MainView.CRM.ColumnContractor;
            dgvCRM.Columns[nameof(CRM_Model.Description)].HeaderText = Translations.MainView.CRM.ColumnDescription;
            dgvCRM.Columns[nameof(CRM_Model.VehicleDetails)].HeaderText = Translations.MainView.CRM.ColumnVehicleData;
            dgvCRM.Columns[nameof(CRM_Model.Services)].HeaderText = Translations.MainView.CRM.ColumnServices;
            dgvCRM.Columns[nameof(CRM_Model.StartDate)].HeaderText = Translations.MainView.CRM.ColumnStartDate;
            dgvCRM.Columns[nameof(CRM_Model.EndDate)].HeaderText = Translations.MainView.CRM.ColumnCloseDate;
            dgvCRM.Columns[nameof(CRM_Model.Price)].HeaderText = Translations.MainView.CRM.ColumnPrice;
            dgvCRM.Columns[nameof(CRM_Model.Completed)].HeaderText = Translations.MainView.CRM.ColumnCompleted;

            dgvCRM.Rows.Cast<DataGridViewRow>().ToList().ForEach(row =>
            {
                if (row.DataBoundItem is CRM_Model model)
                {
                    row.DefaultCellStyle.BackColor = model.Completed ? Color.SteelBlue : Color.Gray;
                    row.DefaultCellStyle.ForeColor = model.Completed ? Color.White : Color.Black;
                    row.DefaultCellStyle.SelectionBackColor = Color.White;
                    row.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
            });
        }

        public void StopDebounce() => Debounce.Stop();

        public void StartDebounce()
        {
            Debounce.Stop();
            Debounce.Start();
        }

        public bool ConfirmAction(string message, string title) => MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;

        public void ShowMessage(string message) => MessageBox.Show(message);

        public void ChangeButtonAccess(bool enabled)
        {
            btnAdd.Enabled = enabled;
            btnEdit.Enabled = enabled;
            btnDelete.Enabled = enabled;
        }

        private void CRMTab_Load(object sender, EventArgs e) => FormIsLoaded?.Invoke(sender, e);

        private void btnAdd_Click(object sender, EventArgs e) => AddButtonClicked?.Invoke(sender, e);

        private void btnDelete_Click(object sender, EventArgs e) => DeleteButtonClicked?.Invoke(sender, e);

        private void btnEdit_Click(object sender, EventArgs e) => EditButtonClicked?.Invoke(sender, e);

        private void Debounce_Tick(object sender, EventArgs e) => DebounceElapsed?.Invoke(sender, e);

        private void dtpDateFrom_ValueChanged(object sender, EventArgs e) => FilterChanged?.Invoke(sender, e);

        private void dtpDateTo_ValueChanged(object sender, EventArgs e) => FilterChanged?.Invoke(sender, e);

        private void txtContractorFullname_TextChanged(object sender, EventArgs e) => FilterChanged?.Invoke(sender, e);

        private void txtMechanicFullname_TextChanged(object sender, EventArgs e) => FilterChanged?.Invoke(sender, e);

        private void rbAll_CheckedChanged(object sender, EventArgs e) => FilterChanged?.Invoke(sender, e);

        private void rbClosed_CheckedChanged(object sender, EventArgs e) => FilterChanged?.Invoke(sender, e);

        private void rbNotClosed_CheckedChanged(object sender, EventArgs e) => FilterChanged?.Invoke(sender, e);
    }
}
