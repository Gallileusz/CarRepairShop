namespace CarRepairShop.Library
{
    public static class Texts
    {
        public static MainView MainView { get; } = new MainView();

        public static PermissionsForm PermissionsForm { get; } = new PermissionsForm();
        public static LoginForm LoginForm { get; } = new LoginForm();
        public static ConsumableMaterial ConsumableMaterial { get; } = new ConsumableMaterial();
        public static MaterialsTypesList MaterialsTypesList { get; } = new MaterialsTypesList();
        public static ServicesForm ServicesForm { get; } = new ServicesForm();
        public static CRMForm CRMForm { get; } = new CRMForm();
        public static ContractorForm ContractorForm { get; } = new ContractorForm();
        public static CarForm CarForm { get; } = new CarForm();
        public static FuelTypesList FuelTypesList { get; } = new FuelTypesList();
        public static DataBaseConnector DataBaseConnector { get; } = new DataBaseConnector();
        public static ConnectionSettings ConnectionSettings { get; } = new ConnectionSettings();
    }
}
