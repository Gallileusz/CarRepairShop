using CarRepairShop.AppSettings.CurrentUser.Service;
using CarRepairShop.Repositories;
using CarRepairShop.Users.UserInfoForm.View;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CarRepairShop.Users.UserInfoForm.Presenter
{
    public class UsersInfoFormPresenter
    {
        private readonly IUsersInfoForm _view;
        private readonly IGenericRepository _genericRepo;
        private readonly ICurrentUserService _currentUserService;

        private Domain.Entities.Users _user;
        private Domain.Entities.UserCredentials _userCredentials;
        private bool _isConfirmed = false;

        public UsersInfoFormPresenter(IUsersInfoForm view, IGenericRepository genericRepo, ICurrentUserService currentUser, int? userID)
        {
            _view = view;
            _genericRepo = genericRepo;
            _currentUserService = currentUser;

            if (userID != null && userID > 0)
            {
                _user = _genericRepo.GetAll<Domain.Entities.Users>($"WHERE {nameof(Domain.Entities.Users.ID)} = {userID}").ToList().FirstOrDefault();
                _userCredentials = _genericRepo.GetAll<Domain.Entities.UserCredentials>($"WHERE {nameof(Domain.Entities.UserCredentials.UserID)} = {userID}").ToList().FirstOrDefault();
            }
            else
            {
                _user = new Domain.Entities.Users();
                _userCredentials = new Domain.Entities.UserCredentials();
            }

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.FormLoaded += OnFormLoad;
            _view.CancelButtonClicked += OnCancelClicked;
            _view.ConfirmButtonClicked += OnConfirmClicked;
            _view.FormIsClosing += OnFormClosing;
            _view.ShowPasswordMoseClickDown += DisablePasswordHash;
            _view.ShowPassworMouseClickUp += SetPasswordHash;
        }

        private void SetPasswordHash(object sender, MouseEventArgs e) => _view.PasswordHash('*');

        private void DisablePasswordHash(object sender, MouseEventArgs e)
        {
            if (_user.ID > 0) return;

            _view.PasswordHash(null);
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            if (_user.ID > 0 && _userCredentials.UserID > 0)
            {
                _view.UserName = _user.Name;
                _view.UserSurname = _user.Surname;
                _view.Login = _userCredentials.Login;
                _view.Password = _userCredentials.PasswordHash;
                _view.SuperAdmin = _user.Admin;
                _view.FormText = string.Format(Library.Texts.MainView.Users.UserInfoFormTitle, _user.Name, _user.Surname);
                _view.ChangeControlAccessibility(false);
            }

            else
                _view.ChangeControlAccessibility(true);

            _view.SetSuperAdminControlAccessibility(_currentUserService.IsAdmin);
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isConfirmed)
                _view.OperationConfirmed = DialogResult.No;
        }

        private void OnCancelClicked(object sender, EventArgs e) => _view.CloseForm();

        private void OnConfirmClicked(object sender, EventArgs e)
        {
            _isConfirmed = true;
            _view.OperationConfirmed = DialogResult.Yes;

            _view.CloseForm();
        }
    }
}
