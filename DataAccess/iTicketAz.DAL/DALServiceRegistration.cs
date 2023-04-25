using iTicketAz.DAL.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.RateLimiting;
using System.Threading.RateLimiting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace iTicketAz.DAL
{
    public static class DALServiceRegistration
    {
        public static void AddDALServices(this IServiceCollection services)
        {
            services.AddDbContext<ITicketAzDbContext>(options =>
            {
                options.UseNpgsql(Configuration.ConnectionString);
            });
            
        }
    }
}
