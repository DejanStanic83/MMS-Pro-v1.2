using System;
using System.Collections.Generic;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja klijenta (kupca) u sistemu.
    /// Sadrži osnovne podatke o klijentu i veze sa povezanim entitetima (objekti, ugovori, fakture, uplate).
    /// </summary>
    public class Klijent
    {
        /// <summary>
        /// Jedinstveni identifikator klijenta.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Naziv klijenta (firma ili fizièko lice).
        /// </summary>
        public string? NazivKlijenta { get; set; }

        /// <summary>
        /// PIB (poreski identifikacioni broj) klijenta.
        /// </summary>
        public string? PIB { get; set; }

        /// <summary>
        /// Matièni broj klijenta.
        /// </summary>
        public string? MaticniBroj { get; set; }

        /// <summary>
        /// Adresa klijenta.
        /// </summary>
        public string? Adresa { get; set; }

        /// <summary>
        /// Zemlja klijenta.
        /// </summary>
        public string? Zemlja { get; set; }

        /// <summary>
        /// Kontakt telefon klijenta.
        /// </summary>
        public string? Telefon { get; set; }

        /// <summary>
        /// Email adresa klijenta.
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Kontakt osoba kod klijenta.
        /// </summary>
        public string? KontaktOsoba { get; set; }

        /// <summary>
        /// Grad u kome se nalazi klijent.
        /// </summary>
        public string? Grad { get; set; }

        /// <summary>
        /// Oznaka da li je klijent aktivan.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Datum kreiranja klijenta.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Datum poslednje izmene podataka o klijentu (može biti null).
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Verzija reda za konkurentni pristup (opciono, koristi se za optimistièko zakljuèavanje).
        /// </summary>
        public byte[]? RowVersion { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: lista objekata koji pripadaju klijentu.
        /// </summary>
        public ICollection<Objekat> Objekti { get; set; } = new List<Objekat>();

        /// <summary>
        /// Navigaciono svojstvo: lista ugovora koje klijent ima.
        /// </summary>
        public ICollection<Ugovor> Ugovori { get; set; } = new List<Ugovor>();

        /// <summary>
        /// Navigaciono svojstvo: lista faktura izdatih klijentu.
        /// </summary>
        public ICollection<Faktura> Fakture { get; set; } = new List<Faktura>();

        /// <summary>
        /// Navigaciono svojstvo: lista uplata koje je klijent izvršio.
        /// </summary>
        public ICollection<Uplata> Uplate { get; set; } = new List<Uplata>();

        /// <summary>
        /// Navigaciono svojstvo: veza sa tabelom KlijentObjekat (npr. za više-veze izmeðu klijenata i objekata).
        /// </summary>
        public ICollection<KlijentObjekat> KlijentObjekti { get; set; } = new List<KlijentObjekat>();
    }
}