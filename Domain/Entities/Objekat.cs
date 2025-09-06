using System;
using System.Collections.Generic;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja objekat (npr. lokaciju, zgradu, postrojenje) u sistemu.
    /// Sadrži osnovne podatke o objektu i veze sa klijentom, komorama, ugovorima i radnim nalozima.
    /// </summary>
    public class Objekat
    {
        /// <summary>
        /// Jedinstveni identifikator objekta.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Naziv objekta.
        /// </summary>
        public string? NazivObjekta { get; set; }

        /// <summary>
        /// Grad u kome se objekat nalazi.
        /// </summary>
        public string? Grad { get; set; }

        /// <summary>
        /// Adresa objekta.
        /// </summary>
        public string? Adresa { get; set; }

        /// <summary>
        /// Geografska dužina lokacije objekta.
        /// </summary>
        public decimal? Lokacija_Longitude { get; set; }

        /// <summary>
        /// Geografska širina lokacije objekta.
        /// </summary>
        public decimal? Lokacija_Latitude { get; set; }

        /// <summary>
        /// Zemlja u kojoj se objekat nalazi.
        /// </summary>
        public string? Zemlja { get; set; }

        /// <summary>
        /// Datum unosa objekta u sistem.
        /// </summary>
        public DateTime? DatumUnosaObj { get; set; }

        /// <summary>
        /// Korisnik koji je uneo objekat.
        /// </summary>
        public string? KorisnikUnosaObj { get; set; }

        /// <summary>
        /// Vlasnik objekta (tekstualno polje).
        /// </summary>
        public string? VlasnikObjekta { get; set; }

        /// <summary>
        /// Telefon kontakt osobe za objekat.
        /// </summary>
        public string? TelefonKOsobe { get; set; }

        /// <summary>
        /// Email adresa objekta.
        /// </summary>
        public string? EmailObjekta { get; set; }

        /// <summary>
        /// Oznaka da li je objekat aktivan.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Datum kreiranja zapisa o objektu.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Datum poslednje izmene zapisa o objektu.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Verzija reda za konkurentni pristup (opciono, koristi se za optimistièko zakljuèavanje).
        /// </summary>
        public byte[]? RowVersion { get; set; }

        /// <summary>
        /// ID klijenta kome objekat pripada (strani kljuè).
        /// </summary>
        public int KlijentId { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: klijent kome objekat pripada.
        /// </summary>
        public Klijent? Klijent { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: kolekcija komora koje pripadaju objektu.
        /// </summary>
        public ICollection<Komora> Komore { get; set; } = new List<Komora>();

        /// <summary>
        /// Navigaciono svojstvo: kolekcija ugovora vezanih za objekat.
        /// </summary>
        public ICollection<Ugovor> Ugovori { get; set; } = new List<Ugovor>();

        /// <summary>
        /// Navigaciono svojstvo: kolekcija radnih naloga vezanih za objekat.
        /// </summary>
        public ICollection<RadniNalog> RadniNalozi { get; set; } = new List<RadniNalog>();

        /// <summary>
        /// Navigaciono svojstvo: veze izmeðu klijenata i objekata (za relaciju više-na-više).
        /// </summary>
        public ICollection<KlijentObjekat> KlijentObjekti { get; set; } = new List<KlijentObjekat>();
    }
}