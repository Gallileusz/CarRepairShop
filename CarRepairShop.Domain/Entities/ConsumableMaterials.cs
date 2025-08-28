using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRepairShop.Domain.Entities
{
    [Table("ConsumableMaterials")]
    public class ConsumableMaterials
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("MaterialTypeID")]
        public int MaterialTypeID { get; set; }

        [Column("Quantity")]
        public int Quantity { get; set; }
    }
}
