using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Threading.Tasks;


namespace MMS.Infrastructure.Data
{
    public class DatabaseConnector
    {
        private readonly AppDbContext _dbContext;
        private readonly ILogger _logger;

        public DatabaseConnector(AppDbContext dbContext, ILogger logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task<bool> TestConnectionAsync()
        {
            try
            {
                return await _dbContext.Database.CanConnectAsync();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "TestConnectionAsync failed.");
                return false;
            }
        }

        public async Task<bool> HealthCheckAsync()
        {
            try
            {
                var canConnect = await _dbContext.Database.CanConnectAsync();
                _logger.Information("HealthCheck: Database connection status: {Status}", canConnect);
                return canConnect;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "HealthCheckAsync failed. Exception: {Message}", ex.Message);
                // Dodaj log za InnerException ako postoji
                if (ex.InnerException != null)
                    _logger.Error(ex.InnerException, "InnerException: {Message}", ex.InnerException.Message);
                return false;
            }
        }
    }
}