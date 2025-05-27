using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRepairShop.Domain.Entities
{
    [Table("ContractorsCars")]
    public class ContractorsCars
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("ContractorID")]
        public int ContractorID { get; set; }

        [Column("BrandName")]
        public string BrandName { get; set; }

        [Column("ModelName")]
        public string ModelName { get; set; }

        [Column("VIN")]
        public int VIN { get; set; }

        [Column("Year")]
        public int Year { get; set; }

        [Column("LicensePlate")]
        public string LicensePlate { get; set; }

        [Column("FuelType")]
        public string FuelType { get; set; }

        [Column("EngineCapacity")]
        public float EngineCapacity { get; set; }

        [Column("Mileage")]
        public int Mileage { get; set; }
    }
}
