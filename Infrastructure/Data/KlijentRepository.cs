using System.Collections.Generic;
using System.Threading.Tasks;
using MMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MMS.Infrastructure.Data
{
    /// <summary>
    /// Implementacija repozitorijuma za entitet Klijent.
    /// Omogu�ava asinhrone CRUD operacije nad klijentima koriste�i AppDbContext i Entity Framework Core.
    /// </summary>
    public class KlijentRepository : IKlijentRepository
    {
        // Privatno polje za pristup bazi podataka
        private readonly AppDbContext _db;

        /// <summary>
        /// Konstruktor koji prima instancu AppDbContext.
        /// </summary>
        /// <param name="db">DbContext za pristup bazi podataka.</param>
        public KlijentRepository(AppDbContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Vra�a sve klijente iz baze podataka.
        /// </summary>
        /// <returns>Lista svih klijenata.</returns>
        public async Task<IEnumerable<Klijent>> GetAllAsync()
        {
            return await _db.Klijenti.ToListAsync();
        }

        /// <summary>
        /// Vra�a klijenta po ID-u ili null ako ne postoji.
        /// </summary>
        /// <param name="id">Jedinstveni identifikator klijenta.</param>
        /// <returns>Klijent ili null.</returns>
        public async Task<Klijent?> GetByIdAsync(int id)
        {
            return await _db.Klijenti.FindAsync(id);
        }

        /// <summary>
        /// Dodaje novog klijenta u bazu podataka i �uva promene.
        /// </summary>
        /// <param name="klijent">Klijent za dodavanje.</param>
        public async Task AddAsync(Klijent klijent)
        {
            _db.Klijenti.Add(klijent);
            await _db.SaveChangesAsync();
        }

        /// <summary>
        /// A�urira postoje�i entitet klijenta i �uva promene.
        /// </summary>
        /// <param name="klijent">Klijent sa izmenjenim podacima.</param>
        public async Task UpdateAsync(Klijent klijent)
        {
            _db.Klijenti.Update(klijent);
            await _db.SaveChangesAsync();
        }

        /// <summary>
        /// Bri�e klijenta na osnovu ID-a, ako postoji, i �uva promene.
        /// </summary>
        /// <param name="id">Jedinstveni identifikator klijenta za brisanje.</param>
        public async Task DeleteAsync(int id)
        {
            var klijent = await _db.Klijenti.FindAsync(id);
            if (klijent != null)
            {
                _db.Klijenti.Remove(klijent);
                await _db.SaveChangesAsync();
            }
        }
    }
}