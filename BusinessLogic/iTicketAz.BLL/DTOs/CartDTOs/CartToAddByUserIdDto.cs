namespace iTicketAz.BLL.DTOs.CartDTOs
{
    public record CartToAddByUserIdDto : CartToAddDto
    {
        public int UserId { get; set; }
    }
}
