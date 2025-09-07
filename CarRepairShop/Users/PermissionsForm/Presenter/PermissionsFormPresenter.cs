using CarRepairShop.AppSettings;
using CarRepairShop.Repositories;
using CarRepairShop.Users.PermissionsForm.Model;
using CarRepairShop.Users.PermissionsForm.View;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRepairShop.Users.PermissionsForm.Presenter
{
    public class PermissionsFormPresenter
    {
        private readonly IPermissionsView _view;
        private readonly IGenericRepository _genericRepository;
        private readonly ICurrentUserService _currentUserService;

        private const string _mainLanguage = "en-US";

        private Domain.Entities.Users _user;
        private List<Domain.Entities.Permissions> _permissions;
        private List<Domain.Entities.UserPermissions> _userPermissions;

        public PermissionsFormPresenter(IPermissionsView view, ICurrentUserService currentUser, IGenericRepository genericRepo, Domain.Entities.Users user)
        {
            _view = view;
            _genericRepository = genericRepo;
            _currentUserService = currentUser;

            _user = user;
            _permissions = _genericRepository.GetAll<Domain.Entities.Permissions>().ToList();
            if (_currentUserService.Language != _mainLanguage)
                TranslateTabs();
            _userPermissions = _genericRepository.GetAll<Domain.Entities.UserPermissions>().Where(x => x.UserID == _user.ID).ToList();

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.FormLoaded += Load;
            _view.ConfirmClicked += Confirm;
            _view.CancelClicked += Cancel;
        }

        private void Load(object sender, EventArgs e)
        {
            var model = _permissions.Select(p =>
            {
                var userPerm = _userPermissions.FirstOrDefault(up => up.PermissionID == p.ID);
                return new PermissionModel
                {
                    PermissionID = p.ID,
                    UserID = _user.ID,
                    PermissionName = p.Name,
                    AllowDisplay = userPerm?.AllowDisplay ?? false,
                    AllowEdit = userPerm?.AllowEdit ?? false
                };
            }).ToList();

            _view.PopulateDatagridView(model);
        }

        private void Confirm(object sender, EventArgs e)
        {
            if (!_view.ConfirmAction(Library.Texts.PermissionsForm.AskForConfirmationBody, Library.Texts.PermissionsForm.AskForConfirmationTitle)) return;

            var permissions = _view.GetSelectedPermissions;

            if (permissions == null) return;

            var updatedPermissions = new List<Domain.Entities.UserPermissions>();

            foreach (var permission in permissions)
            {
                var existing = _userPermissions.FirstOrDefault(up => up.PermissionID == permission.PermissionID);

                if (existing != null)
                {
                    if (existing.AllowDisplay != permission.AllowDisplay || existing.AllowEdit != permission.AllowEdit)
                    {
                        existing.AllowDisplay = permission.AllowDisplay;
                        existing.AllowEdit = permission.AllowEdit;

                        updatedPermissions.Add(existing);
                    }
                }
                else
                {
                    var newUserPermission = new Domain.Entities.UserPermissions
                    {
                        UserID = _user.ID,
                        PermissionID = permission.PermissionID,
                        AllowDisplay = permission.AllowDisplay,
                        AllowEdit = permission.AllowEdit
                    };

                    updatedPermissions.Add(newUserPermission);
                }
            }
            var permissionsToRemove = _userPermissions.Where(up => !permissions.Any(pm => pm.PermissionID == up.PermissionID)).ToList();

            foreach (var perm in updatedPermissions)
            {
                if (perm.ID == 0)
                    _genericRepository.Insert(perm);
                else
                    _genericRepository.Update(perm);
            }

            if (!permissionsToRemove.Any())
                _genericRepository.Delete(permissionsToRemove);

            _view.ShowMessage(Library.Texts.PermissionsForm.AskForConfirmationTitle);
            if (_user.ID == _currentUserService.Data.ID)
                _currentUserService.SetUser(_user, _currentUserService.Credentials);
            _view.CloseForm();
        }

        private void Cancel(object sender, EventArgs e) => _view.CloseForm();

        private void TranslateTabs() => _permissions =
            new List<Domain.Entities.Permissions>
            {
                new Domain.Entities.Permissions { ID = 1, Name = Library.Texts.PermissionsForm.PermissionContractors },
                new Domain.Entities.Permissions { ID = 2, Name = Library.Texts.PermissionsForm.PermissionCRM },
                new Domain.Entities.Permissions { ID = 3, Name = Library.Texts.PermissionsForm.PermissionServices },
                new Domain.Entities.Permissions { ID = 4, Name = Library.Texts.PermissionsForm.PermissionWarehouse },
                new Domain.Entities.Permissions { ID = 5, Name = Library.Texts.PermissionsForm.PermissionStatistics },
                new Domain.Entities.Permissions { ID = 6, Name = Library.Texts.PermissionsForm.PermissionUsers },
                new Domain.Entities.Permissions { ID = 7, Name = Library.Texts.PermissionsForm.PermissionSettings }
            };
    }
}
