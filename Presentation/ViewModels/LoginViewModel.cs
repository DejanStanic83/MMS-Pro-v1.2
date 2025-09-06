using Domain.Common;
using System.Threading.Tasks;
using MMS.Application.Services;

namespace MMS.Presentation.ViewModels
{
    /// <summary>
    /// ViewModel za login funkcionalnost u WPF aplikaciji.
    /// Koristi se za autentifikaciju korisnika i postavljanje korisni�ke sesije.
    /// </summary>
    public class LoginViewModel
    {
        // Referenca na servis za korisni�ku sesiju
        private readonly IUserSession _userSession;
        // Referenca na servis za autentifikaciju korisnika
        private readonly IAuthService _authService;

        /// <summary>
        /// Konstruktor koji prima servise za sesiju i autentifikaciju.
        /// </summary>
        /// <param name="userSession">Servis za upravljanje korisni�kom sesijom.</param>
        /// <param name="authService">Servis za autentifikaciju korisnika.</param>
        public LoginViewModel(IUserSession userSession, IAuthService authService)
        {
            _userSession = userSession;
            _authService = authService;
        }

        /// <summary>
        /// Poku�ava da prijavi korisnika na osnovu korisni�kog imena i lozinke.
        /// Ako su kredencijali ispravni, postavlja korisni�ku sesiju i vra�a true.
        /// Ina�e vra�a false.
        /// </summary>
        /// <param name="username">Korisni�ko ime.</param>
        /// <param name="password">Lozinka.</param>
        /// <returns>True ako je login uspe�an, ina�e false.</returns>
        public async Task<bool> LoginAsync(string username, string password)
        {
            var user = await _authService.AuthenticateAsync(username, password);
            if (user != null)
            {
                _userSession.SetUser(user.Id, user.UserName, user.DisplayName, user.Role);
                return true;
            }
            return false;
        }
    }
}