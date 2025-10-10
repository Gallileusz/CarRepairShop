using CarRepairShop.AppSettings.CurrentUser.Service;
using CarRepairShop.ConsumableMaterialForm.View;
using CarRepairShop.Domain.Entities;
using CarRepairShop.MainForm.Models.Tabs.Warehouse;
using CarRepairShop.MainForm.Views.Tabs.Warehouse;
using CarRepairShop.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Translations = CarRepairShop.Library.Texts;

namespace CarRepairShop.MainForm.Views.Tabs.CRM
{
    public partial class WarehouseTab : UserControl, IWarehouseTab
    {
        public event EventHandler FormLoaded;
        public event EventHandler AddMaterialButtonClicked;
        public event EventHandler EditMaterialButtonClicked;
        public event EventHandler DeleteMaterialButtonClicked;
        public event EventHandler SearchTextChanged;
        public event EventHandler DebounceElapsed;
        public event EventHandler SelectedMaterialTypeChanged;
        public event EventHandler ConsumableMaterialsTypesButtonClicked;

        public int SelectedID => dgvWarehouse.CurrentRow?.DataBoundItem is ConsumableMaterialVM material ? material.ID : 0;

        public string SearchedName => txtName.Text;

        public int SearchedMaterialTypeID => cmbMaterialType.SelectedItem is MaterialTypes type ? type.ID : 0;

        private Presenters.Tabs.Warehouse.WarehouseTabPresenter _presenter;

        public WarehouseTab()
        {
            InitializeComponent();
            _presenter = new Presenters.Tabs.Warehouse.WarehouseTabPresenter(this, new GenericRepository(), new CurrentUserService());
        }

        public void SetButtonsAccesability(bool hasEditPermissions)
        {
            btnAdd.Enabled = hasEditPermissions;
            btnEdit.Enabled = hasEditPermissions;
            btnDelete.Enabled = hasEditPermissions;
        }

        public void ShowMessage(string message) => MessageBox.Show(message);

        public bool ConfirmAction(string message, string title) => MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;

        public void LoadMaterialsToGrid(List<ConsumableMaterialVM> materials)
        {
            dgvWarehouse.DataSource = null;
            dgvWarehouse.DataSource = materials;

            dgvWarehouse.Columns[nameof(ConsumableMaterialVM.ID)].Visible = false;
            dgvWarehouse.Columns[nameof(ConsumableMaterialVM.Name)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvWarehouse.Columns[nameof(ConsumableMaterialVM.MaterialTypeName)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvWarehouse.Columns[nameof(ConsumableMaterialVM.Name)].HeaderText = Translations.MainView.Warehouse.MaterialName;
            dgvWarehouse.Columns[nameof(ConsumableMaterialVM.MaterialTypeName)].HeaderText = Translations.MainView.Warehouse.MaterialTypeName;
            dgvWarehouse.Columns[nameof(ConsumableMaterialVM.Quantity)].HeaderText = Translations.MainView.Warehouse.Quantity;
        }

        public void LoadMaterialTypesToCombobox(List<MaterialTypes> materialTypes)
        {
            cmbMaterialType.DataSource = null;
            cmbMaterialType.DataSource = materialTypes;

            cmbMaterialType.DisplayMember = nameof(MaterialTypes.Name);
            cmbMaterialType.ValueMember = nameof(MaterialTypes.ID);
            cmbMaterialType.SelectedIndex = 0;
        }

        public void StopDebounce() => Debounce.Stop();

        public void StartDebounce()
        {
            Debounce.Stop();
            Debounce.Start();
        }

        public DialogResult ShowMaterialTypesForm()
        {
            var form = new CarRepairShop.Warehouse.MaterialsTypesList.View.MaterialsTypesList();
            form.ShowDialog();

            return form.DialogResult;
        }

        public ReturnedConsumableMaterial ShowConsumableMaterialsForm(int? id, string title)
        {
            var form = new ConsumableMaterial(id);
            if (!string.IsNullOrEmpty(title))
                form.Text = title;

            form.ShowDialog();

            return form.GetReturnedConsumableMaterial;
        }

        private void WarehouseTab_Load(object sender, EventArgs e) => FormLoaded?.Invoke(this, e);

        private void btnAdd_Click(object sender, EventArgs e) => AddMaterialButtonClicked?.Invoke(this, e);

        private void btnEdit_Click(object sender, EventArgs e) => EditMaterialButtonClicked?.Invoke(this, e);

        private void btnDelete_Click(object sender, EventArgs e) => DeleteMaterialButtonClicked?.Invoke(this, e);

        private void Debounce_Tick(object sender, EventArgs e) => DebounceElapsed?.Invoke(this, e);

        private void txtName_TextChanged(object sender, EventArgs e) => SearchTextChanged?.Invoke(this, e);

        private void cmbMaterialType_SelectedIndexChanged(object sender, EventArgs e) => SelectedMaterialTypeChanged?.Invoke(this, e);

        private void btnMaterialTypes_Click(object sender, EventArgs e) => ConsumableMaterialsTypesButtonClicked?.Invoke(sender, e);

        //dodaj obsluzenie przycisku + nowy formularz do pokazania i dodawania edytowania.
        // usun z eventu debounce stop/start i zrob funkcje na widoku i wywolaj z prezentera, dodaj event DebounceElapsed 
        // sprawdz czy z ConsumableMaterialForm po dodaniu doda obiekt do comboboxa
    }
}
