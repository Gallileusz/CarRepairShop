using CarRepairShop.Utilities.Permissions;

namespace CarRepairShop.AppSettings.CurrentUser.Service
{
    public class CurrentUserService : ICurrentUserService
    {
        public Domain.Entities.Users Data => CurrentUser.Data;

        public bool IsAdmin => CurrentUser.IsAdmin;

        public string Language { get => CurrentUser.Language; set => CurrentUser.Language = value; }

        public Domain.Entities.UserCredentials Credentials => CurrentUser.Credentials;

        public bool HasPermission(PermissionTabs permissionType, PermissionType permission) => CurrentUser.HasPermission(permissionType, permission);

        public void Initialize(PermissionService.PermissionService permissionService) => CurrentUser.Initialize(permissionService);

        public void SetUser(Domain.Entities.Users user, Domain.Entities.UserCredentials credentials) => CurrentUser.SetUser(user, credentials);
    }
}
