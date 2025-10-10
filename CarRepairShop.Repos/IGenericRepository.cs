using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRepairShop.Repositories
{
    public interface IGenericRepository
    {
        T GetSingle<T>(string querySuffix = "") where T : class;
        Task<T> GetSingleAsync<T>(string querySuffix = "") where T : class;
        IEnumerable<T> GetAll<T>(string querySufix = "");
        Task<IEnumerable<T>> GetAllAsync<T>(string querySufix = "");
        bool UseRawSql(string query, object param = null);
        Task<bool> UseRawSqlAsync(string query, object param = null);
        bool Update<T>(T objectToUpdate) where T : class;
        int Insert<T>(T objectToInsert) where T : class;
        bool Delete<T>(T objectToDelete) where T : class;
    }
}
