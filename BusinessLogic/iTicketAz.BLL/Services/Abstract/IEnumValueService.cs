using iTicketAz.BLL.DTOs.EnumValueDTOs;
using iTicketAz.DAL.Entities;
using System.Linq.Expressions;

namespace iTicketAz.BLL.Services.Abstract
{
    public interface IEnumValueService
    {
        IEnumerable<EnumValueToListDto> GetAll();
        IEnumerable<EnumValueToListDto> GetWhere(Expression<Func<EnumValue, bool>> expression);
        EnumValueByIdDto GetById(int id);

        void Add(EnumValueToAddDto dto);
        void Update(EnumValueToUpdateDto dto);
        void Delete(int id);
    }
}
