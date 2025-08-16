using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System;
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
                var client = new SecretClient(_keyVaultUri, new AzureCliCredential());
                KeyVaultSecret secret = await client.GetSecretAsync(_secretName);
                ConnectionString = secret.Value;

                if (!string.IsNullOrEmpty(secret.Value))
                    IsConnectionStringSet = true;
                else
                    IsConnectionStringSet = false;
            }
            catch (Exception ex)
            {
                IsConnectionStringSet = false;
                Console.WriteLine($"Error:\r\n{ex.Message}");
            }
        }
    }
}

