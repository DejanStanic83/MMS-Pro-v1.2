using System;

namespace MMS.Domain.Entities
{
    public class Reklamacija
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public int? UgovorId { get; set; }
        public int? RadniNalogId { get; set; }
        public int? KomoraId { get; set; }
        public int? OpremaId { get; set; }
        public string? OpisKvara { get; set; }
        public string? Status { get; set; }
        public int? RazlogId { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime CreatedAt { get; set; }

        public Ugovor? Ugovor { get; set; }
        public RadniNalog? RadniNalog { get; set; }
        public Komora? Komora { get; set; }
        public Oprema? Oprema { get; set; }
        public Razlog? Razlog { get; set; }
        public User? CreatedByUser { get; set; }
    }
}