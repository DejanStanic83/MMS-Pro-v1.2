using MMS.Domain.Entities;

namespace MMS.Application.DTOs
{
    /// <summary>
    /// DTO (Data Transfer Object) klasa za korisnika.
    /// Koristi se za prenos podataka o korisniku izmeðu slojeva aplikacije.
    /// </summary>
    public class UserDto
    {
        // Privatno polje za korisnièko ime, inicijalizovano na prazan string
        private string userName = string.Empty;
        // Privatno polje za lozinku, inicijalizovano na prazan string (nije izloženo kroz javni API)
        private string password = string.Empty;

        /// <summary>
        /// Jedinstveni identifikator korisnika.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Korisnièko ime. Ne može biti null.
        /// </summary>
        public required string UserName
        {
            get => userName;
            set => userName = value ?? string.Empty;
        }

        /// <summary>
        /// Prikazno ime korisnika (npr. "Ime Prezime").
        /// </summary>
        public required string DisplayName { get; set; } = string.Empty;

        /// <summary>
        /// Uloga korisnika (npr. "Admin", "User").
        /// </summary>
        public required string Role { get; set; } = string.Empty;

        /// <summary>
        /// Mapira entitet User u UserDto.
        /// Ova metoda je korisna ako ne koristiš AutoMapper.
        /// </summary>
        /// <param name="user">Entitet korisnika iz domen modela.</param>
        /// <returns>UserDto objekat sa mapiranim vrednostima.</returns>
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

        /// <summary>
        /// Podrazumevani konstruktor. Inicijalizuje polja na prazne stringove.
        /// </summary>
        public UserDto()
        {
            userName = string.Empty;
            password = string.Empty;
            DisplayName = string.Empty;
            Role = string.Empty; // Osigurava da je Role inicijalizovan
            // UserName je required i treba ga postaviti prilikom kreiranja objekta
        }
    }
}