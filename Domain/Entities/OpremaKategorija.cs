using System.Collections.Generic;

namespace MMS.Domain.Entities
{
    public class OpremaKategorija
    {
        public int Id { get; set; }
        public string? Naziv { get; set; }
        public bool Aktivan { get; set; }
        public int Redosled { get; set; }
        public ICollection<Oprema> Opreme { get; set; } = new List<Oprema>();
    }
}