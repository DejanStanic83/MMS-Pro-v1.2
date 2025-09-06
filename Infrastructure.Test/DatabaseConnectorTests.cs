using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Serilog;
using MMS.Infrastructure.Data;
using Xunit;
using System.Data.SqlClient;

namespace MMS.Infrastructure.Tests
{
    /// <summary>
    /// Test klasa za DatabaseConnector servis.
    /// Proverava da li HealthCheckAsync metoda ispravno detektuje dostupnost baze.
    /// </summary>
    public class DatabaseConnectorTests
    {
        /// <summary>
        /// Testira da HealthCheckAsync vraæa true kada je baza dostupna.
        /// Koristi se in-memory baza i Serilog logger za test okruženje.
        /// </summary>
        [Fact]
        public async Task HealthCheckAsync_ReturnsTrue_WhenDbIsAvailable()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase("HealthCheckTestDb")
                .Options;
            var dbContext = new AppDbContext(options);

            // Koristi Serilog logger koji ne piše u fajl (za test)
            var logger = new LoggerConfiguration().CreateLogger();
            var connector = new DatabaseConnector(dbContext, logger);

            var result = await connector.HealthCheckAsync();
            Assert.True(result);
        }
    }
}