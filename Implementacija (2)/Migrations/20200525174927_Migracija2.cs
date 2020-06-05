using Microsoft.EntityFrameworkCore.Migrations;

namespace Implementacija.Migrations
{
    public partial class Migracija2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imeIPrezime",
                table: "Rezervacija",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imeIPrezime",
                table: "Rezervacija");
        }
    }
}
