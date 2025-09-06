using Xunit;
using MMS.Domain.Entities;
using System;

namespace Domain.Test
{
    /// <summary>
    /// Test klasa za entitet Klijent.
    /// Proverava kreiranje i osnovna svojstva klijenta.
    /// </summary>
    public class KlijentTests
    {
        /// <summary>
        /// Testira da li se Klijent može uspešno kreirati sa validnim podacima
        /// i da li su osnovna svojstva ispravno postavljena.
        /// </summary>
        [Fact]
        public void Klijent_CanBeCreated_WithValidData()
        {
            var klijent = new Klijent
            {
                Id = 1,
                NazivKlijenta = "Firma d.o.o.",
                PIB = "123456789",
                MaticniBroj = "987654321",
                Adresa = "Ulica 1",
                Zemlja = "Srbija",
                Telefon = "011/123-456",
                Email = "kontakt@firma.rs",
                KontaktOsoba = "Petar Petroviæ",
                Grad = "Beograd",
                IsActive = true,
                CreatedAt = DateTime.Now
            };

            Assert.Equal("Firma d.o.o.", klijent.NazivKlijenta);
            Assert.True(klijent.IsActive);
        }
    }
}