using System;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja vezu izmeðu komore i opreme.
    /// Modeluje relaciju "više na više" izmeðu entiteta Komora i Oprema,
    /// uz dodatne informacije kao što su serijski broj, datumi ugradnje/demontaže i napomena.
    /// </summary>
    public class KomoraOprema
    {
        /// <summary>
        /// Jedinstveni identifikator veze.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ID komore (strani kljuè ka entitetu Komora).
        /// </summary>
        public int KomoraId { get; set; }

        /// <summary>
        /// ID opreme (strani kljuè ka entitetu Oprema).
        /// </summary>
        public int OpremaId { get; set; }

        /// <summary>
        /// Serijski broj opreme u okviru ove veze (opciono).
        /// </summary>
        public string? SerijskiBroj { get; set; }

        /// <summary>
        /// Datum ugradnje opreme u komoru (opciono).
        /// </summary>
        public DateTime? DatumUgradnje { get; set; }

        /// <summary>
        /// Datum demontaže opreme iz komore (opciono).
        /// </summary>
        public DateTime? DatumDemontaze { get; set; }

        /// <summary>
        /// Dodatna napomena o vezi izmeðu komore i opreme.
        /// </summary>
        public string? Napomena { get; set; }

        /// <summary>
        /// Datum kreiranja veze (opciono).
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Navigaciono svojstvo ka entitetu Komora.
        /// </summary>
        public Komora? Komora { get; set; }

        /// <summary>
        /// Navigaciono svojstvo ka entitetu Oprema.
        /// </summary>
        public Oprema? Oprema { get; set; }
    }
}