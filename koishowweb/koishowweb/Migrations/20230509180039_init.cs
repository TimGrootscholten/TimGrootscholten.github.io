using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace koishowweb.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vat",
                columns: table => new
                {
                    VatId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VatName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestedTemperature = table.Column<double>(type: "float", nullable: false),
                    Capacity = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vat", x => x.VatId);
                });

            migrationBuilder.CreateTable(
                name: "Sensor",
                columns: table => new
                {
                    SensorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Offset = table.Column<double>(type: "float", nullable: false),
                    ColorCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SensorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VatId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sensor", x => x.SensorId);
                    table.ForeignKey(
                        name: "FK_Sensor_Vat_VatId",
                        column: x => x.VatId,
                        principalTable: "Vat",
                        principalColumn: "VatId");
                });

            migrationBuilder.CreateTable(
                name: "Temperature",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SensorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Temperatur = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temperature", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Temperature_Sensor_SensorId",
                        column: x => x.SensorId,
                        principalTable: "Sensor",
                        principalColumn: "SensorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sensor_VatId",
                table: "Sensor",
                column: "VatId");

            migrationBuilder.CreateIndex(
                name: "IX_Temperature_SensorId",
                table: "Temperature",
                column: "SensorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Temperature");

            migrationBuilder.DropTable(
                name: "Sensor");

            migrationBuilder.DropTable(
                name: "Vat");
        }
    }
}
