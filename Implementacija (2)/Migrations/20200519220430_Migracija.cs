using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Implementacija.Migrations
{
    public partial class Migracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Izvjestaj",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazivSalona = table.Column<string>(nullable: true),
                    datumIVrijeme = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Izvjestaj", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ime = table.Column<string>(nullable: true),
                    prezime = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Zaposlenik",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ime = table.Column<string>(nullable: true),
                    prezime = table.Column<string>(nullable: true),
                    username = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    tipKozmeticara = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaposlenik", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tretman",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    naziv = table.Column<string>(nullable: true),
                    cijena = table.Column<float>(nullable: false),
                    kategorijaTretmana = table.Column<int>(nullable: false),
                    opisTretmana = table.Column<string>(nullable: true),
                    KorisnikDBID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tretman", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tretman_Korisnik_KorisnikDBID",
                        column: x => x.KorisnikDBID,
                        principalTable: "Korisnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Uplatnica",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazivTretmana = table.Column<string>(nullable: true),
                    klijentID = table.Column<int>(nullable: true),
                    brojRacuna = table.Column<int>(nullable: false),
                    cijenaTretmana = table.Column<double>(nullable: false),
                    nacinPlacanja = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uplatnica", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Uplatnica_Korisnik_klijentID",
                        column: x => x.klijentID,
                        principalTable: "Korisnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormaZaTest",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipKoze = table.Column<int>(nullable: false),
                    preporuceniTretmanID = table.Column<int>(nullable: true),
                    klijentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaZaTest", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FormaZaTest_Korisnik_klijentID",
                        column: x => x.klijentID,
                        principalTable: "Korisnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormaZaTest_Tretman_preporuceniTretmanID",
                        column: x => x.preporuceniTretmanID,
                        principalTable: "Tretman",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormaZaTretman",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tretmanID = table.Column<int>(nullable: true),
                    opisRezultata = table.Column<string>(nullable: true),
                    klijentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaZaTretman", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FormaZaTretman_Korisnik_klijentID",
                        column: x => x.klijentID,
                        principalTable: "Korisnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormaZaTretman_Tretman_tretmanID",
                        column: x => x.tretmanID,
                        principalTable: "Tretman",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacija",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    korisnikID = table.Column<int>(nullable: true),
                    vrijemeRezervacije = table.Column<DateTime>(nullable: false),
                    odabraniTretmanID = table.Column<int>(nullable: true),
                    tipPlacanja = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacija", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rezervacija_Korisnik_korisnikID",
                        column: x => x.korisnikID,
                        principalTable: "Korisnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rezervacija_Tretman_odabraniTretmanID",
                        column: x => x.odabraniTretmanID,
                        principalTable: "Tretman",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FormaZaTest_klijentID",
                table: "FormaZaTest",
                column: "klijentID");

            migrationBuilder.CreateIndex(
                name: "IX_FormaZaTest_preporuceniTretmanID",
                table: "FormaZaTest",
                column: "preporuceniTretmanID");

            migrationBuilder.CreateIndex(
                name: "IX_FormaZaTretman_klijentID",
                table: "FormaZaTretman",
                column: "klijentID");

            migrationBuilder.CreateIndex(
                name: "IX_FormaZaTretman_tretmanID",
                table: "FormaZaTretman",
                column: "tretmanID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_korisnikID",
                table: "Rezervacija",
                column: "korisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_odabraniTretmanID",
                table: "Rezervacija",
                column: "odabraniTretmanID");

            migrationBuilder.CreateIndex(
                name: "IX_Tretman_KorisnikDBID",
                table: "Tretman",
                column: "KorisnikDBID");

            migrationBuilder.CreateIndex(
                name: "IX_Uplatnica_klijentID",
                table: "Uplatnica",
                column: "klijentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormaZaTest");

            migrationBuilder.DropTable(
                name: "FormaZaTretman");

            migrationBuilder.DropTable(
                name: "Izvjestaj");

            migrationBuilder.DropTable(
                name: "Rezervacija");

            migrationBuilder.DropTable(
                name: "Uplatnica");

            migrationBuilder.DropTable(
                name: "Zaposlenik");

            migrationBuilder.DropTable(
                name: "Tretman");

            migrationBuilder.DropTable(
                name: "Korisnik");
        }
    }
}
