using System;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja materijal ili opremu koja je kori��ena u okviru radnog naloga.
    /// Sadr�i podatke o koli�ini, ceni, popustu, jedinici mere i vezu sa radnim nalogom i opremom.
    /// </summary>
    public class RN_Materijal
    {
        /// <summary>
        /// Jedinstveni identifikator materijala u radnom nalogu.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ID radnog naloga kojem materijal pripada (strani klju�).
        /// </summary>
        public int RadniNalogId { get; set; }

        /// <summary>
        /// ID opreme koja je kori��ena (opciono, strani klju�).
        /// </summary>
        public int? OpremaId { get; set; }

        /// <summary>
        /// ID filtera (opciono, koristi se ako je materijal filter).
        /// </summary>
        public int? FilterId { get; set; }

        /// <summary>
        /// Opis materijala ili opreme.
        /// </summary>
        public string? Opis { get; set; }

        /// <summary>
        /// Koli�ina materijala ili opreme koja je kori��ena.
        /// </summary>
        public decimal Kolicina { get; set; }

        /// <summary>
        /// Jedini�na cena materijala ili opreme (opciono).
        /// </summary>
        public decimal? Cena { get; set; }

        /// <summary>
        /// Popust u procentima (opciono).
        /// </summary>
        public decimal? PopustPct { get; set; }

        /// <summary>
        /// Jedinica mere (npr. "kom", "m", "kg").
        /// </summary>
        public string? JM { get; set; }

        /// <summary>
        /// Datum i vreme kada je materijal dodat u radni nalog.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Ukupan iznos za ovaj materijal (opciono, mo�e biti izra�unat: Kolicina * Cena - Popust).
        /// </summary>
        public decimal? Iznos { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: radni nalog kojem materijal pripada.
        /// </summary>
        public RadniNalog? RadniNalog { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: oprema koja je kori��ena.
        /// </summary>
        public Oprema? Oprema { get; set; }
    }
}