using System;

namespace MMS.Domain.Entities
{
    public class TipUsluge
    {
        public int Id { get; set; }
        public string? Sifra { get; set; }
        public string? Naziv { get; set; }
        public string? Opis { get; set; }
        public string? PrioritetPodrazumevani { get; set; }
        public int? RespTimeH { get; set; }
        public int? OnSiteH { get; set; }
        public string? BillModel { get; set; }
        public bool Aktivan { get; set; }
        public int Redosled { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}