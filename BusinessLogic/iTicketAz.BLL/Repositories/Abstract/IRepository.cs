using iTicketAz.DAL.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace iTicketAz.BLL.Repositories.Abstract
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        DbSet<TEntity> Table { get; }
    }
}
