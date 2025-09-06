using System;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja jedinicu mere (npr. "kg", "kom", "l") koja se koristi za artikle ili usluge u sistemu.
    /// </summary>
    public class JedinicaMere
    {
        /// <summary>
        /// Jedinstveni identifikator jedinice mere.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Šifra jedinice mere (npr. "KG", "KOM", "L").
        /// </summary>
        public string? Sifra { get; set; }

        /// <summary>
        /// Naziv jedinice mere (npr. "kilogram", "komad", "litar").
        /// </summary>
        public string? Naziv { get; set; }

        /// <summary>
        /// Oznaka da li je jedinica mere aktivna i dostupna za korišæenje.
        /// </summary>
        public bool Aktivan { get; set; }
    }
}