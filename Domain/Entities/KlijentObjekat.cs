using System;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja vezu izme�u klijenta i objekta.
    /// Koristi se za modeliranje odnosa "vi�e na vi�e" izme�u klijenata i objekata,
    /// uz dodatne informacije kao �to su uloga i napomena.
    /// </summary>
    public class KlijentObjekat
    {
        /// <summary>
        /// Jedinstveni identifikator veze.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ID klijenta (strani klju� ka entitetu Klijent).
        /// </summary>
        public int KlijentId { get; set; }

        /// <summary>
        /// ID objekta (strani klju� ka entitetu Objekat).
        /// </summary>
        public int ObjekatId { get; set; }

        /// <summary>
        /// Uloga klijenta u odnosu na objekat (npr. vlasnik, korisnik, zakupac).
        /// </summary>
        public string? Uloga { get; set; }

        /// <summary>
        /// Dodatna napomena o vezi izme�u klijenta i objekta.
        /// </summary>
        public string? Napomena { get; set; }

        /// <summary>
        /// Datum kreiranja veze (mo�e biti null).
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Navigaciono svojstvo ka entitetu Klijent.
        /// </summary>
        public Klijent? Klijent { get; set; }

        /// <summary>
        /// Navigaciono svojstvo ka entitetu Objekat.
        /// </summary>
        public Objekat? Objekat { get; set; }
    }
}