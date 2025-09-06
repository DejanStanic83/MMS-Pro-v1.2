using System;

namespace MMS.Domain.Entities
{
    public class KomoraOprema
    {
        public int Id { get; set; }
        public int KomoraId { get; set; }
        public int OpremaId { get; set; }
        public string? SerijskiBroj { get; set; }
        public DateTime? DatumUgradnje { get; set; }
        public DateTime? DatumDemontaze { get; set; }
        public string? Napomena { get; set; }
        public DateTime? CreatedAt { get; set; }

        public Komora? Komora { get; set; }
        public Oprema? Oprema { get; set; }
    }
}