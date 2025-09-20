using CarRepairShop.AppSettings;
using CarRepairShop.Contractors.FuelTypesList.Presenter;
using CarRepairShop.Domain.Entities;
using CarRepairShop.Repositories;
using CarRepairShop.Utilities.SingleInputForm.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Translations = CarRepairShop.Library.Texts;

namespace CarRepairShop.Contractors.FuelTypesList.View
{
    public partial class FuelTypesList : Form, IFuelTypesList
    {
        public event EventHandler FormLoaded;
        public event EventHandler AddFuelTypeButtonClicked;
        public event EventHandler EditFuelTypeButtonClicked;
        public event EventHandler DeleteFuelTypeButtonClicked;
        public event EventHandler CloseButtonClicked;

        public int SelectedID => dgv.CurrentRow?.DataBoundItem is FuelTypes fuelType ? fuelType.ID : 0;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public DialogResult ChangesAccured { get => this.DialogResult; set => this.DialogResult = value; }

        private readonly FuelTypesListPresenter _presenter;

        public FuelTypesList()
        {
            InitializeComponent();
            _presenter = new FuelTypesListPresenter(this, new GenericRepository(), new CurrentUserService());
        }

        public void CloseForm() => this.Close();

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

        public void LoadFuelTypesToGrid(List<FuelTypes> fuelTypes)
        {
            dgv.DataSource = null;
            dgv.DataSource = fuelTypes;

            dgv.Columns[nameof(FuelTypes.Name)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[nameof(FuelTypes.ID)].Visible = false;
            dgv.Columns[nameof(FuelTypes.Name)].HeaderText = Translations.FuelTypesList.Name;
        }

        private void FuelTypesList_Load(object sender, EventArgs e) => FormLoaded?.Invoke(sender, e);

        private void btnAdd_Click(object sender, EventArgs e) => AddFuelTypeButtonClicked?.Invoke(sender, e);

        private void btnEdit_Click(object sender, EventArgs e) => EditFuelTypeButtonClicked?.Invoke(sender, e);

        private void btnDelete_Click(object sender, EventArgs e) => DeleteFuelTypeButtonClicked?.Invoke(sender, e);

        private void btnClose_Click(object sender, EventArgs e) => CloseButtonClicked?.Invoke(sender, e);
    }
}
