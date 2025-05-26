using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CarRepairShop.ConsumableMaterialForm.Presenter;
using CarRepairShop.Domain.Entities;

namespace CarRepairShop.ConsumableMaterialForm.View
{
    public partial class ConsumableMaterial : Form, IConsumableMaterial
    {
        private ConsumableMaterialPresenter _presenter;

        public event EventHandler FormIsLoaded;
        public event EventHandler FormIsClosing;
        public event EventHandler ConfirmButtonClicked;
        public event EventHandler CancelButtonClicked;
        public event EventHandler IncrementButtonClicked;
        public event EventHandler ReductButtonClicked;
        public event EventHandler AddNewMaterialTypeButtonClicked;

        public ConsumableMaterial(ConsumableMaterials consumableMaterial)
        {
            InitializeComponent();
            _presenter = new ConsumableMaterialPresenter(this);
            _presenter.SetConsuambleMaterial(consumableMaterial);
        }

        public string FormTitle
        {
            get
            {
                return this.Text;
            }
            set
            {
                this.Text = value;
            }
        }

        public int QuantityValue
        {
            get
            {
                if (int.TryParse(txtQuantity.Text, out int result))
                    return result;
                return 0;
            }
            set
            {
                txtQuantity.Text = value.ToString();
            }
        }

        public string MaterialName
        {
            get
            {
                return txtMaterialName.Text;
            }
            set
            {
                txtMaterialName.Text = value;
            }
        }

        public string MaterialTypeName
        {
            get
            {
                if (cmbMaterialTypes.SelectedItem is MaterialTypes selected)
                    return selected.Name;
                return string.Empty;
            }
            set
            {
                if (cmbMaterialTypes.DataSource is List<MaterialTypes> list)
                {
                    var material = list.FirstOrDefault(x => x.Name == value);
                    cmbMaterialTypes.SelectedItem = material;
                }
            }
        }

        public ConsumableMaterials GetConsumableMaterial => _presenter.GetConsumableMaterial();

        public void ShowMessage(string message) => MessageBox.Show(message);

        public bool ConfirmAction(string message, string title) => MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;

        public void CloseForm() => this.Close();

        public void PopulateCombobox(List<MaterialTypes> materialTypes)
        {
            cmbMaterialTypes.DataSource = null;
            cmbMaterialTypes.DataSource = materialTypes;

            cmbMaterialTypes.ValueMember = nameof(MaterialTypes.ID);
            cmbMaterialTypes.DisplayMember = nameof(MaterialTypes.Name);
        }

        private void ConsumableMaterial_Load(object sender, EventArgs e) => FormIsLoaded?.Invoke(this, e);

        private void ConsumableMaterial_FormClosing(object sender, FormClosingEventArgs e) => FormIsClosing?.Invoke(this, e);

        private void btnAddMaterialType_Click(object sender, EventArgs e) => AddNewMaterialTypeButtonClicked?.Invoke(this, e);

        private void btnIncrementQuantity_Click(object sender, EventArgs e) => IncrementButtonClicked?.Invoke(this, e);

        private void btnReduceQuantity_Click(object sender, EventArgs e) => ReductButtonClicked?.Invoke(this, e);

        private void btnConfirm_Click(object sender, EventArgs e) => ConfirmButtonClicked?.Invoke(this, e);

        private void btnCancel_Click(object sender, EventArgs e) => CancelButtonClicked?.Invoke(this, e);
    }
}
