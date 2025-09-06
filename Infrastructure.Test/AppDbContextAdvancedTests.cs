using Xunit;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using MMS.Infrastructure.Data;
using System.Threading.Tasks;
using Moq;

namespace Infrastructure.Test
{
    /// <summary>
    /// Test klasa za napredne funkcionalnosti AppDbContext-a.
    /// Proverava health check i osnovne CRUD operacije nad entitetom Klijent.
    /// </summary>
    public class AppDbContextAdvancedTests
    {
        /// <summary>
        /// Testira da HealthCheckAsync vraæa true i loguje "OK" kada je baza dostupna.
        /// Koristi se in-memory baza i Moq za proveru logovanja.
        /// </summary>
        [Fact]
        public async Task HealthCheckAsync_ReturnsTrue_And_Logs_OK_WhenDatabaseIsAvailable()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase("HealthCheckTestDb")
                .Options;

            var loggerMock = new Moq.Mock<ILogger>();
            await using var context = new AppDbContext(options);

            // Act
            var result = await context.HealthCheckAsync(loggerMock.Object);

            // Assert
            Assert.True(result);
            loggerMock.Verify(
                l => l.Log(
                    LogLevel.Information,
                    Moq.It.IsAny<EventId>(),
                    Moq.It.Is<It.IsAnyType>((v, t) => (v != null && v.ToString() != null && v.ToString().Contains("OK"))),
                    null,
                    Moq.It.IsAny<Func<It.IsAnyType, Exception?, string>>()),
                Moq.Times.Once);
        }

        /// <summary>
        /// Testira da li se entitet Klijent može uspešno upisati i proèitati iz baze.
        /// Koristi se in-memory baza za izolovano testiranje.
        /// </summary>
        [Fact]
        public async Task Can_Insert_And_Read_Klijent()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase("InsertReadKlijentDb")
                .Options;

            var klijent = new MMS.Domain.Entities.Klijent
            {
                NazivKlijenta = "Test Klijent",
                PIB = "123456789",
                IsActive = true
            };

            // Act
            await using (var context = new AppDbContext(options))
            {
                context.Klijenti.Add(klijent);
                await context.SaveChangesAsync();
            }

            // Assert
            await using (var context = new AppDbContext(options))
            {
                var klijentFromDb = await context.Klijenti.FirstOrDefaultAsync(k => k.PIB == "123456789");
                Assert.NotNull(klijentFromDb);
                Assert.Equal("Test Klijent", klijentFromDb.NazivKlijenta);
                Assert.True(klijentFromDb.IsActive);
            }
        }
    }
}