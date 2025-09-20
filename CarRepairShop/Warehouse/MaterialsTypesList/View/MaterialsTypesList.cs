using CarRepairShop.Domain.Entities;
using CarRepairShop.Utilities.SingleInputForm.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Translations = CarRepairShop.Library.Texts;

namespace CarRepairShop.Warehouse.MaterialsTypesList.View
{
    public partial class MaterialsTypesList : Form, IMaterialTypesList
    {
        public event EventHandler FormLoaded;
        public event EventHandler AddMaterialTypeButtonClicked;
        public event EventHandler EditMaterialTypeButtonClicked;
        public event EventHandler DeleteMaterialTypeButtonClicked;
        public event EventHandler FormIsClosing;
        public event EventHandler CloseButtonClicked;

        public int SelectedID => dgv.CurrentRow?.DataBoundItem is MaterialTypes materialType ? materialType.ID : 0;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DialogResult ChangesAccured { get => this.DialogResult; set => this.DialogResult = value; }

        private readonly Presenter.MaterialsTypesListPresenter _presenter;

        public MaterialsTypesList()
        {
            InitializeComponent();
            _presenter = new Presenter.MaterialsTypesListPresenter(this, new Repositories.GenericRepository(), new AppSettings.CurrentUserService());
        }

        public void LoadMaterialTypesToGrid(List<MaterialTypes> materialTypes)
        {
            dgv.DataSource = null;
            dgv.DataSource = materialTypes;

            dgv.Columns[nameof(MaterialTypes.Name)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[nameof(MaterialTypes.ID)].Visible = false;
            dgv.Columns[nameof(MaterialTypes.Name)].HeaderText = Translations.MaterialsTypesList.MaterialTypeName;
        }

        public void ShowMessage(string message) => MessageBox.Show(message);

        public bool ConfirmAction(string message, string title) => MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;

        public string ShowInputDialog(string title, string value)
        {
            var form = new SingleInputForm(title, value);
            form.ShowDialog();

            return form.Value;
        }

        public void SetButtonsAccessability(bool hasEditPermissions)
        {
            btnAdd.Enabled = hasEditPermissions;
            btnEdit.Enabled = hasEditPermissions;
            btnDelete.Enabled = hasEditPermissions;
        }

        public void CloseForm() => this.Close();

        private void btnAdd_Click(object sender, EventArgs e) => AddMaterialTypeButtonClicked?.Invoke(sender, e);

        private void btnEdit_Click(object sender, EventArgs e) => EditMaterialTypeButtonClicked?.Invoke(sender, e);

        private void btnDelete_Click(object sender, EventArgs e) => DeleteMaterialTypeButtonClicked?.Invoke(sender, e);

        private void btnClose_Click(object sender, EventArgs e) => CloseButtonClicked?.Invoke(sender, e);

        private void MaterialsTypesList_Load(object sender, EventArgs e) => FormLoaded?.Invoke(this, e);

        private void MaterialsTypesList_FormClosing(object sender, FormClosingEventArgs e) => FormIsClosing?.Invoke(this, e);
    }
}
