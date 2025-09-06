using System;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja kontakt osobu povezanu sa klijentom, firmom ili projektom.
    /// Sadrži osnovne podatke o kontaktu i status aktivnosti.
    /// </summary>
    public class Kontakt
    {
        /// <summary>
        /// Jedinstveni identifikator kontakta.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Ime kontakt osobe.
        /// </summary>
        public string? Ime { get; set; }

        /// <summary>
        /// Prezime kontakt osobe.
        /// </summary>
        public string? Prezime { get; set; }

        /// <summary>
        /// Pozicija ili funkcija kontakt osobe (npr. direktor, referent).
        /// </summary>
        public string? Pozicija { get; set; }

        /// <summary>
        /// Email adresa kontakt osobe.
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Kontakt telefon.
        /// </summary>
        public string? Telefon { get; set; }

        /// <summary>
        /// Dodatna napomena vezana za kontakt osobu.
        /// </summary>
        public string? Napomena { get; set; }

        /// <summary>
        /// Oznaka da li je kontakt aktivan.
        /// </summary>
        public bool Aktivan { get; set; }

        /// <summary>
        /// Datum kreiranja zapisa o kontaktu.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Verzija reda za konkurentni pristup (opciono, koristi se za optimistièko zakljuèavanje).
        /// </summary>
        public byte[]? RowVersion { get; set; }
    }
}