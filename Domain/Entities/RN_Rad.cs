using System;

namespace MMS.Domain.Entities
{
    public class RN_Rad
    {
        public int Id { get; set; }
        public int RadniNalogId { get; set; }
        public int TipUslugeId { get; set; }
        public int? IzvrsilacUserId { get; set; }
        public string? Opis { get; set; }
        public string? JM { get; set; }
        public decimal Kolicina { get; set; }
        public decimal? Cena { get; set; }
        public decimal? PopustPct { get; set; }
        public decimal? Iznos { get; set; }
        public DateTime? CreatedAt { get; set; }

        public RadniNalog? RadniNalog { get; set; }
        public TipUsluge? TipUsluge { get; set; }
        public User? IzvrsilacUser { get; set; }
    }
}