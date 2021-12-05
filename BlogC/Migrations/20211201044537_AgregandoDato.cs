using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogC.Migrations
{
    public partial class AgregandoDato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Noticias",
                keyColumn: "Id",
                keyValue: new Guid("05f4f68e-9bb1-4e36-836c-0a9daec8736a"),
                columns: new[] { "FechaCreacion", "FechaModificacion", "Titulo" },
                values: new object[] { new DateTime(2021, 11, 30, 23, 45, 37, 3, DateTimeKind.Local).AddTicks(2433), new DateTime(2021, 11, 30, 23, 45, 37, 4, DateTimeKind.Local).AddTicks(3724), "Texto de Prueba" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Noticias",
                keyColumn: "Id",
                keyValue: new Guid("05f4f68e-9bb1-4e36-836c-0a9daec8736a"),
                columns: new[] { "FechaCreacion", "FechaModificacion", "Titulo" },
                values: new object[] { new DateTime(2021, 11, 30, 23, 42, 59, 162, DateTimeKind.Local).AddTicks(8842), new DateTime(2021, 11, 30, 23, 42, 59, 164, DateTimeKind.Local).AddTicks(1733), "" });
        }
    }
}
