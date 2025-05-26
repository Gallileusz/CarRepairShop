using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRepairShop.Domain.Entities
{
    [Table("MaterialTypes")]
    public class MaterialTypes
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }
        [Column("Name")]
        public string Name { get; set; }
    }
}
