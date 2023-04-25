namespace iTicketAz.BLL.DTOs.CartDTOs
{
    public class CartToAddByUserIdDto
    {
        public int UserId { get; set; }
        public string? PromoCode { get; set; }
        public int Total { get; set; }
    }
}
