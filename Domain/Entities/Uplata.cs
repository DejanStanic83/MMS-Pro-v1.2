using System;
using System.Collections.Generic;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja uplatu (priliv novca) od strane klijenta.
    /// Sadrži osnovne podatke o uplati, vezu sa klijentom i alokacije prema fakturama.
    /// </summary>
    public class Uplata
    {
        /// <summary>
        /// Jedinstveni identifikator uplate.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ID kupca (klijenta) koji je izvršio uplatu (strani kljuè).
        /// </summary>
        public int KupacId { get; set; }

        /// <summary>
        /// Datum kada je uplata evidentirana.
        /// </summary>
        public DateTime Datum { get; set; }

        /// <summary>
        /// Iznos uplate.
        /// </summary>
        public decimal Iznos { get; set; }

        /// <summary>
        /// Valuta u kojoj je izvršena uplata (npr. "RSD", "EUR").
        /// </summary>
        public string? Valuta { get; set; }

        /// <summary>
        /// Naèin uplate (npr. "gotovina", "virman", "kartica").
        /// </summary>
        public string? Nacin { get; set; }

        /// <summary>
        /// Poziv na broj (referenca za uplatu, može biti null).
        /// </summary>
        public string? PozivNaBroj { get; set; }

        /// <summary>
        /// Dodatna napomena uz uplatu (opciono).
        /// </summary>
        public string? Napomena { get; set; }

        /// <summary>
        /// Datum i vreme kreiranja zapisa o uplati.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: klijent koji je izvršio uplatu.
        /// </summary>
        public Klijent? Kupac { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: alokacije uplate prema fakturama.
        /// </summary>
        public ICollection<UplataAlokacija> Alokacije { get; set; } = new List<UplataAlokacija>();
    }
}