using Microsoft.Extensions.Configuration;
using MMS.Application.Services;

namespace MMS.Application.Services
{
    /// <summary>
    /// Servis za rad sa klijentima.
    /// Omogu�ava pristup konfiguracionim vrednostima i logovanje poruka.
    /// </summary>
    public class KlijentService
    {
        // Konfiguracija aplikacije (npr. appsettings.json)
        private readonly IConfiguration _config;
        // Logger za logovanje informacija, upozorenja i gre�aka
        private readonly IAppLogger _logger;

        /// <summary>
        /// Konstruktor koji prima konfiguraciju i logger.
        /// </summary>
        /// <param name="config">Konfiguracija aplikacije.</param>
        /// <param name="logger">Logger za logovanje poruka.</param>
        public KlijentService(IConfiguration config, IAppLogger logger)
        {
            _config = config;
            _logger = logger;
        }

        /// <summary>
        /// Vra�a tekst bannera iz konfiguracije.
        /// Ako nije definisan, vra�a podrazumevani tekst "MMS".
        /// </summary>
        /// <returns>Tekst bannera.</returns>
        public string GetBannerText()
        {
            return _config["Shell:BannerText"] ?? "MMS";
        }

        /// <summary>
        /// Test metoda za logovanje razli�itih nivoa poruka.
        /// </summary>
        public void TestLog()
        {
            _logger.Info("Test info poruka iz KlijentService.");
            _logger.Warn("Test warning poruka iz KlijentService.");
            _logger.Error("Test error poruka iz KlijentService.");
        }
    }
}