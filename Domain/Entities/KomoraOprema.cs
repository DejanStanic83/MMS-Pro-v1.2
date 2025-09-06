using System;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja vezu izme�u komore i opreme.
    /// Modeluje relaciju "vi�e na vi�e" izme�u entiteta Komora i Oprema,
    /// uz dodatne informacije kao �to su serijski broj, datumi ugradnje/demonta�e i napomena.
    /// </summary>
    public class KomoraOprema
    {
        /// <summary>
        /// Jedinstveni identifikator veze.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ID komore (strani klju� ka entitetu Komora).
        /// </summary>
        public int KomoraId { get; set; }

        /// <summary>
        /// ID opreme (strani klju� ka entitetu Oprema).
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
        /// Datum demonta�e opreme iz komore (opciono).
        /// </summary>
        public DateTime? DatumDemontaze { get; set; }

        /// <summary>
        /// Dodatna napomena o vezi izme�u komore i opreme.
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