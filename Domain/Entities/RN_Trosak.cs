using System;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja tro�ak vezan za radni nalog.
    /// Sadr�i podatke o vrsti tro�ka, opisu, koli�ini, ceni i ukupnom iznosu.
    /// </summary>
    public class RN_Trosak
    {
        /// <summary>
        /// Jedinstveni identifikator tro�ka.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ID radnog naloga kojem tro�ak pripada (strani klju�).
        /// </summary>
        public int RadniNalogId { get; set; }

        /// <summary>
        /// Tip tro�ka (npr. materijal, usluga, gorivo).
        /// </summary>
        public string? TipTroska { get; set; }

        /// <summary>
        /// Opis tro�ka ili dodatna napomena.
        /// </summary>
        public string? Opis { get; set; }

        /// <summary>
        /// Koli�ina tro�ka (npr. broj jedinica, sati).
        /// </summary>
        public decimal Kolicina { get; set; }

        /// <summary>
        /// Jedini�na cena tro�ka (opciono).
        /// </summary>
        public decimal? CenaJedinicna { get; set; }

        /// <summary>
        /// Ukupan iznos tro�ka (opciono).
        /// </summary>
        public decimal? Iznos { get; set; }

        /// <summary>
        /// Datum i vreme kreiranja zapisa o tro�ku.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: radni nalog kojem tro�ak pripada.
        /// </summary>
        public RadniNalog? RadniNalog { get; set; }
    }
}