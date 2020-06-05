using Microsoft.EntityFrameworkCore.Migrations;

namespace Implementacija.Migrations
{
    public partial class Migracija3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacija_Tretman_odabraniTretmanID",
                table: "Rezervacija");

            migrationBuilder.DropIndex(
                name: "IX_Rezervacija_odabraniTretmanID",
                table: "Rezervacija");

            migrationBuilder.DropColumn(
                name: "odabraniTretmanID",
                table: "Rezervacija");

            migrationBuilder.AddColumn<string>(
                name: "odabraniTretman",
                table: "Rezervacija",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "odabraniTretman",
                table: "Rezervacija");

            migrationBuilder.AddColumn<int>(
                name: "odabraniTretmanID",
                table: "Rezervacija",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_odabraniTretmanID",
                table: "Rezervacija",
                column: "odabraniTretmanID");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacija_Tretman_odabraniTretmanID",
                table: "Rezervacija",
                column: "odabraniTretmanID",
                principalTable: "Tretman",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
