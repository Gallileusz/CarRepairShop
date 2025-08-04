using CarRepairShop.Utilities.Permissions;

namespace CarRepairShop.AppSettings
{
    public class CurrentUserService : ICurrentUserService
    {
        public Domain.Entities.Users Data => CurrentUser.Data;

        public bool IsAdmin => CurrentUser.IsAdmin;

        public string Language { get => CurrentUser.Language; set => CurrentUser.Language = value; }

        public bool HasPermission(PermissionTabs permissionType, Permissions permission) => CurrentUser.HasPermission(permissionType, permission);

        public void Initialize(PermissionService permissionService) => CurrentUser.Initialize(permissionService);

        public void SetUser(Domain.Entities.Users user) => CurrentUser.SetUser(user);
    }
}
