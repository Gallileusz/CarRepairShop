using CarRepairShop.Texts;

namespace CarRepairShop.Library
{
    public class MainView
    {
        public HomeTab HomeTab { get; } = new HomeTab();
        public UsersTab UsersTab { get; } = new UsersTab();
        public WarehouseTab WarehouseTab { get; } = new WarehouseTab();
        public ServicesTab ServicesTab { get; } = new ServicesTab();

        public string MissingPermissionsMessage => SharedTexts.MainFormMissingPermissionsMessage;
        public string Services => SharedTexts.MainFormServices;
        public string Contractors => SharedTexts.MainFormContractors;
        public string CRM => SharedTexts.MainFormCRM;
        public string Warehouse => SharedTexts.MainFormWarehouse;
        public string Users => SharedTexts.MainFormUsers;
    }
}
