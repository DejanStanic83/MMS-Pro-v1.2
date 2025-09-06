using System;
using System.Collections.Generic;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja status fakture (npr. "Kreirana", "Plaæena", "Stornirana").
    /// Sadrži osnovne podatke o statusu i vezu sa svim fakturama koje imaju ovaj status.
    /// </summary>
    public class FakturaStatus
    {
        /// <summary>
        /// Jedinstveni identifikator statusa fakture.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Šifra statusa (npr. "KRE", "PLAC", "STOR").
        /// </summary>
        public string? Sifra { get; set; }

        /// <summary>
        /// Naziv statusa (npr. "Kreirana", "Plaæena", "Stornirana").
        /// </summary>
        public string? Naziv { get; set; }

        /// <summary>
        /// Redosled prikaza statusa (za sortiranje u interfejsu).
        /// </summary>
        public int Redosled { get; set; }

        /// <summary>
        /// Da li je status aktivan (vidljiv i dostupan za izbor).
        /// </summary>
        public bool Aktivan { get; set; }

        /// <summary>
        /// Datum kreiranja statusa.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Kolekcija svih faktura koje imaju ovaj status.
        /// </summary>
        public ICollection<Faktura> Fakture { get; set; } = new List<Faktura>();
    }
}