using System;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main()
    {
        var connectionString = "Data Source=L-DEJANS-BGD\\SQLEXPRESS;Initial Catalog=MMS_DB_CS;User ID=DejanStanic;Password=Peradetlic2023#;Encrypt=True;TrustServerCertificate=True";

        using var connection = new SqlConnection(connectionString);
        try
        {
            connection.Open();
            Console.WriteLine("Konekcija uspešna!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Greška pri konekciji:");
            Console.WriteLine(ex.Message);
            if (ex.InnerException != null)
                Console.WriteLine("InnerException: " + ex.InnerException.Message);
        }
    }
}
