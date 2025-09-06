using System;
using System.Collections.Generic;

namespace MMS.Domain.Entities
{
    public class FakturaStatus
    {
        public int Id { get; set; }
        public string? Sifra { get; set; }
        public string? Naziv { get; set; }
        public int Redosled { get; set; }
        public bool Aktivan { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<Faktura> Fakture { get; set; } = new List<Faktura>();
    }
}