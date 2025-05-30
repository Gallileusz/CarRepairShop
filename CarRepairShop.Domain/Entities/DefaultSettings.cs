using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRepairShop.Domain.Entities
{
    [Table("DefaultSettings")]
    public class DefaultSettings
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("PasswordHash")]
        public string PasswordHash { get; set; }
    }
}
