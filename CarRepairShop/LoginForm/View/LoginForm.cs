using System;
using System.Windows.Forms;
using CarRepairShop.LoginForm.DTO;
using CarRepairShop.LoginForm.Presenter;

namespace CarRepairShop.LoginForm.View
{
    public partial class LoginForm : Form, ILoginView
    {
        private LoginFormPresenter _presenter;

        public UserCredentialsInput UserCredentials => new UserCredentialsInput { Login = txtLogin.Text, Password = txtPassword.Text };

        public bool CacheCheckboxSelected
        {
            get => cbCacheLogin.Checked;
            set => cbCacheLogin.Checked = value;
        }

        public string Login
        {
            get => txtLogin.Text;
            set => txtLogin.Text = value;
        }

        public event EventHandler LoginButtonClicked;
        public event EventHandler QuitLabelClicked;
        public event EventHandler FormIsLoaded;

        public LoginForm()
        {
            InitializeComponent();
            _presenter = new LoginFormPresenter(this);
        }

        public void CloseLoginForm() => this.Close();

        public void SetDialogResult(DialogResult result) => this.DialogResult = result;

        public void ShowMessage(string message) => MessageBox.Show(message);

        private void lblQuit_Click(object sender, System.EventArgs e) => QuitLabelClicked?.Invoke(this, e);

        private void btnLogin_Click(object sender, System.EventArgs e) => LoginButtonClicked?.Invoke(this, e);

        private void LoginForm_Load(object sender, EventArgs e) => FormIsLoaded?.Invoke(this, e);

        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                LoginButtonClicked?.Invoke(this, e);
        }
    }
}
