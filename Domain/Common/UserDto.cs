using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    /// <summary>
    /// DTO (Data Transfer Object) klasa za korisnika.
    /// Služi za prenos osnovnih podataka o korisniku između slojeva aplikacije.
    /// </summary>
    public class UserDto
    {
        /// <summary>
        /// Jedinstveni identifikator korisnika.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Korisničko ime.
        /// </summary>
        public string UserName { get; set; } = string.Empty;

        /// <summary>
        /// Prikazno ime korisnika (npr. "Ime Prezime").
        /// </summary>
        public string DisplayName { get; set; } = string.Empty;

        /// <summary>
        /// Uloga korisnika (npr. "Admin", "User").
        /// </summary>
        public string Role { get; set; } = string.Empty;
    }
}
