using AutoMapper;
using iTicketAz.BLL.DTOs.CartDTOs;
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

            CreateMap<CartToAddByUserIdDto, CartUserId>();
            CreateMap<CartToAddByUserDataDto, CartUserData>();
        }
    }
}
