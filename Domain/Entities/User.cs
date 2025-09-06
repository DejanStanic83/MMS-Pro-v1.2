using System;
using System.Collections.Generic;

namespace MMS.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? PasswordHash { get; set; }
        public string? Role { get; set; }
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public string? Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? LastLoginAt { get; set; }
        public byte[]? RowVersion { get; set; }
        public int FailedLoginCount { get; set; }
        public DateTime? LockoutUntil { get; set; }
        public int? RoleId { get; set; }

        public Role? RoleNavigation { get; set; }
        public ICollection<RadniNalog> RadniNalozi { get; set; } = new List<RadniNalog>();
    }
}