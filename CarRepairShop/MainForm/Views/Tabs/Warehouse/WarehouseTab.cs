using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CarRepairShop.Domain.Entities;
using CarRepairShop.MainForm.Views.Tabs.Warehouse;

namespace CarRepairShop.MainForm.Views.Tabs.CRM
{
    public partial class WarehouseTab : UserControl, IWarehouseTab
    {
        private Presenters.Tabs.Warehouse.WarehouseTabPresenter _presenter;
        public int SelectedConsumableMaterialID
        {
            get
            {
                if (dgvWarehouse.CurrentRow?.DataBoundItem is ConsumableMaterials material)
                    return material.ID;
                return 0;
            }
        }

        public string SearchedName
        {
            get
            {
                return txtName.Text;
            }
        }

        public MaterialTypes SearchedMaterialType => cmbMaterialType.SelectedItem as MaterialTypes;

        public event EventHandler FormLoaded;
        public event EventHandler AddMaterialButtonClicked;
        public event EventHandler EditMaterialButtonClicked;
        public event EventHandler DeleteMaterialButtonClicked;
        public event EventHandler SearchTextChanged;
        public event EventHandler DebounceTimerElapsed;
        public event EventHandler SelectedMaterialTypeChanged;

        public WarehouseTab()
        {
            InitializeComponent();
            Debounce.Stop();
            _presenter = new Presenters.Tabs.Warehouse.WarehouseTabPresenter(this);
        }

        public void ShowMessage(string message) => MessageBox.Show(message);

        public bool ConfirmAction(string message, string title) => MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;

        public void LoadMaterialsToGrid(List<ConsumableMaterials> materials)
        {
            dgvWarehouse.DataSource = null;
            dgvWarehouse.DataSource = materials;

            dgvWarehouse.Columns[nameof(ConsumableMaterials.Name)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvWarehouse.Columns[nameof(ConsumableMaterials.MaterialTypeName)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void WarehouseTab_Load(object sender, EventArgs e) => FormLoaded?.Invoke(this, e);

        private void btnAdd_Click(object sender, EventArgs e) => AddMaterialButtonClicked?.Invoke(this, e);

        private void btnEdit_Click(object sender, EventArgs e) => EditMaterialButtonClicked?.Invoke(this, e);

        private void btnDelete_Click(object sender, EventArgs e) => DeleteMaterialButtonClicked?.Invoke(this, e);

        private void Debounce_Tick(object sender, EventArgs e)
        {
            Debounce.Stop();
            DebounceTimerElapsed?.Invoke(this, e);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Debounce.Stop();
            Debounce.Start();

            SearchTextChanged?.Invoke(this, e);
        }

        public void LoadMaterialTypesToCombobox(List<MaterialTypes> materialTypes)
        {
            cmbMaterialType.DataSource = null;
            cmbMaterialType.DataSource = materialTypes;

            cmbMaterialType.DisplayMember = nameof(MaterialTypes.Name);
            cmbMaterialType.ValueMember = nameof(MaterialTypes.ID);
            cmbMaterialType.SelectedIndex = 0;
        }

        private void cmbMaterialType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debounce.Stop();
            Debounce.Start();

            SelectedMaterialTypeChanged?.Invoke(this, e);
        }
    }
}
