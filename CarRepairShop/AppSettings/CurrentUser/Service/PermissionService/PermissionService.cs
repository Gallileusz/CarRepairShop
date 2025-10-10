using CarRepairShop.Repositories;
using CarRepairShop.Utilities.Permissions;
using System.Collections.Generic;
using System.Linq;

namespace CarRepairShop.AppSettings.CurrentUser.Service.PermissionService
{
    public class PermissionService
    {
        private GenericRepository _genericRepo;
        private List<Domain.Entities.UserPermissions> _userPermissions;

        public PermissionService()
        {
            _genericRepo = new GenericRepository();

            if (CurrentUser.Data == null)
                _userPermissions = new List<Domain.Entities.UserPermissions>();
            else
                _userPermissions = _genericRepo.GetAll<Domain.Entities.UserPermissions>().Where(x => x.UserID == CurrentUser.Data.ID).ToList();
        }

        public bool HasPermission(PermissionTabs permissionTab, PermissionType permission)
        {
            if (CurrentUser.Data == null) return false;

            if (CurrentUser.IsAdmin) return true;

            int userID = CurrentUser.Data.ID;
            int permissionID = (int)permissionTab;

            var userPermission = _userPermissions.FirstOrDefault(up => up.UserID == userID && up.PermissionID == permissionID);

            if (userPermission == null) return false;

            switch (permission)
            {
                case PermissionType.AllowDisplay:
                    return userPermission.AllowDisplay;
                case PermissionType.AllowEdit:
                    return userPermission.AllowEdit;
                default:
                    return false;
            }
        }
    }
}