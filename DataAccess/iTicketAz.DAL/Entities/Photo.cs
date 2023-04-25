using iTicketAz.DAL.Entities.Common;

namespace iTicketAz.DAL.Entities
{
    public class Photo : BaseEntity
    {
        public string Url { get; set; }
        public int EventId { get; set; }
    }
}
