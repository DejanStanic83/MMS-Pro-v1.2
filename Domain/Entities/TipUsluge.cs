using System;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja tip usluge u sistemu (npr. servis, održavanje, instalacija).
    /// Sadrži osnovne podatke o usluzi, prioritete, rokove i model naplate.
    /// </summary>
    public class TipUsluge
    {
        /// <summary>
        /// Jedinstveni identifikator tipa usluge.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Šifra tipa usluge (npr. "SRV", "ODR", "INS").
        /// </summary>
        public string? Sifra { get; set; }

        /// <summary>
        /// Naziv tipa usluge (npr. "Servis", "Održavanje", "Instalacija").
        /// </summary>
        public string? Naziv { get; set; }

        /// <summary>
        /// Opis tipa usluge (detaljnije informacije).
        /// </summary>
        public string? Opis { get; set; }

        /// <summary>
        /// Podrazumevani prioritet za ovaj tip usluge (tekstualno).
        /// </summary>
        public string? PrioritetPodrazumevani { get; set; }

        /// <summary>
        /// Podrazumevano vreme odgovora u satima (opciono).
        /// </summary>
        public int? RespTimeH { get; set; }

        /// <summary>
        /// Podrazumevano vreme dolaska na lokaciju u satima (opciono).
        /// </summary>
        public int? OnSiteH { get; set; }

        /// <summary>
        /// Model naplate za ovaj tip usluge (npr. "po satu", "paušalno").
        /// </summary>
        public string? BillModel { get; set; }

        /// <summary>
        /// Oznaka da li je tip usluge aktivan i dostupan za korišæenje.
        /// </summary>
        public bool Aktivan { get; set; }

        /// <summary>
        /// Redosled prikaza tipa usluge (za sortiranje u interfejsu).
        /// </summary>
        public int Redosled { get; set; }

        /// <summary>
        /// Datum i vreme kreiranja zapisa o tipu usluge.
        /// </summary>
        public DateTime CreatedAt { get; set; }
    }
}