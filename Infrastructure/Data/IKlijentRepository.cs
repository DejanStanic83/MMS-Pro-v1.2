using MMS.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MMS.Infrastructure.Data
{
    /// <summary>
    /// Interfejs za repozitorijum klijenata.
    /// Defini�e osnovne asinhrone CRUD operacije nad entitetom Klijent.
    /// Implementacije ovog interfejsa omogu�avaju rad sa skladi�tem podataka (baza, API, itd).
    /// </summary>
    public interface IKlijentRepository
    {
        /// <summary>
        /// Vra�a sve klijente iz skladi�ta podataka.
        /// </summary>
        /// <returns>Enumerable kolekcija svih klijenata.</returns>
        Task<IEnumerable<Klijent>> GetAllAsync();

        /// <summary>
        /// Vra�a klijenta po ID-u ili null ako ne postoji.
        /// </summary>
        /// <param name="id">Jedinstveni identifikator klijenta.</param>
        /// <returns>Klijent ili null.</returns>
        Task<Klijent?> GetByIdAsync(int id);

        /// <summary>
        /// Dodaje novog klijenta u skladi�te podataka.
        /// </summary>
        /// <param name="klijent">Klijent za dodavanje.</param>
        Task AddAsync(Klijent klijent);

        /// <summary>
        /// A�urira postoje�i entitet klijenta.
        /// </summary>
        /// <param name="klijent">Klijent sa izmenjenim podacima.</param>
        Task UpdateAsync(Klijent klijent);

        /// <summary>
        /// Bri�e klijenta na osnovu ID-a.
        /// </summary>
        /// <param name="id">Jedinstveni identifikator klijenta za brisanje.</param>
        Task DeleteAsync(int id);
    }
}