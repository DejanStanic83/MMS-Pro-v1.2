using System;

namespace MMS.Domain.Entities
{
    public class RN_SLA
    {
        public int Id { get; set; }
        public int RadniNalogId { get; set; }
        public int? TipUslugeId { get; set; }
        public int? PrioritetId { get; set; }
        public int? RespTimeH { get; set; }
        public int? OnSiteH { get; set; }
        public string? BillModel { get; set; }
        public string? Valuta { get; set; }
        public decimal? PDV_Pct { get; set; }
        public DateTime CreatedAt { get; set; }
        public byte[]? RowVersion { get; set; }

        public RadniNalog? RadniNalog { get; set; }
        public TipUsluge? TipUsluge { get; set; }
        public Prioritet? Prioritet { get; set; }
    }
}