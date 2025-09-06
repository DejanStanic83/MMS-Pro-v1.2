using MMS.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace MMS.Infrastructure.Data
{
    public interface IKlijentRepository
    {
        Task<IEnumerable<Klijent>> GetAllAsync();
        Task<Klijent?> GetByIdAsync(int id);
        Task AddAsync(Klijent klijent);
        Task UpdateAsync(Klijent klijent);
        Task DeleteAsync(int id);
    }
}