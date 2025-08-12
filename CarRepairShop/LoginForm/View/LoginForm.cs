using CarRepairShop.AppSettings;
using CarRepairShop.LoginForm.DTO;
using CarRepairShop.LoginForm.Presenter;
using CarRepairShop.Repos;
using CarRepairShop.Repositories;
using System;
using System.Windows.Forms;

namespace CarRepairShop.LoginForm.View
{
    public partial class LoginForm : Form, ILoginView
    {
        private LoginFormPresenter _presenter;

        public UserCredentialsInput UserCredentials => new UserCredentialsInput { Login = txtLogin.Text, Password = txtPassword.Text };

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public bool CacheCheckboxSelected
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

        public event EventHandler LoginButtonClicked;
        public event EventHandler QuitButtonClicked;
        public event EventHandler FormIsLoaded;
        public event EventHandler<KeyPressEventArgs> EnterButtonClicked;

        public LoginForm()
        {
            InitializeComponent();
            _presenter = new LoginFormPresenter(this, new GenericRepository(), new DataBaseHandler(), new CurrentUserService());
        }

        public void CloseLoginForm() => this.Close();

        public void SetDialogResult(DialogResult result) => this.DialogResult = result;

        public void ShowMessage(string message) => MessageBox.Show(message);

        private void btnLogin_Click(object sender, System.EventArgs e) => LoginButtonClicked?.Invoke(sender, e);

        private void LoginForm_Load(object sender, EventArgs e) => FormIsLoaded?.Invoke(sender, e);

        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e) => EnterButtonClicked?.Invoke(sender, e);

        private void btnQuit_Click(object sender, EventArgs e) => QuitButtonClicked?.Invoke(sender, e);
    }
}
