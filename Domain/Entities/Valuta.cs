using System;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja valutu (npr. "RSD", "EUR", "USD") koja se koristi u sistemu.
    /// Sadr�i osnovne podatke o valuti i status aktivnosti.
    /// </summary>
    public class Valuta
    {
        /// <summary>
        /// �ifra valute (npr. "RSD", "EUR", "USD").
        /// </summary>
        public string? Sifra { get; set; }

        /// <summary>
        /// Naziv valute (npr. "Dinar", "Evro", "Ameri�ki dolar").
        /// </summary>
        public string? Naziv { get; set; }

        /// <summary>
        /// Oznaka da li je valuta aktivna i dostupna za kori��enje.
        /// </summary>
        public bool Aktivan { get; set; }
    }
}