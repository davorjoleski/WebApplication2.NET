using WebApplication2.DTOs;
using WebApplication2.Models;
using AutoMapper;

namespace WebApplication2.Mappings
{
    public class UserProfile : Profile
    {

        public UserProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<CreateUserDto, User>();
            CreateMap<UpdateUserDto, User>();
        }
    }
}
