using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prueba_Tecnica.Migrations
{
    /// <inheritdoc />
    public partial class RemoveRequiredFromModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2024, 12, 22, 22, 5, 7, 934, DateTimeKind.Local).AddTicks(5863), new DateTime(2024, 12, 22, 22, 5, 7, 931, DateTimeKind.Local).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2024, 12, 22, 22, 5, 7, 934, DateTimeKind.Local).AddTicks(6097), new DateTime(2024, 12, 22, 22, 5, 7, 934, DateTimeKind.Local).AddTicks(6096) });
        }
    }
}
