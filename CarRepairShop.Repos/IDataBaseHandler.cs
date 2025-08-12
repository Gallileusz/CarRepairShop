using System.Threading.Tasks;

namespace CarRepairShop.Repos
{
    public interface IDataBaseHandler
    {
        Task SetConnectionStringAsync();
        string ConnectionString { get; }
        bool IsConnectionStringSet { get; }
    }
}
