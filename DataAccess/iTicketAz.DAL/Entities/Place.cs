using iTicketAz.DAL.Entities.Common;

namespace iTicketAz.DAL.Entities
{
    public class Place : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Capacity { get; set; }
        public TimeOnly Open { get; set; }
        public TimeOnly Close { get; set; }
    }
}
