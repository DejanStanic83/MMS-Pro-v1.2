using System;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja razlog (npr. razlog za izdavanje radnog naloga, reklamaciju ili neku drugu akciju).
    /// Sadrži osnovne podatke o razlogu, njegovoj kategoriji, šifri, nazivu i statusu aktivnosti.
    /// </summary>
    public class Razlog
    {
        /// <summary>
        /// Jedinstveni identifikator razloga.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Kategorija razloga (npr. "Servis", "Reklamacija", "Održavanje").
        /// </summary>
        public string? Kategorija { get; set; }

        /// <summary>
        /// Šifra razloga (npr. "SRV", "REK", "ODR").
        /// </summary>
        public string? Sifra { get; set; }

        /// <summary>
        /// Naziv razloga (npr. "Redovan servis", "Zamena dela", "Hitna intervencija").
        /// </summary>
        public string? Naziv { get; set; }

        /// <summary>
        /// Oznaka da li je razlog aktivan i dostupan za korišæenje.
        /// </summary>
        public bool Aktivan { get; set; }

        /// <summary>
        /// Redosled prikaza razloga (za sortiranje u interfejsu).
        /// </summary>
        public int Redosled { get; set; }
    }
}