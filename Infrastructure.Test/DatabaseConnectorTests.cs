using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Serilog;
using MMS.Infrastructure.Data;
using Xunit;
using System.Data.SqlClient;

namespace MMS.Infrastructure.Tests
{
    public class DatabaseConnectorTests
    {
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