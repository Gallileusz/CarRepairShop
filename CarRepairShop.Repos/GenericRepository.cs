using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;

namespace CarRepairShop.Repositories
{
    public class GenericRepository : IGenericRepository
    {
        public static readonly GenericRepository StaticInstance = new GenericRepository();
        private readonly string _connectionString = "Server=192.168.1.223;Database=CarRepairShop;Trusted_Connection=True;";
        public IEnumerable<T> GetAll<T>(string querySufix = "")
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    Type typeT = typeof(T);
                    string sql = $"SELECT * FROM {typeT.Name} {querySufix}";
                    return connection.Query<T>(sql, commandType: CommandType.Text);
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public IEnumerable<T> GetAll<T>(string querySufix, object param)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    Type typeT = typeof(T);
                    string sql = $"SELECT * FROM {typeT.Name} {querySufix}";
                    return connection.Query<T>(sql, param: param, commandType: CommandType.Text);
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public T GetSingle<T>(string filterSuffix, object param = null)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    Type typeT = typeof(T);
                    string sql = $"SELECT TOP 1 * FROM {typeT.Name} WHERE {filterSuffix}";
                    return connection.QuerySingleOrDefault<T>(sql, param: param, commandType: CommandType.Text);
                }
                catch (Exception ex)
                {
                    return default;
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="param">The parameters to pass, if any. Like: new { Id = id }</param>
        /// <returns></returns>
        public List<T> GetManyBySql<T>(string sql, object param = null)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    return connection.Query<T>(sql, param: param, commandType: CommandType.Text).ToList();
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="param">The parameters to pass, if any. Like: new { Id = id }</param>
        /// <returns></returns>
        public async Task<List<T>> GetManyBySqlAsync<T>(string sql, object param = null)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    return (await connection.QueryAsync<T>(sql, param: param, commandType: CommandType.Text)).ToList();
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public T GetSingleBySql<T>(string sql, object param = null)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    return connection.QuerySingleOrDefault<T>(sql, param: param, commandType: CommandType.Text);
                }
                catch (Exception ex)
                {
                    return default;
                }
            }
        }

        public async Task<T> GetSingleBySqlAsync<T>(string sql, object param = null)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    return await connection.QuerySingleOrDefaultAsync<T>(sql, param: param, commandType: CommandType.Text);
                }
                catch (Exception ex)
                {
                    return default;
                }
            }
        }

        public T GetSingleColumnData<T>(string sql, object param = null)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    return connection.QueryFirstOrDefault<T>(sql, param: param, commandType: CommandType.Text);
                }
                catch (Exception ex)
                {
                    return default;
                }
            }
        }

        public async Task<T> GetSingleColumnDataAsync<T>(string sql, object param = null)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    return await connection.QueryFirstOrDefaultAsync<T>(sql, param: param, commandType: CommandType.Text);
                }
                catch (Exception ex)
                {
                    return default;
                }
            }
        }

        public bool UseRawSql(string query, object param = null)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Execute(query, param: param);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public int Execute(string query, object param = null)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    return connection.Execute(query, param: param);
                }
                catch (Exception ex)
                {
                    return -1;
                }
            }
        }

        public List<T1> GetData<T1, T2, T3, T4>(string sql_all, Func<T1, T2, T3, T4> map, string splitOn)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    return (List<T1>)connection.Query(sql_all, map, null, null, true, splitOn);
                }
                catch (Exception)
                {
                    return new List<T1>();
                }
            }
        }

        public List<T3> GetData<T1, T2, T3>(string sql_all, Func<T1, T2, T3> map, string splitOn)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    return (List<T3>)connection.Query(sql_all, map, null, null, true, splitOn);
                }
                catch (Exception)
                {
                    return new List<T3>();
                }
            }
        }

        public bool Update<T>(T objectToUpdate) where T : class
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    return connection.Update(objectToUpdate);
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public int Insert<T>(T objectToInsert) where T : class
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    return (int)connection.Insert(objectToInsert);
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
        }

        public bool Delete<T>(T objectToDelete) where T : class
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    return connection.Delete(objectToDelete);
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public string GenerateInsertSQL<T>(string tableName, List<T> entities)
        {
            var props = typeof(T).GetProperties();
            var cols = string.Join(", ", props.Select(p => p.Name));
            var vals = string.Join(", ", entities.Select(e => "(" + string.Join(", ", props.Select(p =>
            {
                var v = p.GetValue(e);
                return v is string || v is DateTime ? "'" + v + "'" : v?.ToString() ?? "NULL";
            })) + ")"));
            return ("INSERT INTO " + tableName + " (" + cols + ") VALUES " + vals + ";").ToString();
        }
    }
}