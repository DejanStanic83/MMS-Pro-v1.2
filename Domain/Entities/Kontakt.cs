using System;

namespace MMS.Domain.Entities
{
    public class Kontakt
    {
        public int Id { get; set; }
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public string? Pozicija { get; set; }
        public string? Email { get; set; }
        public string? Telefon { get; set; }
        public string? Napomena { get; set; }
        public bool Aktivan { get; set; }
        public DateTime CreatedAt { get; set; }
        public byte[]? RowVersion { get; set; }
    }
}