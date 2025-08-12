using System.Threading.Tasks;

namespace CarRepairShop.Repos
{
    public class DataBaseHandler : IDataBaseHandler
    {
        public string ConnectionString => DataBase.ConnectionString;
        public bool IsConnectionStringSet => DataBase.IsConnectionStringSet;
        public Task SetConnectionStringAsync() => DataBase.SetConnectionStringAsync();
    }
}
