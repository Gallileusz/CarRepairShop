using System.Collections.Generic;
using System.Linq;

namespace CarRepairShop.MainForm.Models.Tabs.Contractors
{
    public class ContractorCarsVM
    {
        public int ID { get; set; }
        public int ContractorID { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public int VIN { get; set; }
        public int Year { get; set; }
        public string LicensePlate { get; set; }
        public string FuelType { get; set; }
        public float EngineCapacity { get; set; }
        public int Mileage { get; set; }

        public ContractorCarsVM(Domain.Entities.ContractorsCars car, List<Domain.Entities.FuelTypes> fuelTypes)
        {
            ID = car.ID;
            ContractorID = car.ContractorID;
            BrandName = car.BrandName;
            ModelName = car.ModelName;
            VIN = car.VIN;
            Year = car.Year;
            LicensePlate = car.LicensePlate;
            FuelType = fuelTypes.FirstOrDefault(x => x.ID == car.FuelTypeID).Name;
            EngineCapacity = car.EngineCapacity;
            Mileage = car.Mileage;
        }
    }
}
