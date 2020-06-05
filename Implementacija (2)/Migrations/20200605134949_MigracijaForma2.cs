using Microsoft.EntityFrameworkCore.Migrations;

namespace Implementacija.Migrations
{
    public partial class MigracijaForma2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormaZaTretman_Korisnik_klijentID",
                table: "FormaZaTretman");

            migrationBuilder.DropForeignKey(
                name: "FK_FormaZaTretman_Tretman_tretmanID",
                table: "FormaZaTretman");

            migrationBuilder.DropIndex(
                name: "IX_FormaZaTretman_klijentID",
                table: "FormaZaTretman");

            migrationBuilder.DropIndex(
                name: "IX_FormaZaTretman_tretmanID",
                table: "FormaZaTretman");

            migrationBuilder.DropColumn(
                name: "klijentID",
                table: "FormaZaTretman");

            migrationBuilder.DropColumn(
                name: "opisRezultata",
                table: "FormaZaTretman");

            migrationBuilder.DropColumn(
                name: "tretmanID",
                table: "FormaZaTretman");

            migrationBuilder.AddColumn<string>(
                name: "dodatneNapomene",
                table: "FormaZaTretman",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "klijent",
                table: "FormaZaTretman",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "odabranaZona",
                table: "FormaZaTretman",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "rezultatTretmana",
                table: "FormaZaTretman",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tehnikaRada",
                table: "FormaZaTretman",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tretman",
                table: "FormaZaTretman",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dodatneNapomene",
                table: "FormaZaTretman");

            migrationBuilder.DropColumn(
                name: "klijent",
                table: "FormaZaTretman");

            migrationBuilder.DropColumn(
                name: "odabranaZona",
                table: "FormaZaTretman");

            migrationBuilder.DropColumn(
                name: "rezultatTretmana",
                table: "FormaZaTretman");

            migrationBuilder.DropColumn(
                name: "tehnikaRada",
                table: "FormaZaTretman");

            migrationBuilder.DropColumn(
                name: "tretman",
                table: "FormaZaTretman");

            migrationBuilder.AddColumn<int>(
                name: "klijentID",
                table: "FormaZaTretman",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "opisRezultata",
                table: "FormaZaTretman",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tretmanID",
                table: "FormaZaTretman",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FormaZaTretman_klijentID",
                table: "FormaZaTretman",
                column: "klijentID");

            migrationBuilder.CreateIndex(
                name: "IX_FormaZaTretman_tretmanID",
                table: "FormaZaTretman",
                column: "tretmanID");

            migrationBuilder.AddForeignKey(
                name: "FK_FormaZaTretman_Korisnik_klijentID",
                table: "FormaZaTretman",
                column: "klijentID",
                principalTable: "Korisnik",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FormaZaTretman_Tretman_tretmanID",
                table: "FormaZaTretman",
                column: "tretmanID",
                principalTable: "Tretman",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
