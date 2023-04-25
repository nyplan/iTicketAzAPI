using iTicketAz.BLL.Services.Abstract;
using iTicketAz.BLL.UnitOfWork.Abstract;
using iTicketAz.DAL.Contexts;

namespace iTicketAz.BLL.UnitOfWork.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ITicketAzDbContext _context;
        public IUserService UserService { get; set; }

        public IEnumValueService EnumValueService { get; set; }

        public UnitOfWork(ITicketAzDbContext context, IUserService userService, IEnumValueService enumValueService)
        {
            _context = context;
            UserService = userService;
            EnumValueService = enumValueService;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
