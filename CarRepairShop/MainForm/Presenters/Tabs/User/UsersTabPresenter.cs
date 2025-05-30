using CarRepairShop.Domain.Entities;
using CarRepairShop.MainForm.Views.Tabs.Users;
using CarRepairShop.Repositories;
using CarRepairShop.Users.PermissionsForm.View;
using CarRepairShop.Users.UserInfoForm.View;
using System;
using System.Collections.Generic;
using System.Linq;
namespace CarRepairShop.MainForm.Presenters.Tabs.User
{
    public class UsersTabPresenter
    {
        private readonly IUsersTabView _view;
        private readonly GenericRepository _genericRepo;

        private List<Domain.Entities.Users> _usersList;
        private List<Domain.Entities.Users> _filteredUsersList;

        public UsersTabPresenter(IUsersTabView view)
        {
            _view = view;
            _genericRepo = new GenericRepository();
            _usersList = _genericRepo.GetAll<Domain.Entities.Users>().ToList();
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
            var selectedUser = _usersList.FirstOrDefault(x => x.ID == _view.SelectedUserID);
            if (selectedUser == null)
            {
                _view.ShowMessage("Proszę wybrać użytkownika do edycji."); return;
            }

            var form = new PermissionsForm(selectedUser);
            form.FormTitle = $"Uprawnienia użytkownika: {selectedUser.Name} {selectedUser.Surname}";
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
            _view.UnableButtonsIfNoPermissions();

            _view.SearchNameChanged += FilterUsers;
            _view.SearchSurameChanged += FilterUsers;
        }
        private void AddUser(object sender, EventArgs e)
        {
            var form = new UsersInfoForm(new Domain.Entities.Users());
            form.ShowDialog();

            var newUser = form.GetUser();

            if (IsUserInvalid(newUser)) return;

            if (_genericRepo.Insert(newUser) > 0)
            {
                _usersList.Add(newUser);
                _view.ShowMessage($"Użytkownik {newUser.Name} {newUser.Surname} został dodany.");

                var loginCredentials = new UserCredentials
                {
                    UserID = newUser.ID,
                    Login = CreateLogin(newUser),
                    PasswordHash = _genericRepo.GetAll<DefaultSettings>().FirstOrDefault().PasswordHash
                };

                if (_genericRepo.Insert(loginCredentials) < 0)
                    _view.ShowMessage("Nie udało się przypisać loginu i hasła dla użytkownika!");

                AddPermissionsToUser(newUser);

                _view.LoadUsersToGrid(_usersList);
            }
            else
                _view.ShowMessage("Nie udało się dodać użytkownika!");
        }

        private void EditUser(object sender, EventArgs e)
        {
            var selectedUser = _usersList.FirstOrDefault(x => x.ID == _view.SelectedUserID);
            if (selectedUser == null)
            {
                _view.ShowMessage("Proszę wybrać użytkownika do edycji."); return;
            }

            var form = new UsersInfoForm(selectedUser);
            form.ShowDialog();

            var updatedUser = form.GetUser();

            if (IsUserInvalid(updatedUser)) return;

            selectedUser.Name = updatedUser.Name;
            selectedUser.Surname = updatedUser.Surname;

            int index = _usersList.FindIndex(u => u.ID == selectedUser.ID);

            if (index >= 0 && _genericRepo.Update(selectedUser))
            {
                _usersList[index] = selectedUser;
                _view.LoadUsersToGrid(_usersList);
                _view.ShowMessage("Użytkownik został zaktualizowany.");
            }
            else
                _view.ShowMessage("Nie udało się zaktualizować użytkownika!");
        }

        private void DeleteUser(object sender, EventArgs e)
        {
            var selectedUser = _usersList.FirstOrDefault(x => x.ID == _view.SelectedUserID);
            if (selectedUser == null)
            {
                _view.ShowMessage("Proszę wybrać użytkownika do edycji."); return;
            }

            if (!_view.ConfirmAction($"Czy na pewno chcesz usunąć użytkownika: \r\n{selectedUser.Name} {selectedUser.Surname}?", "Usuwanie użytkownika")) return;

            if (_genericRepo.Delete(selectedUser))
            {
                _usersList.Remove(selectedUser);
                _genericRepo.Delete(_genericRepo.GetAll<UserCredentials>().FirstOrDefault(x => x.UserID == selectedUser.ID));
                _view.LoadUsersToGrid(_usersList);
                _view.ShowMessage("Użytkownik został usunięty.");
            }
            else
                _view.ShowMessage("Nie udało się zaktualizować użytkownika!");
        }

        private bool IsUserInvalid(Domain.Entities.Users user)
        {
            if (user == null) return true;

            if (string.IsNullOrEmpty(user.Name) || string.IsNullOrEmpty(user.Surname))
            {
                _view.ShowMessage("Pole imie i nazwisko musi zostać wypełnione!");
                return true;
            }

            if (_usersList.Where(x => x.Name == user.Name && x.Surname == user.Surname).Any())
            {
                _view.ShowMessage("Użytkownik o takim imieniu i nazwisku już istnieje!");
                return true;
            }

            return false;
        }

        private string CreateLogin(Domain.Entities.Users user)
        {
            string namePart = user.Name.Substring(0, 1).ToLower();
            string surnamePart = char.ToUpper(user.Surname[0]) + user.Surname.Substring(1).ToLower();

            return namePart + surnamePart;
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
                _view.ShowMessage("Nie udało się przypisać uprawnień do użytkownika!");
        }
    }
}
