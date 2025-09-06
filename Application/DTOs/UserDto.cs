using MMS.Domain.Entities;

namespace MMS.Application.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string Role { get; set; }

        // Ova metoda je potrebna samo ako ne koristiš AutoMapper
        public static UserDto MapToDto(User user)
        {
            return new UserDto
            {
                Id = user.Id,
                UserName = user.UserName ?? "",
                DisplayName = $"{user.Ime} {user.Prezime}".Trim(),
                Role = user.Role ?? ""
            };
        }
    }
}