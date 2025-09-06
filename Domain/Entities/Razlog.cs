using System;

namespace MMS.Domain.Entities
{
    public class Razlog
    {
        public int Id { get; set; }
        public string? Kategorija { get; set; }
        public string? Sifra { get; set; }
        public string? Naziv { get; set; }
        public bool Aktivan { get; set; }
        public int Redosled { get; set; }
    }
}