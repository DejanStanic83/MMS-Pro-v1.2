using MMS.Application.DTOs;
using System.Threading.Tasks;

namespace MMS.Application.Services
{
    /// <summary>
    /// Interfejs za servis za autentifikaciju korisnika.
    /// Definiše metodu za proveru korisnièkih kredencijala i vraæanje korisnièkog DTO objekta.
    /// </summary>
    public interface IAuthService
    {
        /// <summary>
        /// Autentifikuje korisnika na osnovu korisnièkog imena i lozinke.
        /// Ako su kredencijali ispravni, vraæa UserDto; u suprotnom vraæa null.
        /// </summary>
        /// <param name="username">Korisnièko ime.</param>
        /// <param name="password">Lozinka korisnika.</param>
        /// <returns>UserDto objekat ili null ako autentifikacija nije uspešna.</returns>
        Task<UserDto?> AuthenticateAsync(string username, string password);
    }
}