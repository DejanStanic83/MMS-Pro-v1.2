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
        /// Autentifikuje korisnika na osnovu korisnièkog imena i lozinke.
        /// Ako su podaci ispravni i korisnik je aktivan, vraæa UserDto; u suprotnom vraæa null.
        /// </summary>
        /// <param name="username">Korisnièko ime.</param>
        /// <param name="password">Lozinka (plain text, nije preporuèljivo za produkciju).</param>
        /// <returns>UserDto objekat ili null ako autentifikacija nije uspešna.</returns>
        public async Task<UserDto?> AuthenticateAsync(string username, string password)
        {
            // Pronalazi aktivnog korisnika sa datim korisnièkim imenom
            var user = await _dbContext.Set<User>()
                .FirstOrDefaultAsync(u => u.UserName == username && u.IsActive);

            // Proverava lozinku (plain text poreðenje, samo za razvoj/testiranje)
            if (user != null && user.PasswordHash == password) // samo za plain text, nije preporuèljivo za produkciju!
            {
                // Mapira User entitet u UserDto i vraæa rezultat
                return _mapper.Map<UserDto>(user);
            }
            // Ako autentifikacija nije uspešna, vraæa null
            return null;
        }
    }
}