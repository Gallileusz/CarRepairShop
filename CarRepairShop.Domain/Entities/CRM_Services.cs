using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRepairShop.Domain.Entities
{
    [System.ComponentModel.DataAnnotations.Schema.Table("CRM_Services")]
    public class CRM_Services
    {
        [Key]
        [Computed]
        [Column("ID")]
        public int ID { get; set; }

        [Column("TaskID")]
        public int TaskID { get; set; }

        [Column("ServiceID")]
        public int ServiceID { get; set; }

        [Column("Quantity")]
        public int Quantity { get; set; }
    }
}
