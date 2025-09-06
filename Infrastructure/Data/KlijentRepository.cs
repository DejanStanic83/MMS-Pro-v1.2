using System.Collections.Generic;
using System.Threading.Tasks;
using MMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace MMS.Infrastructure.Data
{
    public class KlijentRepository : IKlijentRepository
    {
        private readonly AppDbContext _db;

        public KlijentRepository(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Klijent>> GetAllAsync()
        {
            return await _db.Klijenti.ToListAsync();
        }

        public async Task<Klijent?> GetByIdAsync(int id)
        {
            return await _db.Klijenti.FindAsync(id);
        }

        public async Task AddAsync(Klijent klijent)
        {
            _db.Klijenti.Add(klijent);
            await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(Klijent klijent)
        {
            _db.Klijenti.Update(klijent);
            await _db.SaveChangesAsync();
        }

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