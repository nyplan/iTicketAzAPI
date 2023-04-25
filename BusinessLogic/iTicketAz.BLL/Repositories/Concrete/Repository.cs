using iTicketAz.BLL.Repositories.Abstract;
using iTicketAz.DAL.Contexts;
using iTicketAz.DAL.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace iTicketAz.BLL.Repositories.Concrete
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ITicketAzDbContext _context;
        public Repository(ITicketAzDbContext context)
        {
            _context = context;
        }

        public DbSet<TEntity> Table => _context.Set<TEntity>();

        public void Add(TEntity entity)
        {
            Table.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            Table.Remove(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Table;
        }

        public TEntity GetById(int id)
        {
            return Table.Find(id);
        }

        public void Update(TEntity entity)
        {
            Table.Update(entity);
        }
    }
}
