using CarRepairShop.AppSettings.CurrentUser.Service;
using CarRepairShop.Authentication.LoginForm.Presenter;
using CarRepairShop.Authentication.LoginForm.View;
using CarRepairShop.Repos;
using CarRepairShop.Repositories;
using System;
using System.Windows.Forms;

namespace CarRepairShop.LoginForm.View
{
    public partial class LoginForm : Form, ILoginView
    {
        public event EventHandler LoginButtonClicked;
        public event EventHandler QuitButtonClicked;
        public event EventHandler FormIsLoaded;
        public event EventHandler<KeyPressEventArgs> EnterButtonClicked;
        public event EventHandler ConnectionErrorPictureBoxClicked;
        public event EventHandler SettingsClicked;

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public bool CacheLogin
        {
            get => cbCacheLogin.Checked;
            set => cbCacheLogin.Checked = value;
        }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string Login
        {
            get => txtLogin.Text;
            set => txtLogin.Text = value;
        }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string Password
        {
            get => txtPassword.Text;
            set => txtPassword.Text = value;
        }

        private LoginFormPresenter _presenter;

        public LoginForm(bool connectionCancelled)
        {
            InitializeComponent();
            _presenter = new LoginFormPresenter(connectionCancelled, this, new GenericRepository(), new DataBaseHandler(), new CurrentUserService());
        }

        public void CloseForm() => this.Close();

        public void SetDialogResult(DialogResult result) => this.DialogResult = result;

        public void ShowMessage(string message) => MessageBox.Show(message);

        public void ChangeConnectionErrorIconVisibility(bool visible)
        {
            pbConnectionError.Visible = visible;
            lblError.Visible = visible;
        }

        public void SetErrorToolTip(string error)
        {
            var toolTip = new ToolTip
            {
                AutoPopDelay = 5000,
                InitialDelay = 1000,
                ReshowDelay = 500,
                ShowAlways = true
            };

            toolTip.SetToolTip(pbConnectionError, error);
            toolTip.SetToolTip(lblError, error);
        }

        public void ChangeLoginButtonAccessibility(bool accessible) => btnLogin.Enabled = accessible;

        private void btnLogin_Click(object sender, EventArgs e) => LoginButtonClicked?.Invoke(sender, e);

        private void LoginForm_Load(object sender, EventArgs e) => FormIsLoaded?.Invoke(sender, e);

        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e) => EnterButtonClicked?.Invoke(sender, e);

        private void btnQuit_Click(object sender, EventArgs e) => QuitButtonClicked?.Invoke(sender, e);

        private void pbConnectionError_Click(object sender, EventArgs e) => ConnectionErrorPictureBoxClicked?.Invoke(sender, e);

        private void pbSettings_Click(object sender, EventArgs e) => SettingsClicked?.Invoke(sender, e);

        public DialogResult OpenConnectionSettingsForm()
        {
            var form = new Authentication.ConnectionSettings.View.ConnectionSettingsView();
            form.ShowDialog();

            return form.ChangesAccured;
        }
    }
}
