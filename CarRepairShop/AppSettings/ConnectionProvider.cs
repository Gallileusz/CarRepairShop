using CarRepairShop.Settings;

namespace CarRepairShop.AppSettings
{
    public class ConnectionSetter
    {
        public void SetConnectionProvider()
        {
            ConnectionProvider.ProductionConnection = Properties.Settings.Default.ProductionConnection;
            ConnectionProvider.DemoConnectionString = Properties.Settings.Default.DemoConnectionString;
        }
    }
}
