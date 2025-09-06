using System;
using System.Collections.Generic;

namespace MMS.Domain.Entities
{
    public class Uplata
    {
        public int Id { get; set; }
        public int KupacId { get; set; }
        public DateTime Datum { get; set; }
        public decimal Iznos { get; set; }
        public string? Valuta { get; set; }
        public string? Nacin { get; set; }
        public string? PozivNaBroj { get; set; }
        public string? Napomena { get; set; }
        public DateTime CreatedAt { get; set; }

        public Klijent? Kupac { get; set; }
        public ICollection<UplataAlokacija> Alokacije { get; set; } = new List<UplataAlokacija>();
    }
}