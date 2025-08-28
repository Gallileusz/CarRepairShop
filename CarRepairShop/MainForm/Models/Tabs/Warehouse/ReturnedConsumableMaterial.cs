using CarRepairShop.Domain.Entities;
using System.Windows.Forms;

namespace CarRepairShop.MainForm.Models.Tabs.Warehouse
{
    public class ReturnedConsumableMaterial
    {
        public DialogResult OperationConfirmed { get; set; }
        public ConsumableMaterials ConsumableMaterial { get; set; }
    }
}
