using System;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja reklamaciju (prijavu kvara, zahteva za servis ili nezadovoljstva) u sistemu.
    /// Sadrži osnovne podatke o reklamaciji, vezu sa ugovorom, radnim nalogom, komorom, opremom, razlogom i korisnikom koji je kreirao reklamaciju.
    /// </summary>
    public class Reklamacija
    {
        /// <summary>
        /// Jedinstveni identifikator reklamacije.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Datum prijave reklamacije.
        /// </summary>
        public DateTime Datum { get; set; }

        /// <summary>
        /// ID ugovora na koji se reklamacija odnosi (opciono, strani kljuè).
        /// </summary>
        public int? UgovorId { get; set; }

        /// <summary>
        /// ID radnog naloga vezanog za reklamaciju (opciono, strani kljuè).
        /// </summary>
        public int? RadniNalogId { get; set; }

        /// <summary>
        /// ID komore na koju se reklamacija odnosi (opciono, strani kljuè).
        /// </summary>
        public int? KomoraId { get; set; }

        /// <summary>
        /// ID opreme na koju se reklamacija odnosi (opciono, strani kljuè).
        /// </summary>
        public int? OpremaId { get; set; }

        /// <summary>
        /// Opis kvara ili problema koji je prijavljen.
        /// </summary>
        public string? OpisKvara { get; set; }

        /// <summary>
        /// Status reklamacije (npr. "Otvorena", "U toku", "Zatvorena").
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// ID razloga reklamacije (opciono, strani kljuè).
        /// </summary>
        public int? RazlogId { get; set; }

        /// <summary>
        /// ID korisnika koji je kreirao reklamaciju (opciono, strani kljuè).
        /// </summary>
        public int? CreatedByUserId { get; set; }

        /// <summary>
        /// Datum i vreme kreiranja reklamacije.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: ugovor na koji se reklamacija odnosi.
        /// </summary>
        public Ugovor? Ugovor { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: radni nalog vezan za reklamaciju.
        /// </summary>
        public RadniNalog? RadniNalog { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: komora na koju se reklamacija odnosi.
        /// </summary>
        public Komora? Komora { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: oprema na koju se reklamacija odnosi.
        /// </summary>
        public Oprema? Oprema { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: razlog reklamacije.
        /// </summary>
        public Razlog? Razlog { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: korisnik koji je kreirao reklamaciju.
        /// </summary>
        public User? CreatedByUser { get; set; }
    }
}