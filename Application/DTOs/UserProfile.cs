using AutoMapper;
using MMS.Domain.Entities;

namespace MMS.Application.DTOs
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>()
                .ForMember(dest => dest.DisplayName,
                    opt => opt.MapFrom(src => $"{src.Ime} {src.Prezime}".Trim()))
                .ForMember(dest => dest.Role,
                    opt => opt.MapFrom(src => src.Role ?? ""));
        }
    }
}
