using AutoMapper;
using MMS.Domain.Entities;

namespace MMS.Application.DTOs
{
    /// <summary>
    /// AutoMapper profil za mapiranje između User entiteta i UserDto objekta.
    /// Definiše pravila mapiranja za svojstva koja se ne poklapaju direktno.
    /// </summary>
    public class UserProfile : Profile
    {
        /// <summary>
        /// Konstruktor u kome se definišu pravila mapiranja.
        /// </summary>
        public UserProfile()
        {
            // Mapira User u UserDto
            CreateMap<User, UserDto>()
                // DisplayName se formira spajanjem imena i prezimena korisnika
                .ForMember(dest => dest.DisplayName,
                    opt => opt.MapFrom(src => $"{src.Ime} {src.Prezime}".Trim()))
                // Role se mapira, a ako je null, koristi se prazan string
                .ForMember(dest => dest.Role,
                    opt => opt.MapFrom(src => src.Role ?? ""));
        }
    }
}
