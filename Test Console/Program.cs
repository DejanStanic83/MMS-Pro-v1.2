using System;
using Microsoft.Data.SqlClient;

class Program
{
    /// <summary>
    /// Ulazna tačka konzolne aplikacije.
    /// Pokušava da uspostavi konekciju sa SQL Server bazom i ispisuje rezultat u konzolu.
    /// </summary>
    static void Main()
    {
        // Connection string za SQL Server bazu podataka.
        // Sadrži: server, naziv baze, korisničko ime, lozinku i sigurnosne opcije.
        var connectionString = "Data Source=L-DEJANS-BGD\\SQLEXPRESS;Initial Catalog=MMS_DB_CS;User ID=DejanStanic;Password=Peradetlic2023#;Encrypt=True;TrustServerCertificate=True";

        // Kreira SQL konekciju koristeći prosleđeni connection string.
        using var connection = new SqlConnection(connectionString);
        try
        {
            // Pokušava da otvori konekciju sa bazom.
            connection.Open();
            Console.WriteLine("Konekcija uspešna!");
        }
        catch (Exception ex)
        {
            // U slučaju greške pri konekciji, ispisuje poruku i detalje greške.
            Console.WriteLine("Greška pri konekciji:");
            Console.WriteLine(ex.Message);
            if (ex.InnerException != null)
                Console.WriteLine("InnerException: " + ex.InnerException.Message);
        }
    }
}
