using MMS.Application.DTOs;
using System.Threading.Tasks;

namespace MMS.Application.Services
{
    /// <summary>
    /// Interfejs za servis za autentifikaciju korisnika.
    /// Defini�e metodu za proveru korisni�kih kredencijala i vra�anje korisni�kog DTO objekta.
    /// </summary>
    public interface IAuthService
    {
        /// <summary>
        /// Autentifikuje korisnika na osnovu korisni�kog imena i lozinke.
        /// Ako su kredencijali ispravni, vra�a UserDto; u suprotnom vra�a null.
        /// </summary>
        /// <param name="username">Korisni�ko ime.</param>
        /// <param name="password">Lozinka korisnika.</param>
        /// <returns>UserDto objekat ili null ako autentifikacija nije uspe�na.</returns>
        Task<UserDto?> AuthenticateAsync(string username, string password);
    }
}