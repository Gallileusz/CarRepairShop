using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRepairShop.Domain.Entities
{
    [System.ComponentModel.DataAnnotations.Schema.Table("CRM_Task")]
    public class CRM_Task
    {
        [Key]
        [Computed]
        [Column("TaskID")]
        public int TaskID { get; set; }

        [Column("MechanicID")]
        public int MechanicID { get; set; }

        [Column("ContractorID")]
        public int ContractorID { get; set; }

        [Column("CarID")]
        public int CarID { get; set; }

        [Column("Comment")]
        public string Comment { get; set; }

        [Column("StartDate")]
        public DateTime StartDate { get; set; }

        [Column("Completed")]
        public bool Completed { get; set; }

        [Column("EndDate")]
        public DateTime? EndDate { get; set; }

        [Column("Price")]
        public double Price { get; set; }
    }
}
