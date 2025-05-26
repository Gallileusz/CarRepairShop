using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CarRepairShop.MainForm.Presenters.Tabs.User;
using CarRepairShop.MainForm.Views.Tabs.Users;

namespace CarRepairShop.MainForm.Views.Tabs.CRM
{
    public partial class UsersTab : UserControl, IUsersTabView
    {
        UsersTabPresenter _presenter;

        public int SelectedUserID
        {
            get
            {
                if (dgvUsers.CurrentRow?.DataBoundItem is Domain.Entities.Users user)
                    return user.ID;
                return 0;
            }
        }

        public string SearchedName => txtName.Text;

        public string SearchedSurname => txtSurname.Text;

        public event EventHandler AddUserButtonClicked;
        public event EventHandler EditUserButtonClicked;
        public event EventHandler DeleteUserButtonClicked;
        public event EventHandler FormLoaded;
        public event EventHandler ChangePasswordButtonClicked;
        public event EventHandler SearchNameChanged;
        public event EventHandler SearchSurameChanged;
        public event EventHandler DebounceTimerElapsed;

        public UsersTab()
        {
            InitializeComponent();
            Debounce.Stop();
            _presenter = new UsersTabPresenter(this);
        }

        public void LoadUsersToGrid(List<Domain.Entities.Users> users)
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = users;

            dgvUsers.Columns[nameof(Domain.Entities.Users.Name)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvUsers.Columns[nameof(Domain.Entities.Users.Surname)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvUsers.Columns[nameof(Domain.Entities.Users.ID)].Visible = false;
            if (!CurrentUser.Data.Admin)
                dgvUsers.Columns[nameof(Domain.Entities.Users.Admin)].Visible = false;
        }

        public void ShowMessage(string message) => MessageBox.Show(message);

        public bool ConfirmAction(string message, string title) => MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;

        private void UsersTab_Load(object sender, EventArgs e) => FormLoaded?.Invoke(sender, e);

        private void btnEdit_Click(object sender, EventArgs e) => EditUserButtonClicked?.Invoke(sender, e);

        private void btnAdd_Click(object sender, EventArgs e) => AddUserButtonClicked?.Invoke(sender, e);

        private void btnDelete_Click(object sender, EventArgs e) => DeleteUserButtonClicked?.Invoke(sender, e);

        private void btnChangePassword_Click(object sender, EventArgs e) => ChangePasswordButtonClicked?.Invoke(sender, e);

        private void Debounce_Tick(object sender, EventArgs e)
        {
            Debounce.Stop();
            DebounceTimerElapsed?.Invoke(this, e);
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            Debounce.Stop();
            Debounce.Start();

            SearchNameChanged?.Invoke(this, e);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Debounce.Stop();
            Debounce.Start();

            SearchSurameChanged?.Invoke(this, e);
        }
    }
}
