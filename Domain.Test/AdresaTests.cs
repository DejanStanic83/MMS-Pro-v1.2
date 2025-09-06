using Xunit;
using MMS.Domain.Entities;

namespace Domain.Test
{
    /// <summary>
    /// Test klasa za proveru postavljanja adrese kod entiteta Klijent i Objekat.
    /// </summary>
    public class AdresaTests
    {
        /// <summary>
        /// Testira da li se svojstvo Adresa može uspešno postaviti i proèitati kod entiteta Klijent.
        /// </summary>
        [Fact]
        public void Klijent_Adresa_CanBeSet()
        {
            var klijent = new Klijent
            {
                Adresa = "Bulevar Kralja Aleksandra 73"
            };

            Assert.Equal("Bulevar Kralja Aleksandra 73", klijent.Adresa);
        }

        /// <summary>
        /// Testira da li se svojstvo Adresa može uspešno postaviti i proèitati kod entiteta Objekat.
        /// </summary>
        [Fact]
        public void Objekat_Adresa_CanBeSet()
        {
            var objekat = new Objekat
            {
                Adresa = "Nemanjina 4"
            };

            Assert.Equal("Nemanjina 4", objekat.Adresa);
        }
    }
}