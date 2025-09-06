using Xunit;
using MMS.Domain.Entities;

namespace Domain.Test
{
    public class AdresaTests
    {
        [Fact]
        public void Klijent_Adresa_CanBeSet()
        {
            var klijent = new Klijent
            {
                Adresa = "Bulevar Kralja Aleksandra 73"
            };

            Assert.Equal("Bulevar Kralja Aleksandra 73", klijent.Adresa);
        }

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