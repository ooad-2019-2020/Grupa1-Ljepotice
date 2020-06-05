using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Implementacija.Models;

namespace Implementacija.Models
{

    public class BeautyCentarContext : DbContext
    {
        public static BeautyCentarContext instance;

        public BeautyCentarContext(DbContextOptions<BeautyCentarContext> options) : base(options)
        {
            instance = this;
        }

        public static BeautyCentarContext getInstance()
        {
            return instance;
        }

        public DbSet<ZaposlenikDB> Zaposlenik { get; set; }

        public DbSet<KorisnikDB> Korisnik { get; set; }

        public DbSet<Izvjestaj> Izvjestaj { get; set; }
        public DbSet<RezervacijaDB> Rezervacija { get; set; }
        public DbSet<Tretman> Tretman { get; set; }
        public DbSet<UplatnicaDB> Uplatnica { get; set; }
    

        public DbSet<FormaZaTestDB> FormaZaTest { get; set; }
        public DbSet<FormaZaTretmanDB> FormaZaTretman { get; set; }
     



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ZaposlenikDB>().ToTable("Zaposlenik");
            modelBuilder.Entity<KorisnikDB>().ToTable("Korisnik");
            modelBuilder.Entity<FormaZaTestDB>().ToTable("FormaZaTest");
            modelBuilder.Entity<FormaZaTretmanDB>().ToTable("FormaZaTretman");
            modelBuilder.Entity<Izvjestaj>().ToTable("Izvjestaj");
            modelBuilder.Entity<Tretman>().ToTable("Tretman");
            modelBuilder.Entity<RezervacijaDB>().ToTable("Rezervacija");
            modelBuilder.Entity<UplatnicaDB>().ToTable("Uplatnica");
       




        }
     



       
    }
}
