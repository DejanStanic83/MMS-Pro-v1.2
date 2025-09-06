using System;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja SLA (Service Level Agreement) parametre vezane za radni nalog.
    /// Sadr�i podatke o tipu usluge, prioritetu, vremenskim rokovima, modelu naplate i porezu.
    /// </summary>
    public class RN_SLA
    {
        /// <summary>
        /// Jedinstveni identifikator SLA zapisa.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ID radnog naloga na koji se SLA odnosi (strani klju�).
        /// </summary>
        public int RadniNalogId { get; set; }

        /// <summary>
        /// ID tipa usluge (opciono, strani klju�).
        /// </summary>
        public int? TipUslugeId { get; set; }

        /// <summary>
        /// ID prioriteta (opciono, strani klju�).
        /// </summary>
        public int? PrioritetId { get; set; }

        /// <summary>
        /// Vreme odgovora u satima (opciono).
        /// </summary>
        public int? RespTimeH { get; set; }

        /// <summary>
        /// Vreme dolaska na lokaciju u satima (opciono).
        /// </summary>
        public int? OnSiteH { get; set; }

        /// <summary>
        /// Model naplate (npr. "po satu", "pau�alno", opcionalno).
        /// </summary>
        public string? BillModel { get; set; }

        /// <summary>
        /// Valuta u kojoj se vr�i naplata (npr. "RSD", "EUR", opcionalno).
        /// </summary>
        public string? Valuta { get; set; }

        /// <summary>
        /// Procenat PDV-a (opciono).
        /// </summary>
        public decimal? PDV_Pct { get; set; }

        /// <summary>
        /// Datum i vreme kreiranja SLA zapisa.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Verzija reda za konkurentni pristup (opciono, koristi se za optimisti�ko zaklju�avanje).
        /// </summary>
        public byte[]? RowVersion { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: radni nalog na koji se SLA odnosi.
        /// </summary>
        public RadniNalog? RadniNalog { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: tip usluge na koji se SLA odnosi.
        /// </summary>
        public TipUsluge? TipUsluge { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: prioritet SLA.
        /// </summary>
        public Prioritet? Prioritet { get; set; }
    }
}