using iTicketAz.BLL.Services.Abstract;
using iTicketAz.DAL.Contexts;

namespace iTicketAz.BLL.UnitOfWork.Abstract
{
    public interface IUnitOfWork
    {
        public IUserService UserService { get; }
        public IEnumValueService EnumValueService { get; }
        void Commit();
    }
}
