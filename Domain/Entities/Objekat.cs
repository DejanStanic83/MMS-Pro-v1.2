using System;
using System.Collections.Generic;

namespace MMS.Domain.Entities
{
    public class Objekat
    {
        public int Id { get; set; }
        public string? NazivObjekta { get; set; }
        public string? Grad { get; set; }
        public string? Adresa { get; set; }
        public decimal? Lokacija_Longitude { get; set; }
        public decimal? Lokacija_Latitude { get; set; }
        public string? Zemlja { get; set; }
        public DateTime? DatumUnosaObj { get; set; }
        public string? KorisnikUnosaObj { get; set; }
        public string? VlasnikObjekta { get; set; }
        public string? TelefonKOsobe { get; set; }
        public string? EmailObjekta { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public byte[]? RowVersion { get; set; }

        public int KlijentId { get; set; }
        public Klijent? Klijent { get; set; }

        public ICollection<Komora> Komore { get; set; } = new List<Komora>();
        public ICollection<Ugovor> Ugovori { get; set; } = new List<Ugovor>();
        public ICollection<RadniNalog> RadniNalozi { get; set; } = new List<RadniNalog>();
        public ICollection<KlijentObjekat> KlijentObjekti { get; set; } = new List<KlijentObjekat>();
    }
}