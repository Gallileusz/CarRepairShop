using System.Windows.Forms;

namespace CarRepairShop.Contractors.ContractorForm.DTO
{
    public class ContractorFormResult
    {
        public Domain.Entities.Contractors Contractor { get; set; }
        public DialogResult OperationConfirmed { get; set; }
    }
}
