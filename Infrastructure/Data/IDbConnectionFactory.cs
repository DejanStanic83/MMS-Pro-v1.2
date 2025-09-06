using System.Data;

namespace MMS.Infrastructure.Data
{
    /// <summary>
    /// Interfejs za fabriku konekcija ka bazi podataka.
    /// Omogu�ava kreiranje IDbConnection objekta nezavisno od konkretne baze (SQL Server, SQLite, itd).
    /// Implementacije ovog interfejsa obezbe�uju na�in za dobijanje nove konekcije.
    /// </summary>
    public interface IDbConnectionFactory
    {
        /// <summary>
        /// Kreira i vra�a novu instancu IDbConnection.
        /// </summary>
        /// <returns>IDbConnection objekat spreman za kori��enje.</returns>
        IDbConnection CreateConnection();
    }
}