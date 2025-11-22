using CarRepairShop.AppSettings.CurrentUser.Service;
using CarRepairShop.Domain.Entities;
using CarRepairShop.MainForm.Views.Tabs.Users;
using CarRepairShop.Repositories;
using CarRepairShop.Users.PermissionsForm.View;
using CarRepairShop.Users.UserInfoForm.Model;
using CarRepairShop.Users.UserInfoForm.View;
using System;
using System.Collections.Generic;
using System.Linq;
namespace CarRepairShop.MainForm.Presenters.Tabs.User
{
    public class UsersTabPresenter
    {
        private readonly IUsersTabView _view;
        private readonly IGenericRepository _genericRepo;
        private readonly ICurrentUserService _currentUser;

        private List<Domain.Entities.Users> _usersList;
        private List<Domain.Entities.UserCredentials> _userCredentials;
        private List<Domain.Entities.Users> _filteredUsersList;

        public UsersTabPresenter(IUsersTabView view, IGenericRepository genericRepo, ICurrentUserService currentUser)
        {
            _view = view;
            _genericRepo = genericRepo;
            _currentUser = currentUser;

            _usersList = _genericRepo.GetAll<Domain.Entities.Users>().ToList();
            _userCredentials = _genericRepo.GetAll<UserCredentials>().ToList();
            _filteredUsersList = _usersList;

            SubscribeEvents();
        }

        private void SubscribeEvents()
        {
            _view.FormLoaded += OnFormLoad;
            _view.EditUserButtonClicked += EditUser;
            _view.AddUserButtonClicked += AddUser;
            _view.DeleteUserButtonClicked += DeleteUser;
            _view.SearchNameChanged += FilterUsers;
            _view.SearchSurameChanged += FilterUsers;
            _view.DebounceTimerElapsed += DebounceElapsed;
            _view.PermissionButtonClicked += EditPermissions;
        }

        private void EditPermissions(object sender, EventArgs e)
        {
            if (!_currentUser.HasPermission(Utilities.Permissions.PermissionTabs.Users, Utilities.Permissions.PermissionType.AllowEdit)) return;

            var selectedUser = _usersList.FirstOrDefault(x => x.ID == _view.SelectedUserID);
            if (selectedUser == null || selectedUser.ID <= 0)
            {
                _view.ShowMessage(Library.Texts.MainView.Users.SelectUserToEdit); return;
            }

            var form = new PermissionsForm(selectedUser);
            form.FormTitle = $"{Library.Texts.MainView.Users.PermissionFormTitle} {selectedUser.Name} {selectedUser.Surname}";
            form.ShowDialog();
        }

        private void DebounceElapsed(object sender, EventArgs e) => _view.LoadUsersToGrid(_filteredUsersList);

        private void FilterUsers(object sender, EventArgs e)
        {
            _filteredUsersList = _usersList;

            if (!string.IsNullOrEmpty(_view.SearchedName))
                _filteredUsersList = _filteredUsersList.Where(x => x.Name.ToLower().Contains(_view.SearchedName.ToLower())).ToList();

            if (!string.IsNullOrEmpty(_view.SearchedSurname))
                _filteredUsersList = _filteredUsersList.Where(x => x.Surname.ToLower().Contains(_view.SearchedSurname.ToLower())).ToList();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            _view.SearchNameChanged -= FilterUsers;
            _view.SearchSurameChanged -= FilterUsers;

            _view.LoadUsersToGrid(_usersList);
            _view.UnableButtonsIfNoPermissions(_currentUser.HasPermission(
                Utilities.Permissions.PermissionTabs.Users, Utilities.Permissions.PermissionType.AllowEdit));

            _view.SearchNameChanged += FilterUsers;
            _view.SearchSurameChanged += FilterUsers;
        }

        private void AddUser(object sender, EventArgs e)
        {
            if (!_currentUser.HasPermission(Utilities.Permissions.PermissionTabs.Users, Utilities.Permissions.PermissionType.AllowEdit)) return;

            var form = new UsersInfoForm(null);
            form.ShowDialog();

            if (form.OperationConfirmed != System.Windows.Forms.DialogResult.Yes) return;

            var newUserModel = form.GetUserModel();

            if (IsUserInvalid(newUserModel, false)) return;

            var newUser = new Domain.Entities.Users
            {
                Name = newUserModel.UserName,
                Surname = newUserModel.UserSurname,
                Admin = newUserModel.SuperAdmin,
            };

            if (_genericRepo.Insert(newUser) > 0)
            {
                _usersList.Add(newUser);
                _view.ShowMessage(string.Format(Library.Texts.MainView.Users.UserHasBeenAdded, newUser.Name, newUser.Surname));

                var loginCredentials = new UserCredentials
                {
                    UserID = newUser.ID,
                    Login = newUserModel.Login,
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword(newUserModel.Password)
                };

                if (_genericRepo.Insert(loginCredentials) < 0)
                    _view.ShowMessage(Library.Texts.MainView.Users.PermissionAssignementFailed);

                AddPermissionsToUser(newUser);

                _view.LoadUsersToGrid(_usersList);
            }
            else
                _view.ShowMessage(Library.Texts.MainView.Users.InsertingUserFailed);
        }

