﻿// <auto-generated />
using System;
using Implementacija.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Implementacija.Migrations
{
    [DbContext(typeof(BeautyCentarContext))]
    [Migration("20200525174927_Migracija2")]
    partial class Migracija2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Implementacija.Models.FormaZaTestDB", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("klijentID")
                        .HasColumnType("int");

                    b.Property<int?>("preporuceniTretmanID")
                        .HasColumnType("int");

                    b.Property<int>("tipKoze")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("klijentID");

                    b.HasIndex("preporuceniTretmanID");

                    b.ToTable("FormaZaTest");
                });

            modelBuilder.Entity("Implementacija.Models.FormaZaTretmanDB", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("klijentID")
                        .HasColumnType("int");

                    b.Property<string>("opisRezultata")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("tretmanID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("klijentID");

                    b.HasIndex("tretmanID");

                    b.ToTable("FormaZaTretman");
                });

            modelBuilder.Entity("Implementacija.Models.Izvjestaj", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("datumIVrijeme")
                        .HasColumnType("datetime2");

                    b.Property<string>("nazivSalona")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Izvjestaj");
                });

            modelBuilder.Entity("Implementacija.Models.KorisnikDB", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prezime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("Implementacija.Models.RezervacijaDB", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("imeIPrezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("korisnikID")
                        .HasColumnType("int");

                    b.Property<int?>("odabraniTretmanID")
                        .HasColumnType("int");

                    b.Property<int>("tipPlacanja")
                        .HasColumnType("int");

                    b.Property<DateTime>("vrijemeRezervacije")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("korisnikID");

                    b.HasIndex("odabraniTretmanID");

                    b.ToTable("Rezervacija");
                });

            modelBuilder.Entity("Implementacija.Models.Tretman", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KorisnikDBID")
                        .HasColumnType("int");

                    b.Property<float>("cijena")
                        .HasColumnType("real");

                    b.Property<int>("kategorijaTretmana")
                        .HasColumnType("int");

                    b.Property<string>("naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("opisTretmana")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("KorisnikDBID");

                    b.ToTable("Tretman");
                });

            modelBuilder.Entity("Implementacija.Models.UplatnicaDB", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("brojRacuna")
                        .HasColumnType("int");

                    b.Property<double>("cijenaTretmana")
                        .HasColumnType("float");

                    b.Property<int?>("klijentID")
                        .HasColumnType("int");

                    b.Property<int>("nacinPlacanja")
                        .HasColumnType("int");

                    b.Property<string>("nazivTretmana")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("klijentID");

                    b.ToTable("Uplatnica");
                });

            modelBuilder.Entity("Implementacija.Models.ZaposlenikDB", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipKozmeticara")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Zaposlenik");
                });

            modelBuilder.Entity("Implementacija.Models.FormaZaTestDB", b =>
                {
                    b.HasOne("Implementacija.Models.KorisnikDB", "klijent")
                        .WithMany()
                        .HasForeignKey("klijentID");

                    b.HasOne("Implementacija.Models.Tretman", "preporuceniTretman")
                        .WithMany()
                        .HasForeignKey("preporuceniTretmanID");
                });

            modelBuilder.Entity("Implementacija.Models.FormaZaTretmanDB", b =>
                {
                    b.HasOne("Implementacija.Models.KorisnikDB", "klijent")
                        .WithMany()
                        .HasForeignKey("klijentID");

                    b.HasOne("Implementacija.Models.Tretman", "tretman")
                        .WithMany()
                        .HasForeignKey("tretmanID");
                });

            modelBuilder.Entity("Implementacija.Models.RezervacijaDB", b =>
                {
                    b.HasOne("Implementacija.Models.KorisnikDB", "korisnik")
                        .WithMany()
                        .HasForeignKey("korisnikID");

                    b.HasOne("Implementacija.Models.Tretman", "odabraniTretman")
                        .WithMany()
                        .HasForeignKey("odabraniTretmanID");
                });

            modelBuilder.Entity("Implementacija.Models.Tretman", b =>
                {
                    b.HasOne("Implementacija.Models.KorisnikDB", null)
                        .WithMany("listaOdradjenihTretmana")
                        .HasForeignKey("KorisnikDBID");
                });

            modelBuilder.Entity("Implementacija.Models.UplatnicaDB", b =>
                {
                    b.HasOne("Implementacija.Models.KorisnikDB", "klijent")
                        .WithMany()
                        .HasForeignKey("klijentID");
                });
#pragma warning restore 612, 618
        }
    }
}
