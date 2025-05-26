using System;
using Microsoft.Extensions.Configuration;

namespace CarRepairShop.Repositories
{
    public static class AppSettings
    {
        private static IConfigurationRoot configuration;

        static AppSettings()
        {
            configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
        }

        public static string ConnectionString => configuration.GetConnectionString("DefaultConnection");
    }
}
