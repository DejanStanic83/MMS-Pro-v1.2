using System.Collections.Generic;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja korisnièku ulogu u sistemu (npr. "Admin", "User", "Menadžer").
    /// Sadrži osnovne podatke o ulozi i vezu sa korisnicima koji imaju tu ulogu.
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Jedinstveni identifikator uloge.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Naziv uloge (npr. "Admin", "User").
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: kolekcija korisnika koji imaju ovu ulogu.
        /// </summary>
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}