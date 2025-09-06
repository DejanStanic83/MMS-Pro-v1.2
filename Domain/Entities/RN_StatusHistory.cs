using System;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja istoriju promena statusa za radni nalog.
    /// Sadr�i podatke o starom i novom statusu, napomeni, korisniku koji je izvr�io promenu i vremenu promene.
    /// </summary>
    public class RN_StatusHistory
    {
        /// <summary>
        /// Jedinstveni identifikator zapisa o promeni statusa.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ID radnog naloga na koji se promena odnosi (strani klju�).
        /// </summary>
        public int RadniNalogId { get; set; }

        /// <summary>
        /// Status pre promene (tekstualno, mo�e biti null).
        /// </summary>
        public string? StariStatus { get; set; }

        /// <summary>
        /// Status posle promene (tekstualno, mo�e biti null).
        /// </summary>
        public string? NoviStatus { get; set; }

        /// <summary>
        /// Dodatna napomena vezana za promenu statusa.
        /// </summary>
        public string? Napomena { get; set; }

        /// <summary>
        /// ID korisnika koji je izvr�io promenu statusa (opciono, strani klju�).
        /// </summary>
        public int? ChangedByUserId { get; set; }

        /// <summary>
        /// Datum i vreme kada je status promenjen.
        /// </summary>
        public DateTime ChangedAt { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: radni nalog na koji se promena odnosi.
        /// </summary>
        public RadniNalog? RadniNalog { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: korisnik koji je izvr�io promenu statusa.
        /// </summary>
        public User? ChangedByUser { get; set; }
    }
}