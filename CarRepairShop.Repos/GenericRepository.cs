using CarRepairShop.Repos;
using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CarRepairShop.Repositories
{
    public class GenericRepository : IGenericRepository
    {
        private readonly string _connectionString = string.Empty;

        public GenericRepository()
        {
            var dbHandler = new DataBaseHandler();
            _connectionString = dbHandler.ConnectionString;
        }

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

        public async Task<IEnumerable<T>> GetAllAsync<T>(string querySufix = "")
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    Type typeT = typeof(T);
                    string sql = $"SELECT * FROM {typeT.Name} {querySufix}";
                    return await connection.QueryAsync<T>(sql, commandType: CommandType.Text);
                }
                catch (Exception ex)
                {
                    return null;
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
    }
}