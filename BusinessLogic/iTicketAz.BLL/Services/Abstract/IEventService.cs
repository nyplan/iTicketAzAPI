using iTicketAz.BLL.DTOs.EventDTOs;

namespace iTicketAz.BLL.Services.Abstract
{
    public interface IEventService
    {
        IEnumerable<EventToListDto> GetAll();
        EventByIdDto GetById(int id);
        void Add(EventToAddDto dto);
        void Update(EventToUpdateDto dto);
        void Delete(int id);
    }
}
