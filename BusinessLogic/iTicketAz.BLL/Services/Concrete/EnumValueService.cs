using AutoMapper;
using iTicketAz.BLL.DTOs.EnumValueDTOs;
using iTicketAz.BLL.Repositories.Abstract;
using iTicketAz.BLL.Services.Abstract;
using iTicketAz.DAL.Entities;
using System.Linq.Expressions;

namespace iTicketAz.BLL.Services.Concrete
{
    public class EnumValueService : IEnumValueService
    {
        private readonly IRepository<EnumValue> _repository;
        private readonly IMapper _mapper;
        public EnumValueService(IRepository<EnumValue> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Add(EnumValueToAddDto dto)
        {
            _repository.Add(_mapper.Map<EnumValue>(dto));
        }

        public void Delete(int id)
        {
            _repository.Delete(_repository.GetById(id));
        }

        public IEnumerable<EnumValueToListDto> GetAll()
        {
            return _mapper.Map<IEnumerable<EnumValueToListDto>>(_repository.GetAll());
        }

        public EnumValueByIdDto GetById(int id)
        {
            return _mapper.Map<EnumValueByIdDto>(_repository.GetById(id));
        }

        public IEnumerable<EnumValueToListDto> GetWhere(Expression<Func<EnumValue, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(EnumValueToUpdateDto dto)
        {
            _repository.Update(_mapper.Map<EnumValue>(dto));
        }
    }
}
