using iTicketAz.DAL.Entities.Common;

namespace iTicketAz.DAL.Entities
{
    public class EnumValue : BaseEntity
    {
        public string Value { get; set; }
        public int KeyId { get; set; }
    }
}
