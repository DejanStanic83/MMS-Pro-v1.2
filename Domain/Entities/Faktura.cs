using System;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja fakturu u sistemu.
    /// Sadr�i osnovne podatke o fakturi, iznosima, statusu i vezama sa klijentom i ugovorom.
    /// </summary>
    public class Faktura
    {
        /// <summary>
        /// Jedinstveni identifikator fakture.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Broj fakture (mo�e biti null).
        /// </summary>
        public string? Broj { get; set; }

        /// <summary>
        /// Datum izdavanja fakture.
        /// </summary>
        public DateTime Datum { get; set; }

        /// <summary>
        /// Datum dospe�a fakture (mo�e biti null).
        /// </summary>
        public DateTime? DatumDosp { get; set; }

        /// <summary>
        /// ID statusa fakture (strana klju� ka FakturaStatus).
        /// </summary>
        public int StatusId { get; set; }

        /// <summary>
        /// ID kupca (strana klju� ka Klijent).
        /// </summary>
        public int KupacId { get; set; }

        /// <summary>
        /// ID ugovora na koji se faktura odnosi (mo�e biti null).
        /// </summary>
        public int? UgovorId { get; set; }

        /// <summary>
        /// Valuta u kojoj je faktura izdata (npr. "RSD", "EUR").
        /// </summary>
        public string? Valuta { get; set; }

        /// <summary>
        /// Procenat PDV-a (mo�e biti null).
        /// </summary>
        public decimal? PDV_Pct { get; set; }

        /// <summary>
        /// Napomena uz fakturu (mo�e biti null).
        /// </summary>
        public string? Napomena { get; set; }

        /// <summary>
        /// Osnovica za obra�un PDV-a (mo�e biti null).
        /// </summary>
        public decimal? Osnovica { get; set; }

        /// <summary>
        /// Iznos PDV-a (mo�e biti null).
        /// </summary>
        public decimal? PDV_Iznos { get; set; }

        /// <summary>
        /// Ukupan iznos fakture (mo�e biti null).
        /// </summary>
        public decimal? Ukupno { get; set; }

        /// <summary>
        /// Datum kreiranja fakture.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Datum poslednje izmene fakture (mo�e biti null).
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Verzija reda za konkurentni pristup (opciono, koristi se za optimisti�ko zaklju�avanje).
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