using CarRepairShop.Texts;

namespace CarRepairShop.Library
{
    public class MainView
    {
        public HomeTab Home { get; } = new HomeTab();
        public UsersTab Users { get; } = new UsersTab();
        public WarehouseTab Warehouse { get; } = new WarehouseTab();
        public ServicesTab Services { get; } = new ServicesTab();
        public SettingsTab Settings { get; } = new SettingsTab();
        public CRMTab CRM { get; } = new CRMTab();
        public ContractorsTab Contractors { get; } = new ContractorsTab();

        public string MissingPermissionsMessage => SharedTexts.MainFormMissingPermissionsMessage;
        public string ServicesPermission => SharedTexts.MainFormServices;
        public string ContractorsPermission => SharedTexts.MainFormContractors;
        public string CRMPermission => SharedTexts.MainFormCRM;
        public string WarehousePermission => SharedTexts.MainFormWarehouse;
        public string UsersPermission => SharedTexts.MainFormUsers;
    }
}
