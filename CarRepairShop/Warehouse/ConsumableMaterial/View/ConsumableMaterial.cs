using CarRepairShop.Domain.Entities;
using CarRepairShop.MainForm.Models.Tabs.Warehouse;
using CarRepairShop.Warehouse.ConsumableMaterial.Presenter;
using CarRepairShop.Warehouse.ConsumableMaterial.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CarRepairShop.ConsumableMaterialForm.View
{
    public partial class ConsumableMaterial : Form, IConsumableMaterial
    {
        public event EventHandler FormIsLoaded;
        public event EventHandler FormIsClosing;
        public event EventHandler ConfirmButtonClicked;
        public event EventHandler CancelButtonClicked;
        public event EventHandler IncrementButtonClicked;
        public event EventHandler ReductButtonClicked;

        private readonly ConsumableMaterialPresenter _presenter;

        public ConsumableMaterial(int? id)
        {
            InitializeComponent();
            _presenter = new ConsumableMaterialPresenter(this, id);
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DialogResult OperationConfirmed { get => DialogResult; set => DialogResult = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FormTitle
        {
            get => this.Text;
            set => this.Text = value;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int QuantityValue
        {
            get
            {
                if (int.TryParse(txtQuantity.Text, out int result))
                    return result;
                return 0;
            }
            set => txtQuantity.Text = value.ToString();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MaterialName
        {
            get => txtMaterialName.Text;
            set => txtMaterialName.Text = value;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int MaterialTypeID
        {
            get
            {
                if (cmbMaterialTypes.SelectedItem is MaterialTypes selected)
                    return selected.ID;
                return 0;
            }
            set
            {
                if (cmbMaterialTypes.DataSource is List<MaterialTypes> list)
                {
                    var material = list.FirstOrDefault(x => x.ID == value);
                    cmbMaterialTypes.SelectedItem = material;
                }
            }
        }

        public ConsumableMaterials GetConsumableMaterial => new ConsumableMaterials
        {
            Name = MaterialName,
            Quantity = QuantityValue,
            MaterialTypeID = MaterialTypeID
        };

        public ReturnedConsumableMaterial GetReturnedConsumableMaterial => new ReturnedConsumableMaterial
        {
            OperationConfirmed = this.OperationConfirmed,
            ConsumableMaterial = this.GetConsumableMaterial
        };

        public void PopulateCombobox(List<MaterialTypes> materialTypes)
        {
            cmbMaterialTypes.DataSource = null;
            cmbMaterialTypes.DataSource = materialTypes;

            cmbMaterialTypes.ValueMember = nameof(MaterialTypes.ID);
            cmbMaterialTypes.DisplayMember = nameof(MaterialTypes.Name);
        }

        public void ShowMessage(string message) => MessageBox.Show(message);

        public bool ConfirmAction(string message, string title) => MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;

        public void CloseForm() => this.Close();

        private void ConsumableMaterial_Load(object sender, EventArgs e) => FormIsLoaded?.Invoke(this, e);

        private void ConsumableMaterial_FormClosing(object sender, FormClosingEventArgs e) => FormIsClosing?.Invoke(this, e);

        private void btnIncrementQuantity_Click(object sender, EventArgs e) => IncrementButtonClicked?.Invoke(this, e);

        private void btnReduceQuantity_Click(object sender, EventArgs e) => ReductButtonClicked?.Invoke(this, e);

        private void btnConfirm_Click(object sender, EventArgs e) => ConfirmButtonClicked?.Invoke(this, e);

        private void btnCancel_Click(object sender, EventArgs e) => CancelButtonClicked?.Invoke(this, e);
    }
}
