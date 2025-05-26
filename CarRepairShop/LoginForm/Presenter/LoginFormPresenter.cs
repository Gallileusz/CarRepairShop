using System;
using System.Linq;
using System.Windows.Forms;
using CarRepairShop.Domain.Entities;
using CarRepairShop.LoginForm.View;
using CarRepairShop.Repositories;

namespace CarRepairShop.LoginForm.Presenter
{
    public class LoginFormPresenter
    {
        private readonly ILoginView _view;
        private readonly GenericRepository _genericRepo;
        private string _cachedLogin;
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
                CacheLogin(false);
                return;
            }

            var credentials = _genericRepo.GetAll<UserCredentials>().FirstOrDefault(c => c.Login == _view.UserCredentials.Login);

            if (credentials == null || !BCrypt.Net.BCrypt.Verify(_view.UserCredentials.Password, credentials.PasswordHash))
            {
                _view.ShowMessage("Nieprawidłowy login lub hasło.");
                CacheLogin(false);
                return;
            }

            CurrentUser.SetUser(_genericRepo.GetAll<Users>().FirstOrDefault(x => x.ID == credentials.UserID));

            CacheLogin(true);
            _view.CloseLoginForm();
            _view.SetDialogResult(DialogResult.OK);
        }

        private void CacheLogin(bool success)
        {
            Properties.Settings.Default.CachedLogin = _view.CacheCheckboxSelected && success ? _view.Login : string.Empty;
            Properties.Settings.Default.Save();
        }
    }
}
