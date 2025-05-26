using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRepairShop.Repositories
{
    public interface IGenericRepository
    {
        IEnumerable<T> GetAll<T>(string querySufix = "");
        IEnumerable<T> GetAll<T>(string querySufix, object param);
        T GetSingle<T>(string filterSuffix, object param = null);
        List<T> GetManyBySql<T>(string sql, object param = null);
        Task<List<T>> GetManyBySqlAsync<T>(string sql, object param = null);
        T GetSingleColumnData<T>(string sql, object param = null);
        Task<T> GetSingleColumnDataAsync<T>(string sql, object param = null);
        bool UseRawSql(string query, object param = null);
        bool Update<T>(T objectToUpdate) where T : class;
        int Insert<T>(T objectToInsert) where T : class;
        bool Delete<T>(T objectToDelete) where T : class;
        List<T1> GetData<T1, T2, T3, T4>(string sql_all, Func<T1, T2, T3, T4> map, string splitOn);
        T GetSingleBySql<T>(string sql, object param = null);
        Task<T> GetSingleBySqlAsync<T>(string sql, object param = null);
        string GenerateInsertSQL<T>(string tableName, List<T> entities);
    }
}
