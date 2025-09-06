using System;
using Microsoft.Data.SqlClient;
using Xunit;

namespace Infrastructure.Test
{
    /// <summary>
    /// Test klasa za proveru direktne konekcije na SQL Server bazu podataka.
    /// Ovaj test proverava da li se mo�e uspostaviti veza koriste�i zadati connection string.
    /// </summary>
    public class DatabaseConnectionTests
    {
        /// <summary>
        /// Testira da li se SQL konekcija mo�e uspe�no otvoriti.
        /// Ako konekcija ne mo�e da se otvori, test �e pasti i ispisati poruku gre�ke.
        /// </summary>
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
                // Ispis poruke gre�ke u output/test log
                Console.WriteLine("Gre�ka pri konekciji: " + ex.Message);
                Console.WriteLine(ex.ToString());
                throw; // Ponovo baci izuzetak da test bude ozna�en kao failed
            }
        }
    }
}