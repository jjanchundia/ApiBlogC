using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogC.Migrations
{
    public partial class modificaVariables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Texto",
                table: "Noticias",
                newName: "Content");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Noticias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Noticias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Noticias",
                keyColumn: "Id",
                keyValue: new Guid("05f4f68e-9bb1-4e36-836c-0a9daec8736a"),
                columns: new[] { "Content", "FechaCreacion", "FechaModificacion" },
                values: new object[] { null, new DateTime(2021, 12, 2, 1, 2, 54, 557, DateTimeKind.Local).AddTicks(9480), new DateTime(2021, 12, 2, 1, 2, 54, 559, DateTimeKind.Local).AddTicks(2297) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Noticias");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Noticias");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Noticias",
                newName: "Texto");

            migrationBuilder.UpdateData(
                table: "Noticias",
                keyColumn: "Id",
                keyValue: new Guid("05f4f68e-9bb1-4e36-836c-0a9daec8736a"),
                columns: new[] { "FechaCreacion", "FechaModificacion", "Texto" },
                values: new object[] { new DateTime(2021, 11, 30, 23, 45, 37, 3, DateTimeKind.Local).AddTicks(2433), new DateTime(2021, 11, 30, 23, 45, 37, 4, DateTimeKind.Local).AddTicks(3724), "Texto de Prueba para blog de noticias" });
        }
    }
}
