using AutoMapper;
using iTicketAz.BLL.DTOs.UserDTOs;
using iTicketAz.BLL.Repositories.Abstract;
using iTicketAz.BLL.Services.Abstract;
using iTicketAz.DAL.Entities;

namespace iTicketAz.BLL.Services.Concrete
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _repository;
        private readonly IMapper _mapper;
        public UserService(IRepository<User> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Add(UserToAddDto dto)
        {
            _repository.Add(_mapper.Map<User>(dto));
        }

        public void Delete(int id)
        {
            _repository.Delete(_repository.GetById(id));
        }

        public IEnumerable<UserToListDto> GetAll()
        {
            return _mapper.Map<IEnumerable<UserToListDto>>(_repository.GetAll());
        }

        public UserByIdDto GetById(int id)
        {
            return _mapper.Map<UserByIdDto>(_repository.GetById(id));
        }

        public void Update(UserToUpdateDto dto)
        {
            _repository.Update(_mapper.Map<User>(dto));
        }
    }
}
