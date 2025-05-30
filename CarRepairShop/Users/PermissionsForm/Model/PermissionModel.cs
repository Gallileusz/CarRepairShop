namespace CarRepairShop.Users.PermissionsForm.Model
{
    public class PermissionModel
    {
        public int PermissionID { get; set; }
        public string PermissionName { get; set; }
        public bool AllowDisplay { get; set; }
        public bool AllowEdit { get; set; }
        public int UserID { get; set; }
    }
}
