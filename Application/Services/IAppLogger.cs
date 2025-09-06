using System;

namespace MMS.Application.Services
{
    /// <summary>
    /// Interfejs za aplikacioni logger.
    /// Defini�e metode za logovanje informacija, upozorenja i gre�aka.
    /// Implementacije mogu koristiti razli�ite log sisteme (npr. Serilog, NLog).
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
        /// Loguje gre�ku, uz opcionalni exception.
        /// </summary>
        /// <param name="message">Poruka za logovanje.</param>
        /// <param name="ex">Exception koji se loguje (mo�e biti null).</param>
        void Error(string message, Exception? ex = null);
    }
}