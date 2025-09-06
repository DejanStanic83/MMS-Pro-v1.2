using System;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja fakturu u sistemu.
    /// Sadrži osnovne podatke o fakturi, iznosima, statusu i vezama sa klijentom i ugovorom.
    /// </summary>
    public class Faktura
    {
        /// <summary>
        /// Jedinstveni identifikator fakture.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Broj fakture (može biti null).
        /// </summary>
        public string? Broj { get; set; }

        /// <summary>
        /// Datum izdavanja fakture.
        /// </summary>
        public DateTime Datum { get; set; }

        /// <summary>
        /// Datum dospeæa fakture (može biti null).
        /// </summary>
        public DateTime? DatumDosp { get; set; }

        /// <summary>
        /// ID statusa fakture (strana kljuè ka FakturaStatus).
        /// </summary>
        public int StatusId { get; set; }

        /// <summary>
        /// ID kupca (strana kljuè ka Klijent).
        /// </summary>
        public int KupacId { get; set; }

        /// <summary>
        /// ID ugovora na koji se faktura odnosi (može biti null).
        /// </summary>
        public int? UgovorId { get; set; }

        /// <summary>
        /// Valuta u kojoj je faktura izdata (npr. "RSD", "EUR").
        /// </summary>
        public string? Valuta { get; set; }

        /// <summary>
        /// Procenat PDV-a (može biti null).
        /// </summary>
        public decimal? PDV_Pct { get; set; }

        /// <summary>
        /// Napomena uz fakturu (može biti null).
        /// </summary>
        public string? Napomena { get; set; }

        /// <summary>
        /// Osnovica za obraèun PDV-a (može biti null).
        /// </summary>
        public decimal? Osnovica { get; set; }

        /// <summary>
        /// Iznos PDV-a (može biti null).
        /// </summary>
        public decimal? PDV_Iznos { get; set; }

        /// <summary>
        /// Ukupan iznos fakture (može biti null).
        /// </summary>
        public decimal? Ukupno { get; set; }

        /// <summary>
        /// Datum kreiranja fakture.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Datum poslednje izmene fakture (može biti null).
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Verzija reda za konkurentni pristup (opciono, koristi se za optimistièko zakljuèavanje).
        /// </summary>
        public byte[]? RowVersion { get; set; }

        /// <summary>
        /// Navigaciono svojstvo ka statusu fakture.
        /// </summary>
        public FakturaStatus? Status { get; set; }

        /// <summary>
        /// Navigaciono svojstvo ka kupcu (klijentu).
        /// </summary>
        public Klijent? Kupac { get; set; }

        /// <summary>
        /// Navigaciono svojstvo ka ugovoru na koji se faktura odnosi.
        /// </summary>
        public Ugovor? Ugovor { get; set; }
    }
}