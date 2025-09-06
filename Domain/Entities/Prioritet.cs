using System;

namespace MMS.Domain.Entities
{
    public class Prioritet
    {
        public int Id { get; set; }
        public string? Sifra { get; set; }
        public string? Naziv { get; set; }
        public int? Rang { get; set; }
        public bool Aktivan { get; set; }
        public DateTime CreatedAt { get; set; }
        public byte[]? RowVersion { get; set; }
    }
}