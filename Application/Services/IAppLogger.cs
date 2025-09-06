using System;

namespace MMS.Application.Services
{
    /// <summary>
    /// Interfejs za aplikacioni logger.
    /// Definiše metode za logovanje informacija, upozorenja i grešaka.
    /// Implementacije mogu koristiti razlièite log sisteme (npr. Serilog, NLog).
    /// </summary>
    public interface IAppLogger
    {
        /// <summary>
        /// Loguje informativnu poruku.
        /// </summary>
        /// <param name="message">Poruka za logovanje.</param>
        void Info(string message);

        /// <summary>
        /// Loguje upozorenje.
        /// </summary>
        /// <param name="message">Poruka za logovanje.</param>
        void Warn(string message);

        /// <summary>
        /// Loguje grešku, uz opcionalni exception.
        /// </summary>
        /// <param name="message">Poruka za logovanje.</param>
        /// <param name="ex">Exception koji se loguje (može biti null).</param>
        void Error(string message, Exception? ex = null);
    }
}