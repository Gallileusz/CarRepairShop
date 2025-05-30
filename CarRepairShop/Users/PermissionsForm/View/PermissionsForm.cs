using CarRepairShop.Users.PermissionsForm.Model;
using CarRepairShop.Users.PermissionsForm.Presenter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarRepairShop.Users.PermissionsForm.View
{
    public partial class PermissionsForm : Form, IPermissionsView
    {
        private PermissionsFormPresenter _presenter;

        public event EventHandler ConfirmClicked;
        public event EventHandler CancelClicked;
        public event EventHandler FormLoaded;

        public string FormTitle { get => this.Text; set => this.Text = value; }

        public List<PermissionModel> GetSelectedPermissions { get => dgv.DataSource as List<PermissionModel>; }

        public PermissionsForm(Domain.Entities.Users user)
        {
            InitializeComponent();
            _presenter = new PermissionsFormPresenter(this, user);
        }

        private void PermissionsForm_Load(object sender, EventArgs e) => FormLoaded?.Invoke(sender, e);

        private void btnConfirm_Click(object sender, EventArgs e) => ConfirmClicked?.Invoke(sender, e);

        private void btnCancel_Click(object sender, EventArgs e) => CancelClicked?.Invoke(sender, e);

        public void ShowMessage(string message) => MessageBox.Show(message);

        public bool ConfirmAction(string message, string title) => MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

        public void CloseForm() => this.Close();

        public void PopulateDatagridView(List<PermissionModel> permissionModels)
        {
            dgv.DataSource = null;
            dgv.DataSource = permissionModels;

            dgv.Columns[nameof(PermissionModel.PermissionName)].ReadOnly = true;
            dgv.Columns[nameof(PermissionModel.PermissionName)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[nameof(PermissionModel.PermissionID)].Visible = false;
            dgv.Columns[nameof(PermissionModel.UserID)].Visible = false;
        }
    }
}
