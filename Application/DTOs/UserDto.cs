using MMS.Domain.Entities;

namespace MMS.Application.DTOs
{
    public class UserDto
    {
        private string userName = string.Empty;
        private string password = string.Empty;
        public int Id { get; set; }
        public required string UserName
        {
            get => userName;
            set => userName = value ?? string.Empty;
        }
        public required string DisplayName { get; set; } = string.Empty;
        public required string Role { get; set; } = string.Empty;

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

        public UserDto()
        {
            userName = string.Empty;
            password = string.Empty;
            DisplayName = string.Empty;
            Role = string.Empty; // Ensure Role is initialized
            // Removed explicit initialization of UserName here
            // as it is required and should be set by the caller
        }
    }
}