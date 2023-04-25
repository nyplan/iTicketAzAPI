using iTicketAz.DAL.Entities.Common;

namespace iTicketAz.DAL.Entities
{
    public class Ticket : BaseEntity
    {
        public int TypeId { get; set; }
        public int EventId { get; set; }
        public int Count { get; set; }
        public ICollection<Cart> Carts { get; set; }
    }
}
