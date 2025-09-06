using System;

namespace MMS.Domain.Entities
{
    public class RadniNalog
    {
        public int Id { get; set; }
        public string? BrojRN { get; set; }
        public DateTime Datum { get; set; }
        public int UgovorId { get; set; }
        public int ObjekatId { get; set; }
        public int? KomoraId { get; set; }
        public int TipUslugeId { get; set; }
        public string? Prioritet { get; set; }
        public string? Status { get; set; }
        public int? CreatedByUserId { get; set; }
        public string? Napomena { get; set; }
        public int? RazlogId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public byte[]? RowVersion { get; set; }

        public Ugovor? Ugovor { get; set; }
        public Objekat? Objekat { get; set; }
        public Komora? Komora { get; set; }
        public TipUsluge? TipUsluge { get; set; }
        public User? CreatedByUser { get; set; }
        public Razlog? Razlog { get; set; }
    }
}