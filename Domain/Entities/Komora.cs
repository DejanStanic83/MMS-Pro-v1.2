using System;
using System.Collections.Generic;

namespace MMS.Domain.Entities
{
    public class Komora
    {
        public int Id { get; set; }
        public string? IdentKK { get; set; }
        public string? NazivKK { get; set; }
        public string? TipKK { get; set; }
        public int? KolicinaKK { get; set; }
        public string? DimenzijaKK { get; set; }
        public string? ProtokEx { get; set; }
        public string? ProtokSU { get; set; }
        public string? SastavEX { get; set; }
        public string? SastavSu { get; set; }
        public string? SirinaKK { get; set; }
        public string? VisinaKK { get; set; }
        public string? DuzinaKK { get; set; }
        public string? TezinaKK { get; set; }
        public string? GrupaKK { get; set; }
        public decimal? NetoCenaKK { get; set; }
        public decimal? CenaRadaKK { get; set; }
        public string? StatusKK { get; set; }
        public string? KorisnikUnosaKK { get; set; }
        public string? AutomatikaKK { get; set; }
        public string? ClaudKK { get; set; }
        public DateTime? DatumUnosaKK { get; set; }
        public int? ObjekatId { get; set; }
        public DateTime? DatumIsporukeKK { get; set; }
        public DateTime? DatumPustanjaKK { get; set; }
        public string? ImeAutomaticara { get; set; }
        public string? SeriskiBrojKK { get; set; }
        public string? NapomenaKK { get; set; }
        public string? OznakaSistemaKK { get; set; }
        public string? FilteriJson { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public byte[]? RowVersion { get; set; }

        public Objekat? Objekat { get; set; }
        public ICollection<Oprema> Oprema { get; set; } = new List<Oprema>();
        public ICollection<RadniNalog> RadniNalozi { get; set; } = new List<RadniNalog>();
        public ICollection<KomoraOprema> KomoraOpreme { get; set; } = new List<KomoraOprema>();
    }
}