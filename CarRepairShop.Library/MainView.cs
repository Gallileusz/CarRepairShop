using CarRepairShop.Texts;

namespace CarRepairShop.Library
{
    public class MainView
    {
        public HomeTab HomeTab { get; } = new HomeTab();

        public string MissingPermissionsMessage => SharedTexts.MainFormMissingPermissionsMessage;
        public string Services => SharedTexts.MainFormServices;
        public string Contractors => SharedTexts.MainFormContractors;
        public string CRM => SharedTexts.MainFormCRM;
        public string Warehouse => SharedTexts.MainFormWarehouse;
        public string Users => SharedTexts.MainFormUsers;
    }
}
