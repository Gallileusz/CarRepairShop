using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRepairShop.Domain.Entities
{
    [Table("UserPermissions")]
    public class UserPermissions
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("UserID")]
        public int UserID { get; set; }

        [Column("PermissionID")]
        public int PermissionID { get; set; }

        [Column("AllowDisplay")]
        public bool AllowDisplay { get; set; }

        [Column("AllowEdit")]
        public bool AllowEdit { get; set; }
    }
}
