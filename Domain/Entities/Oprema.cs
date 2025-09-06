using System;
using System.Collections.Generic;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja opremu (npr. ure�aj, komponentu, alat) koja se koristi u sistemu.
    /// Sadr�i osnovne podatke o opremi, vezu sa kategorijom i veze sa komorama kroz relaciju vi�e-na-vi�e.
    /// </summary>
    public class Oprema
    {
        /// <summary>
        /// Jedinstveni identifikator opreme.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// �ifra opreme (npr. katalo�ki broj ili interna oznaka).
        /// </summary>
        public string? Sifra { get; set; }

        /// <summary>
        /// Naziv opreme.
        /// </summary>
        public string? Naziv { get; set; }

        /// <summary>
        /// ID kategorije kojoj oprema pripada (strani klju�).
        /// </summary>
        public int? KategorijaId { get; set; }

        /// <summary>
        /// Proizvo�a� opreme.
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
        /// Oznaka da li je oprema aktivna i dostupna za kori��enje.
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
        /// Verzija reda za konkurentni pristup (opciono, koristi se za optimisti�ko zaklju�avanje).
        /// </summary>
        public byte[]? RowVersion { get; set; }

        /// <summary>
        /// Oznaka da li je oprema potro�na roba (npr. filteri, materijal).
        /// </summary>
        public bool IsConsumable { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: kategorija kojoj oprema pripada.
        /// </summary>
        public OpremaKategorija? Kategorija { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: veze izme�u opreme i komora (relacija vi�e-na-vi�e).
        /// </summary>
        public ICollection<KomoraOprema> KomoraOpreme { get; set; } = new List<KomoraOprema>();
    }
}