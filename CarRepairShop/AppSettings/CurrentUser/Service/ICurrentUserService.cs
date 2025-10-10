using CarRepairShop.Utilities.Permissions;

namespace CarRepairShop.AppSettings.CurrentUser.Service
{
    public interface ICurrentUserService
    {
        Domain.Entities.Users Data { get; }
        Domain.Entities.UserCredentials Credentials { get; }
        bool IsAdmin { get; }
        string Language { get; set; }
        bool HasPermission(PermissionTabs permissionType, PermissionType permission);
        void SetUser(Domain.Entities.Users user, Domain.Entities.UserCredentials credentials);
        void Initialize(PermissionService.PermissionService permissionService);
    }
}
