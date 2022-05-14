using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationStore.Persistence.Configurations
{
    public static class ConnectionStringConfiguration
    {
        public static string Configure(string connectionString = "MsSql")
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/MyApplicationStore.WebAPI"));
            configurationManager.AddJsonFile("appsettings.json");
            return configurationManager.GetConnectionString(connectionString);
        }

    }
}
