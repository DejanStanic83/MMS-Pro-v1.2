using System;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja valutu (npr. "RSD", "EUR", "USD") koja se koristi u sistemu.
    /// Sadrži osnovne podatke o valuti i status aktivnosti.
    /// </summary>
    public class Valuta
    {
        /// <summary>
        /// Šifra valute (npr. "RSD", "EUR", "USD").
        /// </summary>
        public string? Sifra { get; set; }

        /// <summary>
        /// Naziv valute (npr. "Dinar", "Evro", "Amerièki dolar").
        /// </summary>
        public string? Naziv { get; set; }

        /// <summary>
        /// Oznaka da li je valuta aktivna i dostupna za korišæenje.
        /// </summary>
        public bool Aktivan { get; set; }
    }
}