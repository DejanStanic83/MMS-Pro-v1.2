using System;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja trošak vezan za radni nalog.
    /// Sadrži podatke o vrsti troška, opisu, kolièini, ceni i ukupnom iznosu.
    /// </summary>
    public class RN_Trosak
    {
        /// <summary>
        /// Jedinstveni identifikator troška.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ID radnog naloga kojem trošak pripada (strani kljuè).
        /// </summary>
        public int RadniNalogId { get; set; }

        /// <summary>
        /// Tip troška (npr. materijal, usluga, gorivo).
        /// </summary>
        public string? TipTroska { get; set; }

        /// <summary>
        /// Opis troška ili dodatna napomena.
        /// </summary>
        public string? Opis { get; set; }

        /// <summary>
        /// Kolièina troška (npr. broj jedinica, sati).
        /// </summary>
        public decimal Kolicina { get; set; }

        /// <summary>
        /// Jedinièna cena troška (opciono).
        /// </summary>
        public decimal? CenaJedinicna { get; set; }

        /// <summary>
        /// Ukupan iznos troška (opciono).
        /// </summary>
        public decimal? Iznos { get; set; }

        /// <summary>
        /// Datum i vreme kreiranja zapisa o trošku.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: radni nalog kojem trošak pripada.
        /// </summary>
        public RadniNalog? RadniNalog { get; set; }
    }
}