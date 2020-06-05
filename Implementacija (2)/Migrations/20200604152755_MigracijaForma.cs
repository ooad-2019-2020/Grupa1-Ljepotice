using Microsoft.EntityFrameworkCore.Migrations;

namespace Implementacija.Migrations
{
    public partial class MigracijaForma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormaZaTest_Korisnik_klijentID",
                table: "FormaZaTest");

            migrationBuilder.DropForeignKey(
                name: "FK_FormaZaTest_Tretman_preporuceniTretmanID",
                table: "FormaZaTest");

            migrationBuilder.DropIndex(
                name: "IX_FormaZaTest_klijentID",
                table: "FormaZaTest");

            migrationBuilder.DropIndex(
                name: "IX_FormaZaTest_preporuceniTretmanID",
                table: "FormaZaTest");

            migrationBuilder.DropColumn(
                name: "klijentID",
                table: "FormaZaTest");

            migrationBuilder.DropColumn(
                name: "preporuceniTretmanID",
                table: "FormaZaTest");

            migrationBuilder.AddColumn<string>(
                name: "klijent",
                table: "FormaZaTest",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "odabranaZona",
                table: "FormaZaTest",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "rezultat",
                table: "FormaZaTest",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "klijent",
                table: "FormaZaTest");

            migrationBuilder.DropColumn(
                name: "odabranaZona",
                table: "FormaZaTest");

            migrationBuilder.DropColumn(
                name: "rezultat",
                table: "FormaZaTest");

            migrationBuilder.AddColumn<int>(
                name: "klijentID",
                table: "FormaZaTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "preporuceniTretmanID",
                table: "FormaZaTest",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FormaZaTest_klijentID",
                table: "FormaZaTest",
                column: "klijentID");

            migrationBuilder.CreateIndex(
                name: "IX_FormaZaTest_preporuceniTretmanID",
                table: "FormaZaTest",
                column: "preporuceniTretmanID");

            migrationBuilder.AddForeignKey(
                name: "FK_FormaZaTest_Korisnik_klijentID",
                table: "FormaZaTest",
                column: "klijentID",
                principalTable: "Korisnik",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FormaZaTest_Tretman_preporuceniTretmanID",
                table: "FormaZaTest",
                column: "preporuceniTretmanID",
                principalTable: "Tretman",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
