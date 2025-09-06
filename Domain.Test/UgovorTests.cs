using Xunit;
using MMS.Domain.Entities;
using System;

namespace Domain.Test
{
    /// <summary>
    /// Test klasa za entitet Ugovor.
    /// Proverava kreiranje ugovora i osnovna svojstva.
    /// </summary>
    public class UgovorTests
    {
        /// <summary>
        /// Testira da li se Ugovor može uspešno kreirati sa validnim podacima
        /// i da li su osnovna svojstva ispravno postavljena.
        /// </summary>
        [Fact]
        public void Ugovor_CanBeCreated_WithValidData()
        {
            var ugovor = new Ugovor
            {
                Id = 1,
                BrojUgovora = "UG-2024-001",
                KlijentId = 2,
                Pocetak = new DateTime(2024, 1, 1),
                AutomatskoObnavljanje = true,
                Status = "Aktivan",
                CreatedAt = DateTime.Now
            };

            Assert.Equal("UG-2024-001", ugovor.BrojUgovora);
            Assert.True(ugovor.AutomatskoObnavljanje);
            Assert.Equal("Aktivan", ugovor.Status);
        }
    }
}