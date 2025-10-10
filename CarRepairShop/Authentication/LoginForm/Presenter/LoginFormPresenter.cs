using CarRepairShop.AppSettings.CurrentUser.Service;
using CarRepairShop.Authentication.LoginForm.View;
using CarRepairShop.Domain.Entities;
using CarRepairShop.Repos;
using CarRepairShop.Repositories;
using CarRepairShop.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace CarRepairShop.Authentication.LoginForm.Presenter
{
    public class LoginFormPresenter
    {
        private readonly ILoginView _view;
        private readonly IGenericRepository _genericRepo;
        private readonly IDataBaseHandler _dbHandler;
        private readonly ICurrentUserService _currentUserService;

        private IEnumerable<UserCredentials> _userCredentials;
        private IEnumerable<Domain.Entities.Users> _users;

        private string _errorMessage;
        private const char EnterKey = '\r';
        private bool _connectionCancelled;

        public LoginFormPresenter(bool connectionCancelled, ILoginView view, IGenericRepository genericRepo, IDataBaseHandler dbHandler, ICurrentUserService currentUser)
        {
            _connectionCancelled = connectionCancelled;
            _view = view;
            _dbHandler = dbHandler;
            _currentUserService = currentUser;
            _genericRepo = genericRepo;
            _userCredentials = new List<UserCredentials>();
            _users = new List<Domain.Entities.Users>();
            _errorMessage = string.Empty;

            SubscribeEvents();
        }

        private void SubscribeEvents()
        {
            _view.LoginButtonClicked += Login;
            _view.QuitButtonClicked += Quit;
            _view.FormIsLoaded += Load;
            _view.EnterButtonClicked += LoginByEnterClick;
            _view.ConnectionErrorPictureBoxClicked += ShowError;
            _view.SettingsClicked += OpenSettings;
        }

        private async void Load(object sender, EventArgs e)
        {
            var databaseIsActive = false;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.CachedLogin))
            {
                _view.CacheLogin = true;
                _view.Login = Properties.Settings.Default.CachedLogin;
            }

            if (_connectionCancelled)
            {
                _errorMessage += Library.Texts.LoginForm.ConnectionCancelled;
                _view.ChangeLoginButtonAccessibility(!_connectionCancelled);
                _view.SetErrorToolTip(_errorMessage);
                _view.ChangeConnectionErrorIconVisibility(_connectionCancelled);

                return;
            }

            if (string.IsNullOrEmpty(_dbHandler.ConnectionString) && ConnectionProvider.ProductionConnection)
            {
                _errorMessage += $"{Library.Texts.LoginForm.LoggedOutFromAzureService}\r\n";

                _view.ChangeConnectionErrorIconVisibility(true);
                _view.SetErrorToolTip(_errorMessage);

                return;
            }

            try
            {
                _userCredentials = await _genericRepo.GetAllAsync<UserCredentials>();
                _users = await _genericRepo.GetAllAsync<Domain.Entities.Users>();

                if (_userCredentials != null && _userCredentials.Any() && _users != null && _users.Any())
                    databaseIsActive = true;
            }
            catch (Exception)
            {
                _errorMessage += Library.Texts.LoginForm.DatabaseNeedsToRestart;
                _view.ChangeConnectionErrorIconVisibility(true);
                _view.SetErrorToolTip(_errorMessage);

                return;
            }

            if (databaseIsActive && _dbHandler.IsConnectionStringSet)
            {
                _view.ChangeConnectionErrorIconVisibility(false);
                _view.SetErrorToolTip(string.Empty);
            }

            _view.ChangeLoginButtonAccessibility(databaseIsActive);
        }

        private async void Login(object sender, EventArgs e)
        {
            if (!_dbHandler.IsConnectionStringSet)
            {
                _view.ShowMessage(Library.Texts.LoginForm.LoggedOutFromAzureService); return;
            }

            if (_userCredentials?.Any() == false || _users?.Any() == false)
            {
                _view.ShowMessage(Library.Texts.LoginForm.DatabaseNeedsToRestart);
                _view.ChangeConnectionErrorIconVisibility(true);
                _view.SetErrorToolTip(_errorMessage);
                _userCredentials = await _genericRepo.GetAllAsync<UserCredentials>();
                _users = await _genericRepo.GetAllAsync<Domain.Entities.Users>();

                return;
            }

            if (string.IsNullOrEmpty(_view.Login) || string.IsNullOrEmpty(_view.Password))
            {
                _view.ShowMessage(Library.Texts.LoginForm.ProvideLoginAndPassword); return;
            }

            var credentials = _userCredentials.FirstOrDefault(x => x.Login == _view.Login);

            if (credentials == null
                || !BCrypt.Net.BCrypt.Verify(_view.Password, credentials.PasswordHash))
            {
                _view.ShowMessage(Library.Texts.LoginForm.InvalidCredentials); return;
            }

            _currentUserService.SetUser(_users.FirstOrDefault(x => x.ID == credentials.UserID), _userCredentials.FirstOrDefault(x => x.UserID == credentials.UserID));

            Cache();
            _view.SetDialogResult(DialogResult.OK);
            _view.CloseForm();
        }

        private void LoginByEnterClick(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == EnterKey)
                Login(sender, e);
        }

        private void ShowError(object sender, EventArgs e) => _view.ShowMessage($"{Library.Texts.LoginForm.FollowingErrorsOccurred}\r\n\r\n" + _errorMessage);

        private void Quit(object sender, EventArgs e) => _view.CloseForm();

        private void Cache()
        {
            Properties.Settings.Default.CachedLogin = _view.CacheLogin ? _view.Login : string.Empty;
            Properties.Settings.Default.Language = Thread.CurrentThread.CurrentUICulture.ToString();
            _currentUserService.Language = Thread.CurrentThread.CurrentUICulture.ToString();

            Properties.Settings.Default.Save();
        }

        private void OpenSettings(object sender, EventArgs e)
        {
            var needsRestart = _view.OpenConnectionSettingsForm();

            if (needsRestart != DialogResult.Yes) return;

            _view.CloseForm();
            Application.Restart();
        }
    }
}
