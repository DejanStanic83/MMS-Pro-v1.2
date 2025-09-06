namespace MMS.Domain.Entities
{
    public class UplataAlokacija
    {
        public int Id { get; set; }
        public int UplataId { get; set; }
        public int FakturaId { get; set; }
        public decimal Iznos { get; set; }

        public Uplata? Uplata { get; set; }
        public Faktura? Faktura { get; set; }
    }
}