using CarRepairShop.AppSettings.CurrentUser.Service;
using CarRepairShop.Repositories;
using CarRepairShop.Users.UserInfoForm.Model;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarRepairShop.Users.UserInfoForm.View
{
    public partial class UsersInfoForm : Form, IUsersInfoForm
    {
        public event EventHandler FormLoaded;
        public event EventHandler CancelButtonClicked;
        public event EventHandler ConfirmButtonClicked;
        public event FormClosingEventHandler FormIsClosing;
        public event EventHandler<MouseEventArgs> ShowPasswordMoseClickDown;
        public event EventHandler<MouseEventArgs> ShowPassworMouseClickUp;

        private Presenter.UsersInfoFormPresenter _presenter;

        public UsersInfoForm(int? userID)
        {
            InitializeComponent();
            _presenter = new Presenter.UsersInfoFormPresenter(this, new GenericRepository(), new CurrentUserService(), userID);
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string UserName
        {
            get => txtName.Text;
            set => txtName.Text = value;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string UserSurname
        {
            get => txtSurname.Text;
            set => txtSurname.Text = value;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Login { get => txtLogin.Text; set => txtLogin.Text = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DialogResult OperationConfirmed { get => DialogResult; set => DialogResult = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool SuperAdmin { get => cbSuperAdmin.Checked; set => cbSuperAdmin.Checked = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FormText { get => this.Text; set => this.Text = value; }

        public UsersInfoModel GetUserModel() => new UsersInfoModel
        {
            UserName = this.UserName,
            UserSurname = this.UserSurname,
            Login = this.Login,
            Password = this.Password,
            SuperAdmin = this.SuperAdmin,
            OperationConfirmed = this.OperationConfirmed
        };

        public void CloseForm() => this.Close();

        public void ChangeControlAccessibility(bool isEnabled)
        {
            gbLogin.Enabled = isEnabled;
            gbPassword.Enabled = isEnabled;
            btnShowPassword.Enabled = isEnabled;
        }

        public void SetSuperAdminControlAccessibility(bool userHasSuperAdminPermissions)
        {
            gbSuperAdmin.Enabled = userHasSuperAdminPermissions;
            cbSuperAdmin.Enabled = userHasSuperAdminPermissions;
        }

        public void PasswordHash(char? hash)
        {
            if (hash.HasValue)
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.PasswordChar = hash.Value;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnAccept_Click(object sender, EventArgs e) => ConfirmButtonClicked?.Invoke(sender, e);

        private void btnCancel_Click(object sender, EventArgs e) => CancelButtonClicked?.Invoke(sender, e);

        private void UsersInfoForm_Load(object sender, EventArgs e) => FormLoaded?.Invoke(sender, e);

        private void UsersInfoForm_FormClosing(object sender, FormClosingEventArgs e) => FormIsClosing?.Invoke(sender, e);

        private void btnShowPassword_MouseDown(object sender, MouseEventArgs e) => ShowPasswordMoseClickDown?.Invoke(sender, e);

        private void btnShowPassword_MouseUp(object sender, MouseEventArgs e) => ShowPassworMouseClickUp?.Invoke(sender, e);
    }
}
