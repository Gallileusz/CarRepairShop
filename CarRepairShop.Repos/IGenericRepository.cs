using System.Collections.Generic;

namespace CarRepairShop.Repositories
{
    public interface IGenericRepository
    {
        IEnumerable<T> GetAll<T>(string querySufix = "");
        bool UseRawSql(string query, object param = null);
        bool Update<T>(T objectToUpdate) where T : class;
        int Insert<T>(T objectToInsert) where T : class;
        bool Delete<T>(T objectToDelete) where T : class;
    }
}
