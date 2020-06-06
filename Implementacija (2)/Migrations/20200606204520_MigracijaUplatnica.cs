using Microsoft.EntityFrameworkCore.Migrations;

namespace Implementacija.Migrations
{
    public partial class MigracijaUplatnica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Uplatnica_Korisnik_klijentID",
                table: "Uplatnica");

            migrationBuilder.DropIndex(
                name: "IX_Uplatnica_klijentID",
                table: "Uplatnica");

            migrationBuilder.DropColumn(
                name: "klijentID",
                table: "Uplatnica");

            migrationBuilder.AddColumn<string>(
                name: "klijent",
                table: "Uplatnica",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "klijent",
                table: "Uplatnica");

            migrationBuilder.AddColumn<int>(
                name: "klijentID",
                table: "Uplatnica",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Uplatnica_klijentID",
                table: "Uplatnica",
                column: "klijentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Uplatnica_Korisnik_klijentID",
                table: "Uplatnica",
                column: "klijentID",
                principalTable: "Korisnik",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
