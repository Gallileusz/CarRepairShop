using CarRepairShop.Utilities.Permissions;

namespace CarRepairShop.AppSettings
{
    public interface ICurrentUserService
    {
        Domain.Entities.Users Data { get; }
        Domain.Entities.UserCredentials Credentials { get; }
        bool IsAdmin { get; }
        string Language { get; set; }
        bool HasPermission(PermissionTabs permissionType, Permissions permission);
        void SetUser(Domain.Entities.Users user, Domain.Entities.UserCredentials credentials);
        void Initialize(PermissionService permissionService);
    }
}
