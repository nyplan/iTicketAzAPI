using AutoMapper;
using iTicketAz.BLL.DTOs.UserDTOs;
using iTicketAz.DAL.Entities;

namespace iTicketAz.BLL.Mappers
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<User, UserToListDto>();
            CreateMap<User, UserByIdDto>();
            CreateMap<UserToAddDto, User>();
            CreateMap<UserToUpdateDto, User>();
        }
    }
}
