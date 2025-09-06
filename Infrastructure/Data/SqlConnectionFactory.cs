using System.Data;
using System.Data.SqlClient;
//using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;

namespace MMS.Infrastructure.Data
{
    public class SqlConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;

        public SqlConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}