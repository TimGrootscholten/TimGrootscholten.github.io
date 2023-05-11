using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace koishowweb.Migrations
{
    public partial class typo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Temperatur",
                table: "Temperature",
                newName: "Temperature");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Temperature",
                table: "Temperature",
                newName: "Temperatur");
        }
    }
}
