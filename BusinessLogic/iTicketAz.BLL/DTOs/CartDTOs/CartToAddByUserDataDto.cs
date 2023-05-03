namespace iTicketAz.BLL.DTOs.CartDTOs
{
    public record CartToAddByUserDataDto : CartToAddDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
    }
}
