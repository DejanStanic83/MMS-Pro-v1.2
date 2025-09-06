using System;

namespace MMS.Domain.Entities
{
    public class RN_Trosak
    {
        public int Id { get; set; }
        public int RadniNalogId { get; set; }
        public string? TipTroska { get; set; }
        public string? Opis { get; set; }
        public decimal Kolicina { get; set; }
        public decimal? CenaJedinicna { get; set; }
        public decimal? Iznos { get; set; }
        public DateTime CreatedAt { get; set; }

        public RadniNalog? RadniNalog { get; set; }
    }
}