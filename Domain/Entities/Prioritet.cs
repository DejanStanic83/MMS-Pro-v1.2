using System;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja prioritet (npr. za zadatke, naloge ili zahteve) u sistemu.
    /// Sadr�i osnovne podatke o prioritetu, rangiranju i statusu aktivnosti.
    /// </summary>
    public class Prioritet
    {
        /// <summary>
        /// Jedinstveni identifikator prioriteta.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// �ifra prioriteta (npr. "VISOK", "NIZAK").
        /// </summary>
        public string? Sifra { get; set; }

        /// <summary>
        /// Naziv prioriteta (npr. "Visok", "Nizak", "Srednji").
        /// </summary>
        public string? Naziv { get; set; }

        /// <summary>
        /// Rang prioriteta (manja vrednost zna�i ve�i prioritet; opcionalno).
        /// </summary>
        public int? Rang { get; set; }

        /// <summary>
        /// Oznaka da li je prioritet aktivan i dostupan za kori��enje.
        /// </summary>
        public bool Aktivan { get; set; }

        /// <summary>
        /// Datum kreiranja prioriteta.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Verzija reda za konkurentni pristup (opciono, koristi se za optimisti�ko zaklju�avanje).
        /// </summary>
        public byte[]? RowVersion { get; set; }
    }
}