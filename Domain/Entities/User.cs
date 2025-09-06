using System;
using System.Collections.Generic;

namespace MMS.Domain.Entities
{
    /// <summary>
    /// Predstavlja korisnika sistema.
    /// Sadrži osnovne podatke o korisniku, bezbednosne informacije i veze sa ulogom i radnim nalozima.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Jedinstveni identifikator korisnika.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Korisnièko ime za prijavu.
        /// </summary>
        public string? UserName { get; set; }

        /// <summary>
        /// Hash lozinke korisnika.
        /// </summary>
        public string? PasswordHash { get; set; }

        /// <summary>
        /// Naziv uloge korisnika (npr. "Admin", "User").
        /// </summary>
        public string? Role { get; set; }

        /// <summary>
        /// Ime korisnika.
        /// </summary>
        public string? Ime { get; set; }

        /// <summary>
        /// Prezime korisnika.
        /// </summary>
        public string? Prezime { get; set; }

        /// <summary>
        /// Email adresa korisnika.
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Oznaka da li je korisnik aktivan.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Datum kreiranja korisnika.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Datum poslednje izmene korisnika (opciono).
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Datum poslednje prijave korisnika (opciono).
        /// </summary>
        public DateTime? LastLoginAt { get; set; }

        /// <summary>
        /// Verzija reda za konkurentni pristup (opciono, koristi se za optimistièko zakljuèavanje).
        /// </summary>
        public byte[]? RowVersion { get; set; }

        /// <summary>
        /// Broj neuspešnih pokušaja prijave.
        /// </summary>
        public int FailedLoginCount { get; set; }

        /// <summary>
        /// Vreme do kada je korisnik zakljuèan (opciono).
        /// </summary>
        public DateTime? LockoutUntil { get; set; }

        /// <summary>
        /// ID uloge korisnika (strani kljuè ka entitetu Role, opciono).
        /// </summary>
        public int? RoleId { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: uloga korisnika.
        /// </summary>
        public Role? RoleNavigation { get; set; }

        /// <summary>
        /// Navigaciono svojstvo: radni nalozi koje je korisnik kreirao ili za koje je odgovoran.
        /// </summary>
        public ICollection<RadniNalog> RadniNalozi { get; set; } = new List<RadniNalog>();
    }
}