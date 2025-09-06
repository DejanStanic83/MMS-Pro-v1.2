using System;
using Microsoft.Data.SqlClient;
using Xunit;

namespace Infrastructure.Test
{
    public class DatabaseConnectionTests
    {
        [Fact]
        public void TestSqlConnection()
        {
            var connectionString = "Data Source=L-DEJANS-BGD\\SQLEXPRESS;Initial Catalog=MMS_DB_CS;User ID=DejanStanic;Password=Peradetlic2023#;Encrypt=True;TrustServerCertificate=True";

            try
            {
                using var connection = new SqlConnection(connectionString);
                connection.Open();

                Assert.Equal(System.Data.ConnectionState.Open, connection.State);
            }
            catch (Exception ex)
            {
                // Ispis poruke greške u output/test log
                Console.WriteLine("Greška pri konekciji: " + ex.Message);
                Console.WriteLine(ex.ToString());
                throw; // Ponovo baci izuzetak da test bude oznaèen kao failed
            }
        }
    }
}