namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja alokaciju (raspodelu) uplate na odreðenu fakturu.
    /// Omoguæava praæenje koliko je od ukupne uplate dodeljeno kojoj fakturi.
    /// </summary>
    public class UplataAlokacija
    {
        /// <summary>
        /// Jedinstveni identifikator alokacije.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ID uplate koja se alocira (strani kljuè ka entitetu Uplata).
        /// </summary>
        public int UplataId { get; set; }

        /// <summary>
        /// ID fakture na koju se deo uplate odnosi (strani kljuè ka entitetu Faktura).
        /// </summary>
        public int FakturaId { get; set; }

        /// <summary>
        /// Iznos koji je iz ove uplate dodeljen konkretnoj fakturi.
        /// </summary>
        public decimal Iznos { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: uplata iz koje je iznos alociran.
        /// </summary>
        public Uplata? Uplata { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: faktura na koju je iznos alociran.
        /// </summary>
        public Faktura? Faktura { get; set; }
    }
}