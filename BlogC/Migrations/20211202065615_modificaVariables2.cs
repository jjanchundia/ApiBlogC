using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogC.Migrations
{
    public partial class modificaVariables2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Noticias",
                type: "varchar(MAX)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Imagen",
                table: "Noticias",
                type: "varchar(MAX)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Noticias",
                type: "varchar(MAX)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Noticias",
                keyColumn: "Id",
                keyValue: new Guid("05f4f68e-9bb1-4e36-836c-0a9daec8736a"),
                columns: new[] { "FechaCreacion", "FechaModificacion" },
                values: new object[] { new DateTime(2021, 12, 2, 1, 56, 14, 622, DateTimeKind.Local).AddTicks(8792), new DateTime(2021, 12, 2, 1, 56, 14, 624, DateTimeKind.Local).AddTicks(308) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Noticias",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(MAX)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Imagen",
                table: "Noticias",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(MAX)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Noticias",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(MAX)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Noticias",
                keyColumn: "Id",
                keyValue: new Guid("05f4f68e-9bb1-4e36-836c-0a9daec8736a"),
                columns: new[] { "FechaCreacion", "FechaModificacion" },
                values: new object[] { new DateTime(2021, 12, 2, 1, 2, 54, 557, DateTimeKind.Local).AddTicks(9480), new DateTime(2021, 12, 2, 1, 2, 54, 559, DateTimeKind.Local).AddTicks(2297) });
        }
    }
}
