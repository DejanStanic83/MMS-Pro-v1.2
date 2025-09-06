using System.Collections.Generic;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja kategoriju opreme (npr. elektrièna, mehanièka, potrošni materijal).
    /// Sadrži osnovne podatke o kategoriji i vezu sa opremom koja joj pripada.
    /// </summary>
    public class OpremaKategorija
    {
        /// <summary>
        /// Jedinstveni identifikator kategorije opreme.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Naziv kategorije opreme.
        /// </summary>
        public string? Naziv { get; set; }

        /// <summary>
        /// Oznaka da li je kategorija aktivna i dostupna za korišæenje.
        /// </summary>
        public bool Aktivan { get; set; }

        /// <summary>
        /// Redosled prikaza kategorije (za sortiranje u interfejsu).
        /// </summary>
        public int Redosled { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: kolekcija opreme koja pripada ovoj kategoriji.
        /// </summary>
        public ICollection<Oprema> Opreme { get; set; } = new List<Oprema>();
    }
}