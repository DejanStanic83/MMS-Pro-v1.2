using System;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja rad (uslugu ili aktivnost) koji je deo radnog naloga.
    /// Sadrži podatke o vrsti usluge, izvršiocu, kolièini, ceni i vezu sa radnim nalogom.
    /// </summary>
    public class RN_Rad
    {
        /// <summary>
        /// Jedinstveni identifikator rada.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ID radnog naloga kojem rad pripada (strani kljuè).
        /// </summary>
        public int RadniNalogId { get; set; }

        /// <summary>
        /// ID tipa usluge koja je izvršena (strani kljuè).
        /// </summary>
        public int TipUslugeId { get; set; }

        /// <summary>
        /// ID korisnika koji je izvršio rad (opciono, strani kljuè).
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
        /// Kolièina izvršenog rada ili usluge.
        /// </summary>
        public decimal Kolicina { get; set; }

        /// <summary>
        /// Jedinièna cena rada ili usluge (opciono).
        /// </summary>
        public decimal? Cena { get; set; }

        /// <summary>
        /// Popust u procentima (opciono).
        /// </summary>
        public decimal? PopustPct { get; set; }

        /// <summary>
        /// Ukupan iznos za ovaj rad (opciono, može biti izraèunat: Kolicina * Cena - Popust).
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
        /// Navigaciono svojstvo: tip usluge koja je izvršena.
        /// </summary>
        public TipUsluge? TipUsluge { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: korisnik koji je izvršio rad.
        /// </summary>
        public User? IzvrsilacUser { get; set; }
    }
}