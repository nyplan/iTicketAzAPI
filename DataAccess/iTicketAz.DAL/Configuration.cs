using Microsoft.Extensions.Configuration;

namespace iTicketAz.DAL
{
    static class Configuration
    {
        public static string ConnectionString 
        {
            get
            {
                ConfigurationManager configuration = new();
                configuration.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/iTicketAz.API"));
                configuration.AddJsonFile("appsettings.json");
                return configuration.GetConnectionString("PostgreSQL");
            }
        }
    }
}
