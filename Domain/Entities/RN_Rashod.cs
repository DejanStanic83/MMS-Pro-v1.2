using System;

namespace MMS.Domain.Entities
{
    public class RN_Rashod
    {
        public int Id { get; set; }
        public int RadniNalogId { get; set; }
        public string? TipRashoda { get; set; }
        public int? OpremaId { get; set; }
        public int? UserId { get; set; }
        public string? JM { get; set; }
        public decimal Kolicina { get; set; }
        public decimal? NabavnaCena { get; set; }
        public decimal? Iznos { get; set; }
        public string? Valuta { get; set; }
        public int? DobavljacId { get; set; }
        public string? BrojDok { get; set; }
        public DateTime? DatumDok { get; set; }
        public string? Opis { get; set; }
        public DateTime DatumRashoda { get; set; }
        public DateTime CreatedAt { get; set; }
        public byte[]? RowVersion { get; set; }

        public RadniNalog? RadniNalog { get; set; }
        public Oprema? Oprema { get; set; }
        public User? User { get; set; }
        public Klijent? Dobavljac { get; set; }
    }
}