        private void EditUser(object sender, EventArgs e)
        {
            if (!_currentUser.HasPermission(Utilities.Permissions.PermissionTabs.Users, Utilities.Permissions.PermissionType.AllowEdit)) return;

            var selectedUser = _usersList.FirstOrDefault(x => x.ID == _view.SelectedUserID);
            if (selectedUser == null)
            {
                _view.ShowMessage(Library.Texts.MainView.Users.SelectUserToEdit); return;
            }

            var form = new UsersInfoForm(selectedUser.ID);
            form.ShowDialog();

            if (form.OperationConfirmed != System.Windows.Forms.DialogResult.Yes) return;

            var updatedUser = form.GetUserModel();

            if (IsUserInvalid(updatedUser, true)) return;

            selectedUser.Name = updatedUser.UserName;
            selectedUser.Surname = updatedUser.UserSurname;
            selectedUser.Admin = updatedUser.SuperAdmin;

            int index = _usersList.FindIndex(u => u.ID == selectedUser.ID);

            if (index >= 0 && _genericRepo.Update(selectedUser))
            {
                _usersList[index] = selectedUser;
                _view.LoadUsersToGrid(_usersList);
                _view.ShowMessage(Library.Texts.MainView.Users.UserHasBeenEdited);
            }
            else
                _view.ShowMessage(Library.Texts.MainView.Users.EditingUserFailed);
        }

        private void DeleteUser(object sender, EventArgs e)
        {
            if (!_currentUser.HasPermission(Utilities.Permissions.PermissionTabs.Users, Utilities.Permissions.PermissionType.AllowEdit)) return;

            var selectedUser = _usersList.FirstOrDefault(x => x.ID == _view.SelectedUserID);
            if (selectedUser == null)
            {
                _view.ShowMessage(Library.Texts.MainView.Users.SelectUserToDelete); return;
            }

            if (!_view.ConfirmAction(
                string.Format(Library.Texts.MainView.Users.AskToDeleteUserBody, selectedUser.Name, selectedUser.Surname),
                Library.Texts.MainView.Users.AskToDeleteUserTitle)) return;

            if (_genericRepo.Delete(_genericRepo.GetAll<UserCredentials>().FirstOrDefault(x => x.UserID == selectedUser.ID)) && _genericRepo.Delete(selectedUser))
            {
                _usersList.Remove(selectedUser);
                _view.LoadUsersToGrid(_usersList);
                _view.ShowMessage(Library.Texts.MainView.Users.UserHasBeenDeleted);
            }
            else
                _view.ShowMessage(Library.Texts.MainView.Users.DeletingUserFailed);
        }

        private bool IsUserInvalid(UsersInfoModel user, bool edit)
        {
            if (user == null) return true;

            if (string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.UserSurname))
            {
                _view.ShowMessage(Library.Texts.MainView.Users.UserDataCannotBeEmpty);
                return true;
            }

            if (!edit && _usersList.Where(x => x.Name == user.UserName && x.Surname == user.UserSurname).Any())
            {
                _view.ShowMessage(Library.Texts.MainView.Users.UserExists);
                return true;
            }

            if (!edit && _userCredentials.Any(x => x.Login == user.Login))
            {
                _view.ShowMessage(Library.Texts.MainView.Users.LoginAlreadyInUse);
                return true;
            }

            return false;
        }

        private void AddPermissionsToUser(Domain.Entities.Users user)
        {
            var permissionTypes = _genericRepo.GetAll<Permissions>().ToList();
            var permissionsToAdd = new List<UserPermissions>();

            foreach (var permission in permissionTypes)
            {
                var userPermission = new UserPermissions
                {
                    UserID = user.ID,
                    PermissionID = permission.ID,
                    AllowDisplay = true,
                    AllowEdit = false
                };
                permissionsToAdd.Add(userPermission);
            }

            if (_genericRepo.Insert(permissionsToAdd) <= 0)
                _view.ShowMessage(Library.Texts.MainView.Users.PermissionAssignementFailed);
        }
    }
}
