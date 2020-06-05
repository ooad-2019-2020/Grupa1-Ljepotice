using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace API
{
    public partial class bazapodatakaContext : DbContext
    {
        public bazapodatakaContext()
        {
        }

        public bazapodatakaContext(DbContextOptions<bazapodatakaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FormaZaTest> FormaZaTest { get; set; }
        public virtual DbSet<FormaZaTretman> FormaZaTretman { get; set; }
        public virtual DbSet<Izvjestaj> Izvjestaj { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<Rezervacija> Rezervacija { get; set; }
        public virtual DbSet<Tretman> Tretman { get; set; }
        public virtual DbSet<Uplatnica> Uplatnica { get; set; }
        public virtual DbSet<Zaposlenik> Zaposlenik { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-8UL03UD;Database=bazapodataka;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FormaZaTest>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Klijent).HasColumnName("klijent");

                entity.Property(e => e.OdabranaZona).HasColumnName("odabranaZona");

                entity.Property(e => e.Rezultat).HasColumnName("rezultat");

                entity.Property(e => e.TipKoze).HasColumnName("tipKoze");
            });

            modelBuilder.Entity<FormaZaTretman>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DodatneNapomene).HasColumnName("dodatneNapomene");

                entity.Property(e => e.Klijent).HasColumnName("klijent");

                entity.Property(e => e.OdabranaZona).HasColumnName("odabranaZona");

                entity.Property(e => e.RezultatTretmana).HasColumnName("rezultatTretmana");

                entity.Property(e => e.TehnikaRada).HasColumnName("tehnikaRada");

                entity.Property(e => e.Tretman).HasColumnName("tretman");
            });

            modelBuilder.Entity<Izvjestaj>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DatumIvrijeme).HasColumnName("datumIVrijeme");

                entity.Property(e => e.NazivSalona).HasColumnName("nazivSalona");
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Ime).HasColumnName("ime");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.Prezime).HasColumnName("prezime");
            });

            modelBuilder.Entity<Rezervacija>(entity =>
            {
                entity.HasIndex(e => e.KorisnikId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImeIprezime).HasColumnName("imeIPrezime");

                entity.Property(e => e.KorisnikId).HasColumnName("korisnikID");

                entity.Property(e => e.OdabraniTretman).HasColumnName("odabraniTretman");

                entity.Property(e => e.TipPlacanja).HasColumnName("tipPlacanja");

                entity.Property(e => e.VrijemeRezervacije).HasColumnName("vrijemeRezervacije");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Rezervacija)
                    .HasForeignKey(d => d.KorisnikId);
            });

            modelBuilder.Entity<Tretman>(entity =>
            {
                entity.HasIndex(e => e.KorisnikDbid);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cijena).HasColumnName("cijena");

                entity.Property(e => e.KategorijaTretmana).HasColumnName("kategorijaTretmana");

                entity.Property(e => e.KorisnikDbid).HasColumnName("KorisnikDBID");

                entity.Property(e => e.Naziv).HasColumnName("naziv");

                entity.Property(e => e.OpisTretmana).HasColumnName("opisTretmana");

                entity.HasOne(d => d.KorisnikDb)
                    .WithMany(p => p.Tretman)
                    .HasForeignKey(d => d.KorisnikDbid);
            });

            modelBuilder.Entity<Uplatnica>(entity =>
            {
                entity.HasIndex(e => e.KlijentId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BrojRacuna).HasColumnName("brojRacuna");

                entity.Property(e => e.CijenaTretmana).HasColumnName("cijenaTretmana");

                entity.Property(e => e.KlijentId).HasColumnName("klijentID");

                entity.Property(e => e.NacinPlacanja).HasColumnName("nacinPlacanja");

                entity.Property(e => e.NazivTretmana).HasColumnName("nazivTretmana");

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Uplatnica)
                    .HasForeignKey(d => d.KlijentId);
            });

            modelBuilder.Entity<Zaposlenik>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ime).HasColumnName("ime");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.Prezime).HasColumnName("prezime");

                entity.Property(e => e.TipKozmeticara).HasColumnName("tipKozmeticara");

                entity.Property(e => e.Username).HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
