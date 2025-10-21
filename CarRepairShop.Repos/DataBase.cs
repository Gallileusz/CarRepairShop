using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using CarRepairShop.Settings;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CarRepairShop.Repos
{
    public static class DataBase
    {
        private const string _secretName = "ConnectionString";
        private static readonly Uri _keyVaultUri = new Uri("https://dbconnectionstringkey.vault.azure.net/");

        public static string ConnectionString = string.Empty;

        public static bool IsConnectionStringSet;

        public static async Task SetConnectionStringAsync()
        {
            try
            {
                if (ConnectionProvider.ProductionConnection)
                    await SetProductionConnection();
                else
                    SetDemoConnection();
            }
            catch (Exception ex)
            {
                IsConnectionStringSet = false;
                Console.WriteLine($"Error:\r\n{ex.Message}");
            }
        }

        private static async Task SetProductionConnection()
        {
            var client = new SecretClient(_keyVaultUri, new AzureCliCredential());
            KeyVaultSecret secret = await client.GetSecretAsync(_secretName);
            ConnectionString = secret.Value;

            if (!string.IsNullOrEmpty(secret.Value))
                IsConnectionStringSet = true;
            else
                IsConnectionStringSet = false;
        }

        private static void SetDemoConnection()
        {
            ConnectionString = ConnectionProvider.DemoConnectionString;
            if (!string.IsNullOrEmpty(ConnectionString))
                IsConnectionStringSet = true;
            else
                IsConnectionStringSet = false;
        }

        public static async Task<bool> TryDatabaseConnectionAsync()
        {
            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    await connection.OpenAsync();
                    return connection.State == System.Data.ConnectionState.Open;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}

