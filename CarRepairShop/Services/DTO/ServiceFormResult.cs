using System.Windows.Forms;

namespace CarRepairShop.Services.DTO
{
    public class ServiceFormResult
    {
        public DialogResult OperationConfirmed { get; set; }
        public Domain.Entities.Services Service { get; set; }
    }
}
