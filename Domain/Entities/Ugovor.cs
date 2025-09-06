using System;
using System.Collections.Generic;

namespace MMS.Domain.Entities
{
    public class Ugovor
    {
        public int Id { get; set; }
        public string? BrojUgovora { get; set; }
        public int KlijentId { get; set; }
        public int? ObjekatId { get; set; }
        public DateTime Pocetak { get; set; }
        public DateTime? Kraj { get; set; }
        public bool AutomatskoObnavljanje { get; set; }
        public string? SLA_Nivo { get; set; }
        public TimeSpan? RadniDaniOd { get; set; }
        public TimeSpan? RadniDaniDo { get; set; }
        public bool Dostupnost24x7 { get; set; }
        public string? ModelObracuna { get; set; }
        public decimal? MesecniLimitSati { get; set; }
        public decimal? CenaPausala { get; set; }
        public decimal? Satnica_Serviser { get; set; }
        public decimal? Satnica_Inzenjer { get; set; }
        public decimal? PopustMaterijal { get; set; }
        public string? KontaktOperativa { get; set; }
        public string? KontaktFinansije { get; set; }
        public string? Status { get; set; }
        public string? Napomena { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public byte[]? RowVersion { get; set; }

        public Klijent? Klijent { get; set; }
        public Objekat? Objekat { get; set; }
        public ICollection<RadniNalog> RadniNalozi { get; set; } = new List<RadniNalog>();
        public ICollection<Faktura> Fakture { get; set; } = new List<Faktura>();
    }
}