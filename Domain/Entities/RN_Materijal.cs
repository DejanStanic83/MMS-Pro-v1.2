using System;

namespace MMS.Domain.Entities
{
    public class RN_Materijal
    {
        public int Id { get; set; }
        public int RadniNalogId { get; set; }
        public int? OpremaId { get; set; }
        public int? FilterId { get; set; }
        public string? Opis { get; set; }
        public decimal Kolicina { get; set; }
        public decimal? Cena { get; set; }
        public decimal? PopustPct { get; set; }
        public string? JM { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal? Iznos { get; set; }

        public RadniNalog? RadniNalog { get; set; }
        public Oprema? Oprema { get; set; }
    }
}