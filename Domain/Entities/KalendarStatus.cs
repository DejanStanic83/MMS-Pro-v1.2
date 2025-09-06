using System;

namespace MMS.Domain.Entities
{
    public class KalendarStatus
    {
        public int Id { get; set; }
        public string? Sifra { get; set; }
        public string? Naziv { get; set; }
        public int Redosled { get; set; }
        public bool Aktivan { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}