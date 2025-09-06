using System.Data;

namespace MMS.Infrastructure.Data
{
    /// <summary>
    /// Interfejs za fabriku konekcija ka bazi podataka.
    /// Omoguæava kreiranje IDbConnection objekta nezavisno od konkretne baze (SQL Server, SQLite, itd).
    /// Implementacije ovog interfejsa obezbeðuju naèin za dobijanje nove konekcije.
    /// </summary>
    public interface IDbConnectionFactory
    {
        /// <summary>
        /// Kreira i vraæa novu instancu IDbConnection.
        /// </summary>
        /// <returns>IDbConnection objekat spreman za korišæenje.</returns>
        IDbConnection CreateConnection();
    }
}