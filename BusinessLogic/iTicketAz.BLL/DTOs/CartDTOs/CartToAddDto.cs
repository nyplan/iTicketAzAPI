namespace iTicketAz.BLL.DTOs.CartDTOs
{
    public record CartToAddDto
    {
        public string? PromoCode { get; set; }
        public int Total { get; set; }
    }
}
