using CarRepairShop.Domain.Entities;
using System.Windows.Forms;

namespace CarRepairShop.Contractors.CarForm.DTO
{
    public class CarFormResult
    {
        public ContractorsCars Data { get; set; }
        public DialogResult OperationConfirmed { get; set; }
    }
}
