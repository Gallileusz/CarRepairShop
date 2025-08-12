using CarRepairShop.AppSettings;
using CarRepairShop.Domain.Entities;
using CarRepairShop.LoginForm.View;
using CarRepairShop.Repos;
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
        private readonly IGenericRepository _genericRepo;
        private readonly IDataBaseHandler _dbHandler;
        private readonly ICurrentUserService _currentUserService;
        private bool _isConnectionStringSet = false;

        public LoginFormPresenter(ILoginView view, IGenericRepository genericRepo, IDataBaseHandler dbHandler, ICurrentUserService currentUser)
        {
            _view = view;
            _dbHandler = dbHandler;
            _currentUserService = currentUser;
            _genericRepo = genericRepo;
            SubscribeEvents();
        }

        private void SubscribeEvents()
        {
            _view.LoginButtonClicked += Login;
            _view.QuitButtonClicked += Quit;
            _view.FormIsLoaded += Load;
            _view.EnterButtonClicked += LoginByEnterClick;
        }

        private void Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.CachedLogin)) return;

            _view.CacheCheckboxSelected = true;
            _view.Login = Properties.Settings.Default.CachedLogin;

            if (!_dbHandler.IsConnectionStringSet)
            {
                _view.ShowMessage("Wystąpił błąd z uzyskaniem klucza bazy danych z serwisu Azure. Proszę skontaktować się z administratorem!"); return;
            }

            _isConnectionStringSet = true;
        }

        private void Quit(object sender, EventArgs e) => _view.CloseLoginForm();

        private void LoginByEnterClick(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                Login(sender, e);
        }

        private void Login(object sender, EventArgs e)
        {
            if (!_isConnectionStringSet)
            {
                _view.ShowMessage("Wystąpił błąd z uzyskaniem klucza bazy danych z serwisu Azure. Proszę skontaktować się z administratorem!"); return;
            }

            var login = _view.UserCredentials.Login;
            var password = _view.UserCredentials.Password;

            if (string.IsNullOrEmpty(_view.UserCredentials.Login)
                || string.IsNullOrEmpty(_view.UserCredentials.Password))
            {
                _view.ShowMessage("Proszę wprowadzić login i hasło.");
                Cache(false);
                return;
            }

            var credentials = _genericRepo.GetAll<UserCredentials>().FirstOrDefault(c => c.Login == _view.UserCredentials.Login);

            if (credentials == null
                || !BCrypt.Net.BCrypt.Verify(_view.UserCredentials.Password, credentials.PasswordHash))
            {
                _view.ShowMessage("Nieprawidłowy login lub hasło.");
                Cache(false);
                return;
            }

            _currentUserService.SetUser(_genericRepo.GetAll<Domain.Entities.Users>().FirstOrDefault(x => x.ID == credentials.UserID));

            Cache(true);
            _view.CloseLoginForm();
            _view.SetDialogResult(DialogResult.OK);
        }

        private void Cache(bool success)
        {
            Properties.Settings.Default.CachedLogin = _view.CacheCheckboxSelected && success ? _view.Login : string.Empty;
            Properties.Settings.Default.Language = Thread.CurrentThread.CurrentUICulture.ToString();
            _currentUserService.Language = Thread.CurrentThread.CurrentUICulture.ToString();
            Properties.Settings.Default.Save();
        }
    }
}
