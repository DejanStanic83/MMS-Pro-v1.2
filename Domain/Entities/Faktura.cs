using System;

namespace MMS.Domain.Entities
{
    public class Faktura
    {
        public int Id { get; set; }
        public string? Broj { get; set; }
        public DateTime Datum { get; set; }
        public DateTime? DatumDosp { get; set; }
        public int StatusId { get; set; }
        public int KupacId { get; set; }
        public int? UgovorId { get; set; }
        public string? Valuta { get; set; }
        public decimal? PDV_Pct { get; set; }
        public string? Napomena { get; set; }
        public decimal? Osnovica { get; set; }
        public decimal? PDV_Iznos { get; set; }
        public decimal? Ukupno { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public byte[]? RowVersion { get; set; }

        public FakturaStatus? Status { get; set; }
        public Klijent? Kupac { get; set; }
        public Ugovor? Ugovor { get; set; }
    }
}