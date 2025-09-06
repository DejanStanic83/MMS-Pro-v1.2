using System;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja radni nalog u sistemu.
    /// Sadrži osnovne podatke o nalogu, vezu sa ugovorom, objektom, komorom, tipom usluge, korisnikom i razlogom.
    /// </summary>
    public class RadniNalog
    {
        /// <summary>
        /// Jedinstveni identifikator radnog naloga.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Broj radnog naloga (može biti null).
        /// </summary>
        public string? BrojRN { get; set; }

        /// <summary>
        /// Datum kreiranja ili izdavanja radnog naloga.
        /// </summary>
        public DateTime Datum { get; set; }

        /// <summary>
        /// ID ugovora na koji se radni nalog odnosi (strani kljuè).
        /// </summary>
        public int UgovorId { get; set; }

        /// <summary>
        /// ID objekta na koji se radni nalog odnosi (strani kljuè).
        /// </summary>
        public int ObjekatId { get; set; }

        /// <summary>
        /// ID komore na koju se radni nalog odnosi (opciono, strani kljuè).
        /// </summary>
        public int? KomoraId { get; set; }

        /// <summary>
        /// ID tipa usluge koja se izvršava ovim nalogom (strani kljuè).
        /// </summary>
        public int TipUslugeId { get; set; }

        /// <summary>
        /// Prioritet radnog naloga (tekstualno, može biti null).
        /// </summary>
        public string? Prioritet { get; set; }

        /// <summary>
        /// Status radnog naloga (tekstualno, može biti null).
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// ID korisnika koji je kreirao nalog (opciono, strani kljuè).
        /// </summary>
        public int? CreatedByUserId { get; set; }

        /// <summary>
        /// Dodatna napomena vezana za radni nalog.
        /// </summary>
        public string? Napomena { get; set; }

        /// <summary>
        /// ID razloga za izdavanje naloga (opciono, strani kljuè).
        /// </summary>
        public int? RazlogId { get; set; }

        /// <summary>
        /// Datum i vreme kreiranja naloga (opciono).
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Datum i vreme poslednje izmene naloga (opciono).
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Verzija reda za konkurentni pristup (opciono, koristi se za optimistièko zakljuèavanje).
        /// </summary>
        public byte[]? RowVersion { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: ugovor na koji se radni nalog odnosi.
        /// </summary>
        public Ugovor? Ugovor { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: objekat na koji se radni nalog odnosi.
        /// </summary>
        public Objekat? Objekat { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: komora na koju se radni nalog odnosi.
        /// </summary>
        public Komora? Komora { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: tip usluge koja se izvršava ovim nalogom.
        /// </summary>
        public TipUsluge? TipUsluge { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: korisnik koji je kreirao nalog.
        /// </summary>
        public User? CreatedByUser { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: razlog za izdavanje naloga.
        /// </summary>
        public Razlog? Razlog { get; set; }
    }
}