using iTicketAz.DAL.Entities.Common;

namespace iTicketAz.DAL.Entities
{
    public class PriceType : BaseEntity
    {
        public int Price { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
