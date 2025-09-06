using System;
using Serilog;

namespace MMS.Application.Services
{
    /// <summary>
    /// Implementacija interfejsa IAppLogger koristeæi Serilog za logovanje informacija, upozorenja i grešaka.
    /// </summary>
    public class AppLogger : IAppLogger
    {
        // Privatno Serilog ILogger polje koje se koristi za logovanje
        private readonly ILogger _logger;

        /// <summary>
        /// Konstruktor koji prima Serilog ILogger instancu.
        /// </summary>
        /// <param name="logger">Serilog logger koji se koristi za logovanje.</param>
        public AppLogger(ILogger logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Loguje informaciju.
        /// </summary>
        /// <param name="message">Poruka za logovanje.</param>
        public void Info(string message) => _logger.Information(message);

        /// <summary>
        /// Loguje upozorenje.
        /// </summary>
        /// <param name="message">Poruka za logovanje.</param>
        public void Warn(string message) => _logger.Warning(message);

        /// <summary>
        /// Loguje grešku, uz opcionalni exception.
        /// </summary>
        /// <param name="message">Poruka za logovanje.</param>
        /// <param name="ex">Exception koji se loguje (može biti null).</param>
        public void Error(string message, Exception? ex = null) =>
            _logger.Error(ex, message);
    }
}