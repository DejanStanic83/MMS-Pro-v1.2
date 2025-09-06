using System;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja ulogu kontakt osobe (npr. direktor, referent, tehni�ka podr�ka).
    /// Sadr�i osnovne podatke o ulozi, status aktivnosti i redosled prikaza.
    /// </summary>
    public class KontaktUloga
    {
        /// <summary>
        /// Jedinstveni identifikator uloge.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// �ifra uloge (npr. "DIR", "REF", "TEH").
        /// </summary>
        public string? Sifra { get; set; }

        /// <summary>
        /// Naziv uloge (npr. "Direktor", "Referent", "Tehni�ka podr�ka").
        /// </summary>
        public string? Naziv { get; set; }

        /// <summary>
        /// Oznaka da li je uloga aktivna i dostupna za izbor.
        /// </summary>
        public bool Aktivan { get; set; }

        /// <summary>
        /// Redosled prikaza uloga (za sortiranje u interfejsu).
        /// </summary>
        public int Redosled { get; set; }
    }
}