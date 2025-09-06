using AutoMapper;
using MMS.Application.DTOs;
using MMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MMS.Application.Services
{
    /// <summary>
    /// Servis za autentifikaciju korisnika.
    /// Implementira IAuthService i koristi DbContext i AutoMapper za pristup bazi i mapiranje podataka.
    /// </summary>
    public class AuthService : IAuthService
    {
        // Privatno polje za pristup bazi podataka
        private readonly DbContext _dbContext;
        // Privatno polje za mapiranje entiteta u DTO
        private readonly IMapper _mapper;

        /// <summary>
        /// Konstruktor koji prima DbContext i IMapper instance.
        /// </summary>
        /// <param name="dbContext">Kontekst baze podataka.</param>
        /// <param name="mapper">AutoMapper instanca za mapiranje.</param>
        public AuthService(DbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        /// <summary>
        /// Autentifikuje korisnika na osnovu korisni�kog imena i lozinke.
        /// Ako su podaci ispravni i korisnik je aktivan, vra�a UserDto; u suprotnom vra�a null.
        /// </summary>
        /// <param name="username">Korisni�ko ime.</param>
        /// <param name="password">Lozinka (plain text, nije preporu�ljivo za produkciju).</param>
        /// <returns>UserDto objekat ili null ako autentifikacija nije uspe�na.</returns>
        public async Task<UserDto?> AuthenticateAsync(string username, string password)
        {
            // Pronalazi aktivnog korisnika sa datim korisni�kim imenom
            var user = await _dbContext.Set<User>()
                .FirstOrDefaultAsync(u => u.UserName == username && u.IsActive);

            // Proverava lozinku (plain text pore�enje, samo za razvoj/testiranje)
            if (user != null && user.PasswordHash == password) // samo za plain text, nije preporu�ljivo za produkciju!
            {
                // Mapira User entitet u UserDto i vra�a rezultat
                return _mapper.Map<UserDto>(user);
            }
            // Ako autentifikacija nije uspe�na, vra�a null
            return null;
        }
    }
}