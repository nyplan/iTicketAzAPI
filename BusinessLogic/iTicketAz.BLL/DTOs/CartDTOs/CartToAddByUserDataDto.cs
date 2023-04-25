namespace iTicketAz.BLL.DTOs.CartDTOs
{
    public record CartToAddByUserDataDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string? PromoCode { get; set; }
        public int Total { get; set; }
    }
}
