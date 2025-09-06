using System;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja status u kalendaru (npr. status dogaðaja ili aktivnosti).
    /// Sadrži osnovne podatke o statusu i njegovoj upotrebi u sistemu.
    /// </summary>
    public class KalendarStatus
    {
        /// <summary>
        /// Jedinstveni identifikator statusa.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Šifra statusa (npr. "AKT", "NEAKT").
        /// </summary>
        public string? Sifra { get; set; }

        /// <summary>
        /// Naziv statusa (npr. "Aktivan", "Neaktivan").
        /// </summary>
        public string? Naziv { get; set; }

        /// <summary>
        /// Redosled prikaza statusa (za sortiranje u interfejsu).
        /// </summary>
        public int Redosled { get; set; }

        /// <summary>
        /// Da li je status aktivan i dostupan za korišæenje.
        /// </summary>
        public bool Aktivan { get; set; }

        /// <summary>
        /// Datum kreiranja statusa.
        /// </summary>
        public DateTime CreatedAt { get; set; }
    }
}