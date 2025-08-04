using CarRepairShop.Utilities.Permissions;

namespace CarRepairShop.AppSettings
{
    public interface ICurrentUserService
    {
        Domain.Entities.Users Data { get; }
        bool IsAdmin { get; }
        string Language { get; set; }
        bool HasPermission(PermissionTabs permissionType, Permissions permission);
        void SetUser(Domain.Entities.Users user);
        void Initialize(PermissionService permissionService);
    }
}
