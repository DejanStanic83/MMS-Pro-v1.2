using System;
using System.Collections.Generic;

namespace MMS.Domain.Entities
{
    public class Klijent
    {
        public int Id { get; set; }
        public string? NazivKlijenta { get; set; }
        public string? PIB { get; set; }
        public string? MaticniBroj { get; set; }
        public string? Adresa { get; set; }
        public string? Zemlja { get; set; }
        public string? Telefon { get; set; }
        public string? Email { get; set; }
        public string? KontaktOsoba { get; set; }
        public string? Grad { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public byte[]? RowVersion { get; set; }

        public ICollection<Objekat> Objekti { get; set; } = new List<Objekat>();
        public ICollection<Ugovor> Ugovori { get; set; } = new List<Ugovor>();
        public ICollection<Faktura> Fakture { get; set; } = new List<Faktura>();
        public ICollection<Uplata> Uplate { get; set; } = new List<Uplata>();
        public ICollection<KlijentObjekat> KlijentObjekti { get; set; } = new List<KlijentObjekat>();
    }
}