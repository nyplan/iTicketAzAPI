namespace iTicketAz.BLL.DTOs.UserDTOs
{
    public record UserToListDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
