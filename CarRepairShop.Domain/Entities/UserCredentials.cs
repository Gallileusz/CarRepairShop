using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRepairShop.Domain.Entities
{
    [Table("UserCredentials")]
    public class UserCredentials
    {
        [Column("ID")]
        public int ID { get; set; }

        [Key]
        [Column("UserID")]
        public int UserID { get; set; }

        [Column("Login")]
        public string Login { get; set; }

        [Column("PasswordHash")]
        public string PasswordHash { get; set; }

    }
}
