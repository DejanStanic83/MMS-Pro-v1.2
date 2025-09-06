using System;
using Microsoft.EntityFrameworkCore;
using MMS.Domain.Entities;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace MMS.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Master tabele
        public DbSet<Klijent> Klijenti { get; set; }
        public DbSet<Objekat> Objekti { get; set; }
        public DbSet<Komora> Komore { get; set; }
        public DbSet<Oprema> Opreme { get; set; }
        public DbSet<Ugovor> Ugovori { get; set; }
        public DbSet<FakturaStatus> FakturaStatusi { get; set; }
        public DbSet<Faktura> Fakture { get; set; }
        public DbSet<Prioritet> Prioriteti { get; set; }
        public DbSet<JedinicaMere> JediniceMere { get; set; }
        public DbSet<Valuta> Valute { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Kontakt> Kontakti { get; set; }
        public DbSet<KontaktUloga> KontaktUloge { get; set; }
        public DbSet<Razlog> Razlozi { get; set; }
        public DbSet<OpremaKategorija> OpremaKategorije { get; set; }
        public DbSet<KalendarStatus> KalendarStatusi { get; set; }

        // Transakcione i vezne tabele
        public DbSet<RadniNalog> RadniNalozi { get; set; }
        public DbSet<Reklamacija> Reklamacije { get; set; }
        public DbSet<Uplata> Uplate { get; set; }
        public DbSet<UplataAlokacija> UplataAlokacije { get; set; }
        public DbSet<KlijentObjekat> KlijentObjekti { get; set; }
        public DbSet<KomoraOprema> KomoraOpreme { get; set; }
        public DbSet<RN_Materijal> RN_Materijali { get; set; }
        public DbSet<RN_Rad> RN_Radovi { get; set; }
        public DbSet<RN_Rashod> RN_Rashodi { get; set; }
        public DbSet<RN_SLA> RN_SLA { get; set; }
        public DbSet<RN_StatusHistory> RN_StatusHistory { get; set; }
        public DbSet<RN_Trosak> RN_Troskovi { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // KlijentObjekat - composite key
            modelBuilder.Entity<KlijentObjekat>()
                .HasKey(ko => new { ko.KlijentId, ko.ObjekatId });

            modelBuilder.Entity<KlijentObjekat>()
                .HasOne(ko => ko.Klijent)
                .WithMany(k => k.KlijentObjekti)
                .HasForeignKey(ko => ko.KlijentId);

            modelBuilder.Entity<KlijentObjekat>()
                .HasOne(ko => ko.Objekat)
                .WithMany(o => o.KlijentObjekti)
                .HasForeignKey(ko => ko.ObjekatId);

            // KomoraOprema - composite key
            modelBuilder.Entity<KomoraOprema>()
                .HasKey(ko => new { ko.KomoraId, ko.OpremaId });

            modelBuilder.Entity<KomoraOprema>()
                .HasOne(ko => ko.Komora)
                .WithMany(k => k.KomoraOpreme)
                .HasForeignKey(ko => ko.KomoraId);

            modelBuilder.Entity<KomoraOprema>()
                .HasOne(ko => ko.Oprema)
                .WithMany(o => o.KomoraOpreme)
                .HasForeignKey(ko => ko.OpremaId);

            modelBuilder.Entity<Valuta>().HasNoKey();

            // Ostale konfiguracije po potrebi...
        }

        public async Task<bool> HealthCheckAsync(ILogger? logger = null)
        {
            try
            {
                var canConnect = await Database.CanConnectAsync();
                logger?.LogInformation("Database health check: {Result}", canConnect ? "OK" : "FAILED");
                return canConnect;
            }
            catch (Exception ex)
            {
                logger?.LogError(ex, "Database health check failed with exception.");
                return false;
            }
        }
    }
}