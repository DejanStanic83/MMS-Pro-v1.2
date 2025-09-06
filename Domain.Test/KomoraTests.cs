using Xunit;
using MMS.Domain.Entities;
using System;

namespace Domain.Test
{
    public class KomoraTests
    {
        [Fact]
        public void Komora_CanBeCreated_WithValidData()
        {
            var komora = new Komora
            {
                Id = 1,
                IdentKK = "K-001",
                NazivKK = "Komora 1",
                TipKK = "Tip A",
                IsActive = true,
                CreatedAt = DateTime.Now
            };

            Assert.Equal("K-001", komora.IdentKK);
            Assert.True(komora.IsActive);
        }
    }
}