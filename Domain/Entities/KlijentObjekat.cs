using System;

namespace MMS.Domain.Entities
{
    public class KlijentObjekat
    {
        public int Id { get; set; }
        public int KlijentId { get; set; }
        public int ObjekatId { get; set; }
        public string? Uloga { get; set; }
        public string? Napomena { get; set; }
        public DateTime? CreatedAt { get; set; }

        public Klijent? Klijent { get; set; }
        public Objekat? Objekat { get; set; }
    }
}