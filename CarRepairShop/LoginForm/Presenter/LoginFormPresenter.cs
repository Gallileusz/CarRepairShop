using CarRepairShop.Domain.Entities;
using CarRepairShop.LoginForm.View;
using CarRepairShop.Repositories;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace CarRepairShop.LoginForm.Presenter
{
    public class LoginFormPresenter
    {
        private readonly ILoginView _view;
        private readonly GenericRepository _genericRepo;

        public LoginFormPresenter(ILoginView view)
        {
            _view = view;
            _genericRepo = new GenericRepository();
            SubscribeEvents();
        }

        private void SubscribeEvents()
        {
            _view.LoginButtonClicked += Login;
            _view.QuitLabelClicked += Quit;
            _view.FormIsLoaded += Load;
        }

        private void Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.CachedLogin)) return;

            _view.CacheCheckboxSelected = true;
            _view.Login = Properties.Settings.Default.CachedLogin;
        }

        private void Quit(object sender, EventArgs e) => Application.Exit();

        private void Login(object sender, EventArgs e)
        {
            var login = _view.UserCredentials.Login;
            var password = _view.UserCredentials.Password;

            if (string.IsNullOrEmpty(_view.UserCredentials.Login) || string.IsNullOrEmpty(_view.UserCredentials.Password))
            {
                _view.ShowMessage("Proszę wprowadzić login i hasło.");
                Cache(false);
                return;
            }

            var credentials = _genericRepo.GetAll<UserCredentials>().FirstOrDefault(c => c.Login == _view.UserCredentials.Login);

            if (credentials == null || !BCrypt.Net.BCrypt.Verify(_view.UserCredentials.Password, credentials.PasswordHash))
            {
                _view.ShowMessage("Nieprawidłowy login lub hasło.");
                Cache(false);
                return;
            }

            AppSettings.CurrentUser.SetUser(_genericRepo.GetAll<Domain.Entities.Users>().FirstOrDefault(x => x.ID == credentials.UserID));

            Cache(true);
            _view.CloseLoginForm();
            _view.SetDialogResult(DialogResult.OK);
        }

        private void Cache(bool success)
        {
            Properties.Settings.Default.CachedLogin = _view.CacheCheckboxSelected && success ? _view.Login : string.Empty;
            Properties.Settings.Default.Language = Thread.CurrentThread.CurrentUICulture.ToString();
            AppSettings.CurrentUser.Language = Thread.CurrentThread.CurrentUICulture.ToString();
            Properties.Settings.Default.Save();
        }
    }
}
