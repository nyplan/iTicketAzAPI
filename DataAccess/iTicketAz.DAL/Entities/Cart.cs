using iTicketAz.DAL.Entities.Common;

namespace iTicketAz.DAL.Entities
{
    public class Cart : BaseEntity
    {
        public string? PromoCode { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        public int Total { get; set; }
    }
}
