using iTicketAz.BLL.DTOs.UserDTOs;

namespace iTicketAz.BLL.Services.Abstract
{
    public interface IUserService
    {
        IEnumerable<UserToListDto> GetAll();
        UserByIdDto GetById(int id);
        void Add(UserToAddDto dto);
        void Update(UserToUpdateDto dto);
        void Delete(int id);
    }
}
