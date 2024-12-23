using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prueba_Tecnica.Migrations
{
    /// <inheritdoc />
    public partial class removeRequiredModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2024, 12, 23, 8, 43, 23, 395, DateTimeKind.Local).AddTicks(4495), new DateTime(2024, 12, 23, 8, 43, 23, 392, DateTimeKind.Local).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2024, 12, 23, 8, 43, 23, 395, DateTimeKind.Local).AddTicks(4722), new DateTime(2024, 12, 23, 8, 43, 23, 395, DateTimeKind.Local).AddTicks(4720) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2024, 12, 23, 8, 41, 33, 620, DateTimeKind.Local).AddTicks(3514), new DateTime(2024, 12, 23, 8, 41, 33, 617, DateTimeKind.Local).AddTicks(6087) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2024, 12, 23, 8, 41, 33, 620, DateTimeKind.Local).AddTicks(3759), new DateTime(2024, 12, 23, 8, 41, 33, 620, DateTimeKind.Local).AddTicks(3757) });
        }
    }
}
