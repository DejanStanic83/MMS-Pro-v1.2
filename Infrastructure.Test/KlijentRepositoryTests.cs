using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MMS.Domain.Entities;
using MMS.Infrastructure.Data;
using Xunit;
using System.Data.SqlClient;

namespace MMS.Infrastructure.Tests
{
    public class KlijentRepositoryTests
    {
        private AppDbContext GetDbContext()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;
            return new AppDbContext(options);
        }

        [Fact]
        public async Task AddAndGetKlijent_WorksCorrectly()
        {
            var db = GetDbContext();
            var repo = new KlijentRepository(db);

            var klijent = new Klijent { NazivKlijenta = "Test Klijent", PIB = "123456", Grad = "Beograd", Email = "test@test.com" };
            await repo.AddAsync(klijent);

            var all = await repo.GetAllAsync();
            Assert.Single(all);

            var fetched = await repo.GetByIdAsync(klijent.Id);
            Assert.NotNull(fetched);
            Assert.Equal("Test Klijent", fetched!.NazivKlijenta);
        }

        [Fact]
        public async Task UpdateAndDeleteKlijent_WorksCorrectly()
        {
            var db = GetDbContext();
            var repo = new KlijentRepository(db);

            var klijent = new Klijent { NazivKlijenta = "Test", PIB = "654321", Grad = "Novi Sad", Email = "test2@test.com" };
            await repo.AddAsync(klijent);

            klijent.NazivKlijenta = "Izmenjen";
            await repo.UpdateAsync(klijent);

            var updated = await repo.GetByIdAsync(klijent.Id);
            Assert.Equal("Izmenjen", updated!.NazivKlijenta);

            await repo.DeleteAsync(klijent.Id);
            var deleted = await repo.GetByIdAsync(klijent.Id);
            Assert.Null(deleted);
        }
    }
}