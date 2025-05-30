using CarRepairShop.Users.UserInfoForm.View;
using System;
using System.Windows.Forms;

namespace CarRepairShop.Users.UserInfoForm.Presenter
{
    public class UsersInfoFormPresenter
    {
        private readonly IUsersInfoForm _view;
        private Domain.Entities.Users _user;
        private bool _isConfirmed = false;

        public UsersInfoFormPresenter(IUsersInfoForm view)
        {
            _view = view;

            _view.CancelButtonClicked += OnCancelClicked;
            _view.ConfirmButtonClicked += OnConfirmClicked;
            _view.FormLoaded += OnFormLoad;
            _view.FormIsClosing += OnFormClosing;
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            if (_user != null)
            {
                _view.UserName = _user.Name;
                _view.UserSurname = _user.Surname;
            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isConfirmed)
                _user = null;
        }

        public void SetUser(Domain.Entities.Users user) => _user = user;

        private void OnCancelClicked(object sender, EventArgs e)
        {
            _user = null;
            _view.CloseForm();
        }

        private void OnConfirmClicked(object sender, EventArgs e)
        {
            _isConfirmed = true;

            if (_user == null)
                _user = new Domain.Entities.Users();

            _user.Name = _view.UserName;
            _user.Surname = _view.UserSurname;

            _view.CloseForm();
        }

        public Domain.Entities.Users GetUser() => _user;
    }
}
