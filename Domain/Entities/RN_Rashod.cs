using System;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja rashod (tro�ak) vezan za radni nalog.
    /// Sadr�i podatke o vrsti rashoda, opremi, korisniku, koli�ini, ceni, dobavlja�u i dokumentaciji.
    /// </summary>
    public class RN_Rashod
    {
        /// <summary>
        /// Jedinstveni identifikator rashoda.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ID radnog naloga kojem rashod pripada (strani klju�).
        /// </summary>
        public int RadniNalogId { get; set; }

        /// <summary>
        /// Tip rashoda (npr. materijal, usluga, gorivo).
        /// </summary>
        public string? TipRashoda { get; set; }

        /// <summary>
        /// ID opreme na koju se rashod odnosi (opciono, strani klju�).
        /// </summary>
        public int? OpremaId { get; set; }

        /// <summary>
        /// ID korisnika koji je evidentirao rashod (opciono, strani klju�).
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Jedinica mere (npr. "kom", "l", "kg").
        /// </summary>
        public string? JM { get; set; }

        /// <summary>
        /// Koli�ina rashoda.
        /// </summary>
        public decimal Kolicina { get; set; }

        /// <summary>
        /// Nabavna cena po jedinici (opciono).
        /// </summary>
        public decimal? NabavnaCena { get; set; }

        /// <summary>
        /// Ukupan iznos rashoda (opciono).
        /// </summary>
        public decimal? Iznos { get; set; }

        /// <summary>
        /// Valuta u kojoj je rashod izra�en (npr. "RSD", "EUR").
        /// </summary>
        public string? Valuta { get; set; }

        /// <summary>
        /// ID dobavlja�a (opciono, strani klju� ka entitetu Klijent).
        /// </summary>
        public int? DobavljacId { get; set; }

        /// <summary>
        /// Broj dokumenta (fakture, otpremnice) vezanog za rashod.
        /// </summary>
        public string? BrojDok { get; set; }

        /// <summary>
        /// Datum dokumenta vezanog za rashod (opciono).
        /// </summary>
        public DateTime? DatumDok { get; set; }

        /// <summary>
        /// Opis rashoda ili dodatna napomena.
        /// </summary>
        public string? Opis { get; set; }

        /// <summary>
        /// Datum kada je rashod nastao.
        /// </summary>
        public DateTime DatumRashoda { get; set; }

        /// <summary>
        /// Datum i vreme kreiranja zapisa o rashodu.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Verzija reda za konkurentni pristup (opciono, koristi se za optimisti�ko zaklju�avanje).
        /// </summary>
        public byte[]? RowVersion { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: radni nalog kojem rashod pripada.
        /// </summary>
        public RadniNalog? RadniNalog { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: oprema na koju se rashod odnosi.
        /// </summary>
        public Oprema? Oprema { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: korisnik koji je evidentirao rashod.
        /// </summary>
        public User? User { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: dobavlja� (klijent) od koga je nabavljen materijal ili usluga.
        /// </summary>
        public Klijent? Dobavljac { get; set; }
    }
}