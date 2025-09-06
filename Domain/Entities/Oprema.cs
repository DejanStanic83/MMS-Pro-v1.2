using System;
using System.Collections.Generic;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja opremu (npr. ureðaj, komponentu, alat) koja se koristi u sistemu.
    /// Sadrži osnovne podatke o opremi, vezu sa kategorijom i veze sa komorama kroz relaciju više-na-više.
    /// </summary>
    public class Oprema
    {
        /// <summary>
        /// Jedinstveni identifikator opreme.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Šifra opreme (npr. kataloški broj ili interna oznaka).
        /// </summary>
        public string? Sifra { get; set; }

        /// <summary>
        /// Naziv opreme.
        /// </summary>
        public string? Naziv { get; set; }

        /// <summary>
        /// ID kategorije kojoj oprema pripada (strani kljuè).
        /// </summary>
        public int? KategorijaId { get; set; }

        /// <summary>
        /// Proizvoðaè opreme.
        /// </summary>
        public string? Proizvodjac { get; set; }

        /// <summary>
        /// Model opreme.
        /// </summary>
        public string? Model { get; set; }

        /// <summary>
        /// Podrazumevana jedinica mere za opremu (npr. "kom", "m", "kg").
        /// </summary>
        public string? JM_Default { get; set; }

        /// <summary>
        /// Specifikacija opreme u JSON formatu (opciono).
        /// </summary>
        public string? SpecJson { get; set; }

        /// <summary>
        /// Oznaka da li je oprema aktivna i dostupna za korišæenje.
        /// </summary>
        public bool Aktivan { get; set; }

        /// <summary>
        /// Datum kreiranja zapisa o opremi.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Datum poslednje izmene zapisa o opremi (opciono).
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Verzija reda za konkurentni pristup (opciono, koristi se za optimistièko zakljuèavanje).
        /// </summary>
        public byte[]? RowVersion { get; set; }

        /// <summary>
        /// Oznaka da li je oprema potrošna roba (npr. filteri, materijal).
        /// </summary>
        public bool IsConsumable { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: kategorija kojoj oprema pripada.
        /// </summary>
        public OpremaKategorija? Kategorija { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: veze izmeðu opreme i komora (relacija više-na-više).
        /// </summary>
        public ICollection<KomoraOprema> KomoraOpreme { get; set; } = new List<KomoraOprema>();
    }
}