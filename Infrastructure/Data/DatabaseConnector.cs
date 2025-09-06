using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Threading.Tasks;

namespace MMS.Infrastructure.Data
{
    /// <summary>
    /// Servis za proveru konekcije i zdravlja baze podataka.
    /// Koristi AppDbContext za pristup bazi i Serilog za logovanje.
    /// </summary>
    public class DatabaseConnector
    {
        // Privatno polje za DbContext aplikacije
        private readonly AppDbContext _dbContext;
        // Privatno polje za logger (Serilog)
        private readonly ILogger _logger;

        /// <summary>
        /// Konstruktor koji prima AppDbContext i Serilog logger.
        /// </summary>
        public DatabaseConnector(AppDbContext dbContext, ILogger logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        /// <summary>
        /// Testira da li je moguæe uspostaviti konekciju sa bazom.
        /// Vraæa true ako je konekcija uspešna, u suprotnom false.
        /// </summary>
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

        /// <summary>
        /// Proverava zdravlje baze i loguje rezultat.
        /// Vraæa true ako je konekcija uspešna, u suprotnom false.
        /// </summary>
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
                // Dodaje log i za InnerException ako postoji
                if (ex.InnerException != null)
                    _logger.Error(ex.InnerException, "InnerException: {Message}", ex.InnerException.Message);
                return false;
            }
        }
    }
}