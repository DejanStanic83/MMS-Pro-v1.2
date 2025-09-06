using System;
using System.Collections.Generic;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja ugovor izme�u klijenta i firme.
    /// Sadr�i osnovne podatke o ugovoru, vezu sa klijentom, objektom, radnim nalozima i fakturama.
    /// </summary>
    public class Ugovor
    {
        /// <summary>
        /// Jedinstveni identifikator ugovora.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Broj ugovora (mo�e biti null).
        /// </summary>
        public string? BrojUgovora { get; set; }

        /// <summary>
        /// ID klijenta sa kojim je ugovor sklopljen (strani klju�).
        /// </summary>
        public int KlijentId { get; set; }

        /// <summary>
        /// ID objekta na koji se ugovor odnosi (opciono, strani klju�).
        /// </summary>
        public int? ObjekatId { get; set; }

        /// <summary>
        /// Datum po�etka va�enja ugovora.
        /// </summary>
        public DateTime Pocetak { get; set; }

        /// <summary>
        /// Datum zavr�etka va�enja ugovora (opciono).
        /// </summary>
        public DateTime? Kraj { get; set; }

        /// <summary>
        /// Da li se ugovor automatski obnavlja.
        /// </summary>
        public bool AutomatskoObnavljanje { get; set; }

        /// <summary>
        /// SLA nivo ugovora (npr. "Standard", "Premium", mo�e biti null).
        /// </summary>
        public string? SLA_Nivo { get; set; }

        /// <summary>
        /// Vreme po�etka radnih dana (opciono).
        /// </summary>
        public TimeSpan? RadniDaniOd { get; set; }

        /// <summary>
        /// Vreme zavr�etka radnih dana (opciono).
        /// </summary>
        public TimeSpan? RadniDaniDo { get; set; }

        /// <summary>
        /// Da li je dostupnost 24/7.
        /// </summary>
        public bool Dostupnost24x7 { get; set; }

        /// <summary>
        /// Model obra�una (npr. "pau�al", "po satu", mo�e biti null).
        /// </summary>
        public string? ModelObracuna { get; set; }

        /// <summary>
        /// Mese�ni limit sati (opciono).
        /// </summary>
        public decimal? MesecniLimitSati { get; set; }

        /// <summary>
        /// Cena pau�ala (opciono).
        /// </summary>
        public decimal? CenaPausala { get; set; }

        /// <summary>
        /// Satnica za servisera (opciono).
        /// </summary>
        public decimal? Satnica_Serviser { get; set; }

        /// <summary>
        /// Satnica za in�enjera (opciono).
        /// </summary>
        public decimal? Satnica_Inzenjer { get; set; }

        /// <summary>
        /// Popust na materijal (opciono).
        /// </summary>
        public decimal? PopustMaterijal { get; set; }

        /// <summary>
        /// Kontakt osoba za operativu (mo�e biti null).
        /// </summary>
        public string? KontaktOperativa { get; set; }

        /// <summary>
        /// Kontakt osoba za finansije (mo�e biti null).
        /// </summary>
        public string? KontaktFinansije { get; set; }

        /// <summary>
        /// Status ugovora (npr. "Aktivan", "Neaktivan", mo�e biti null).
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// Dodatna napomena uz ugovor (mo�e biti null).
        /// </summary>
        public string? Napomena { get; set; }

        /// <summary>
        /// Datum kreiranja ugovora.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Datum poslednje izmene ugovora (opciono).
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Verzija reda za konkurentni pristup (opciono, koristi se za optimisti�ko zaklju�avanje).
        /// </summary>
        public byte[]? RowVersion { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: klijent sa kojim je ugovor sklopljen.
        /// </summary>
        public Klijent? Klijent { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: objekat na koji se ugovor odnosi.
        /// </summary>
        public Objekat? Objekat { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: radni nalozi vezani za ovaj ugovor.
        /// </summary>
        public ICollection<RadniNalog> RadniNalozi { get; set; } = new List<RadniNalog>();

        /// <summary>
        /// Navigaciono svojstvo: fakture vezane za ovaj ugovor.
        /// </summary>
        public ICollection<Faktura> Fakture { get; set; } = new List<Faktura>();
    }
}