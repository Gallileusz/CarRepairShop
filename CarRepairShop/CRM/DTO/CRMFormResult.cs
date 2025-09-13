using CarRepairShop.Domain.Entities;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarRepairShop.CRM.DTO
{
    public class CRMFormResult
    {
        public DialogResult OperationConfirmed { get; set; }
        public CRM_Task CRM_Task { get; set; }
        public List<CRM_Services> CRM_Services { get; set; }
    }
}
