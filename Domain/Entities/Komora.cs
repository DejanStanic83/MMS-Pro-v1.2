using System;
using System.Collections.Generic;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja komoru (npr. rashladnu, skladišnu ili drugu tehnièku komoru) u sistemu.
    /// Sadrži tehnièke i organizacione podatke, kao i veze sa objektom, opremom i radnim nalozima.
    /// </summary>
    public class Komora
    {
        /// <summary>
        /// Jedinstveni identifikator komore.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identifikator komore (šifra ili oznaka).
        /// </summary>
        public string? IdentKK { get; set; }

        /// <summary>
        /// Naziv komore.
        /// </summary>
        public string? NazivKK { get; set; }

        /// <summary>
        /// Tip komore (npr. tip rashladne komore).
        /// </summary>
        public string? TipKK { get; set; }

        /// <summary>
        /// Kolièina komora ovog tipa.
        /// </summary>
        public int? KolicinaKK { get; set; }

        /// <summary>
        /// Dimenzije komore (tekstualni opis).
        /// </summary>
        public string? DimenzijaKK { get; set; }

        /// <summary>
        /// Protok eksternog vazduha (ili slièno, zavisi od domene).
        /// </summary>
        public string? ProtokEx { get; set; }

        /// <summary>
        /// Protok suvog vazduha (ili slièno, zavisi od domene).
        /// </summary>
        public string? ProtokSU { get; set; }

        /// <summary>
        /// Sastav eksternog vazduha.
        /// </summary>
        public string? SastavEX { get; set; }

        /// <summary>
        /// Sastav suvog vazduha.
        /// </summary>
        public string? SastavSu { get; set; }

        /// <summary>
        /// Širina komore.
        /// </summary>
        public string? SirinaKK { get; set; }

        /// <summary>
        /// Visina komore.
        /// </summary>
        public string? VisinaKK { get; set; }

        /// <summary>
        /// Dužina komore.
        /// </summary>
        public string? DuzinaKK { get; set; }

        /// <summary>
        /// Težina komore.
        /// </summary>
        public string? TezinaKK { get; set; }

        /// <summary>
        /// Grupa kojoj komora pripada.
        /// </summary>
        public string? GrupaKK { get; set; }

        /// <summary>
        /// Neto cena komore.
        /// </summary>
        public decimal? NetoCenaKK { get; set; }

        /// <summary>
        /// Cena rada na komori.
        /// </summary>
        public decimal? CenaRadaKK { get; set; }

        /// <summary>
        /// Status komore (npr. aktivna, neaktivna, u upotrebi).
        /// </summary>
        public string? StatusKK { get; set; }

        /// <summary>
        /// Korisnik koji je uneo komoru.
        /// </summary>
        public string? KorisnikUnosaKK { get; set; }

        /// <summary>
        /// Informacije o automatizaciji komore.
        /// </summary>
        public string? AutomatikaKK { get; set; }

        /// <summary>
        /// Cloud identifikator ili povezanost (ako postoji).
        /// </summary>
        public string? ClaudKK { get; set; }

        /// <summary>
        /// Datum unosa komore u sistem.
        /// </summary>
        public DateTime? DatumUnosaKK { get; set; }

        /// <summary>
        /// ID objekta kojem komora pripada (strani kljuè).
        /// </summary>
        public int? ObjekatId { get; set; }

        /// <summary>
        /// Datum isporuke komore.
        /// </summary>
        public DateTime? DatumIsporukeKK { get; set; }

        /// <summary>
        /// Datum puštanja komore u rad.
        /// </summary>
        public DateTime? DatumPustanjaKK { get; set; }

        /// <summary>
        /// Ime automatièara koji je radio na komori.
        /// </summary>
        public string? ImeAutomaticara { get; set; }

        /// <summary>
        /// Serijski broj komore.
        /// </summary>
        public string? SeriskiBrojKK { get; set; }

        /// <summary>
        /// Napomena vezana za komoru.
        /// </summary>
        public string? NapomenaKK { get; set; }

        /// <summary>
        /// Oznaka sistema kome komora pripada.
        /// </summary>
        public string? OznakaSistemaKK { get; set; }

        /// <summary>
        /// JSON string sa podacima o filterima (opciono).
        /// </summary>
        public string? FilteriJson { get; set; }

        /// <summary>
        /// Oznaka da li je komora aktivna.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Datum kreiranja zapisa o komori.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Datum poslednje izmene zapisa o komori.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Verzija reda za konkurentni pristup (opciono, koristi se za optimistièko zakljuèavanje).
        /// </summary>
        public byte[]? RowVersion { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: objekat kojem komora pripada.
        /// </summary>
        public Objekat? Objekat { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: kolekcija opreme koja je vezana za komoru.
        /// </summary>
        public ICollection<Oprema> Oprema { get; set; } = new List<Oprema>();

        /// <summary>
        /// Navigaciono svojstvo: radni nalozi vezani za komoru.
        /// </summary>
        public ICollection<RadniNalog> RadniNalozi { get; set; } = new List<RadniNalog>();

        /// <summary>
        /// Navigaciono svojstvo: veze izmeðu komore i opreme (za relaciju više-na-više).
        /// </summary>
        public ICollection<KomoraOprema> KomoraOpreme { get; set; } = new List<KomoraOprema>();
    }
}