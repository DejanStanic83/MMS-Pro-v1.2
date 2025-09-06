using System;

namespace MMS.Domain.Entities
{
    public class JedinicaMere
    {
        public int Id { get; set; }
        public string? Sifra { get; set; }
        public string? Naziv { get; set; }
        public bool Aktivan { get; set; }
    }
}