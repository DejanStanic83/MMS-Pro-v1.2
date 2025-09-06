using System;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja vezu izmeðu klijenta i objekta.
    /// Koristi se za modeliranje odnosa "više na više" izmeðu klijenata i objekata,
    /// uz dodatne informacije kao što su uloga i napomena.
    /// </summary>
    public class KlijentObjekat
    {
        /// <summary>
        /// Jedinstveni identifikator veze.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ID klijenta (strani kljuè ka entitetu Klijent).
        /// </summary>
        public int KlijentId { get; set; }

        /// <summary>
        /// ID objekta (strani kljuè ka entitetu Objekat).
        /// </summary>
        public int ObjekatId { get; set; }

        /// <summary>
        /// Uloga klijenta u odnosu na objekat (npr. vlasnik, korisnik, zakupac).
        /// </summary>
        public string? Uloga { get; set; }

        /// <summary>
        /// Dodatna napomena o vezi izmeðu klijenta i objekta.
        /// </summary>
        public string? Napomena { get; set; }

        /// <summary>
        /// Datum kreiranja veze (može biti null).
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