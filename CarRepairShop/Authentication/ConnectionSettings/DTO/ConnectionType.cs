namespace CarRepairShop.Authentication.ConnectionSettings.DTO
{
    public class ConnectionType
    {
        public bool ProductionConnection { get; }
        public bool DemoConnection { get; }
        public ConnectionType(bool productionConnection, bool demoConnection)
        {
            ProductionConnection = productionConnection;
            DemoConnection = demoConnection;
        }
    }
}
