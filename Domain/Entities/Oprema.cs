using System;
using System.Collections.Generic;

namespace MMS.Domain.Entities
{
    public class Oprema
    {
        public int Id { get; set; }
        public string? Sifra { get; set; }
        public string? Naziv { get; set; }
        public int? KategorijaId { get; set; }
        public string? Proizvodjac { get; set; }
        public string? Model { get; set; }
        public string? JM_Default { get; set; }
        public string? SpecJson { get; set; }
        public bool Aktivan { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public byte[]? RowVersion { get; set; }
        public bool IsConsumable { get; set; }

        public OpremaKategorija? Kategorija { get; set; }
        public ICollection<KomoraOprema> KomoraOpreme { get; set; } = new List<KomoraOprema>();
    }
}