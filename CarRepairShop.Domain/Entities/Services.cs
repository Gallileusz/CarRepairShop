using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRepairShop.Domain.Entities
{
    [Table("Services")]
    public class Services
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Duration")]
        public float Duration { get; set; }

        [Column("StandardCost")]
        public float StandardCost { get; set; }

        [Column("WarrantyMonths")]
        public int WarrantyMonths { get; set; }

        [Column("IsActive")]
        public bool IsActive { get; set; }
    }
}
