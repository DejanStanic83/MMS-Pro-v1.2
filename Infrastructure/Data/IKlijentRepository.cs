using MMS.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MMS.Infrastructure.Data
{
    /// <summary>
    /// Interfejs za repozitorijum klijenata.
    /// Definiše osnovne asinhrone CRUD operacije nad entitetom Klijent.
    /// Implementacije ovog interfejsa omoguæavaju rad sa skladištem podataka (baza, API, itd).
    /// </summary>
    public interface IKlijentRepository
    {
        /// <summary>
        /// Vraæa sve klijente iz skladišta podataka.
        /// </summary>
        /// <returns>Enumerable kolekcija svih klijenata.</returns>
        Task<IEnumerable<Klijent>> GetAllAsync();

        /// <summary>
        /// Vraæa klijenta po ID-u ili null ako ne postoji.
        /// </summary>
        /// <param name="id">Jedinstveni identifikator klijenta.</param>
        /// <returns>Klijent ili null.</returns>
        Task<Klijent?> GetByIdAsync(int id);

        /// <summary>
        /// Dodaje novog klijenta u skladište podataka.
        /// </summary>
        /// <param name="klijent">Klijent za dodavanje.</param>
        Task AddAsync(Klijent klijent);

        /// <summary>
        /// Ažurira postojeæi entitet klijenta.
        /// </summary>
        /// <param name="klijent">Klijent sa izmenjenim podacima.</param>
        Task UpdateAsync(Klijent klijent);

        /// <summary>
        /// Briše klijenta na osnovu ID-a.
        /// </summary>
        /// <param name="id">Jedinstveni identifikator klijenta za brisanje.</param>
        Task DeleteAsync(int id);
    }
}