using CarRepairShop.Utilities.Permissions;

namespace CarRepairShop.AppSettings
{
    public static class CurrentUser
    {
        private static PermissionService _permissionService;

        public static void Initialize(PermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        public static Domain.Entities.Users Data { get; private set; }
        public static bool IsAdmin { get; private set; }
        public static string Language { get; set; }

        public static bool HasPermission(PermissionTabs permissionType, Permissions permission) => _permissionService.HasPermission(permissionType, permission);

        public static void SetUser(Domain.Entities.Users user)
        {
            Data = user;
            IsAdmin = user.Admin;
            Language = Properties.Settings.Default.Language;
            CurrentUser.Initialize(new PermissionService());
        }
    }

}