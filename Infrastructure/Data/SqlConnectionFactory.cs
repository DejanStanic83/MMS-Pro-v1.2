using System.Data;
using System.Data.SqlClient;
//using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;

namespace MMS.Infrastructure.Data
{
    /// <summary>
    /// Implementacija IDbConnectionFactory interfejsa za SQL Server bazu podataka.
    /// Omogu�ava kreiranje novih SQL konekcija na osnovu prosle�enog connection string-a.
    /// </summary>
    public class SqlConnectionFactory : IDbConnectionFactory
    {
        // Privatno polje za �uvanje connection string-a
        private readonly string _connectionString;

        /// <summary>
        /// Konstruktor koji prima connection string za SQL Server bazu.
        /// </summary>
        /// <param name="connectionString">Connection string za bazu podataka.</param>
        public SqlConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Kreira i vra�a novu SQL Server konekciju.
        /// </summary>
        /// <returns>IDbConnection instanca spremna za kori��enje.</returns>
        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}