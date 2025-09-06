using System;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja rad (uslugu ili aktivnost) koji je deo radnog naloga.
    /// Sadr�i podatke o vrsti usluge, izvr�iocu, koli�ini, ceni i vezu sa radnim nalogom.
    /// </summary>
    public class RN_Rad
    {
        /// <summary>
        /// Jedinstveni identifikator rada.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ID radnog naloga kojem rad pripada (strani klju�).
        /// </summary>
        public int RadniNalogId { get; set; }

        /// <summary>
        /// ID tipa usluge koja je izvr�ena (strani klju�).
        /// </summary>
        public int TipUslugeId { get; set; }

        /// <summary>
        /// ID korisnika koji je izvr�io rad (opciono, strani klju�).
        /// </summary>
        public int? IzvrsilacUserId { get; set; }

        /// <summary>
        /// Opis rada ili usluge.
        /// </summary>
        public string? Opis { get; set; }

        /// <summary>
        /// Jedinica mere (npr. "sat", "kom", "m").
        /// </summary>
        public string? JM { get; set; }

        /// <summary>
        /// Koli�ina izvr�enog rada ili usluge.
        /// </summary>
        public decimal Kolicina { get; set; }

        /// <summary>
        /// Jedini�na cena rada ili usluge (opciono).
        /// </summary>
        public decimal? Cena { get; set; }

        /// <summary>
        /// Popust u procentima (opciono).
        /// </summary>
        public decimal? PopustPct { get; set; }

        /// <summary>
        /// Ukupan iznos za ovaj rad (opciono, mo�e biti izra�unat: Kolicina * Cena - Popust).
        /// </summary>
        public decimal? Iznos { get; set; }

        /// <summary>
        /// Datum i vreme kada je rad dodat u radni nalog (opciono).
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: radni nalog kojem rad pripada.
        /// </summary>
        public RadniNalog? RadniNalog { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: tip usluge koja je izvr�ena.
        /// </summary>
        public TipUsluge? TipUsluge { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: korisnik koji je izvr�io rad.
        /// </summary>
        public User? IzvrsilacUser { get; set; }
    }
}