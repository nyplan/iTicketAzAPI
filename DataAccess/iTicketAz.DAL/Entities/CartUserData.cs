namespace iTicketAz.DAL.Entities
{
    public class CartUserData : Cart
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
    }
}
