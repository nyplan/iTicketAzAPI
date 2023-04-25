using iTicketAz.DAL.Entities.Common;

namespace iTicketAz.DAL.Entities
{
    public class Event : BaseEntity
    {
        public string Name { get; set; }
        public string About { get; set; }
        public int AgeRestrictionId { get; set; }
        public int LanguageId { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public ICollection<PriceType> PriceTypes { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
