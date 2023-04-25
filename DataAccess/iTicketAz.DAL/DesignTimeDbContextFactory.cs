using iTicketAz.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace iTicketAz.DAL
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ITicketAzDbContext>
    {
        public ITicketAzDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ITicketAzDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
