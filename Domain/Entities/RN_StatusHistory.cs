using System;

namespace MMS.Domain.Entities
{
    public class RN_StatusHistory
    {
        public int Id { get; set; }
        public int RadniNalogId { get; set; }
        public string? StariStatus { get; set; }
        public string? NoviStatus { get; set; }
        public string? Napomena { get; set; }
        public int? ChangedByUserId { get; set; }
        public DateTime ChangedAt { get; set; }

        public RadniNalog? RadniNalog { get; set; }
        public User? ChangedByUser { get; set; }
    }
}