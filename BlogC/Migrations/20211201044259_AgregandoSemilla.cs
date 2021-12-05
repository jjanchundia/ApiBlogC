using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogC.Migrations
{
    public partial class AgregandoSemilla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Noticias",
                columns: new[] { "Id", "FechaCreacion", "FechaModificacion", "Imagen", "Texto", "Titulo" },
                values: new object[] { new Guid("05f4f68e-9bb1-4e36-836c-0a9daec8736a"), new DateTime(2021, 11, 30, 23, 42, 59, 162, DateTimeKind.Local).AddTicks(8842), new DateTime(2021, 11, 30, 23, 42, 59, 164, DateTimeKind.Local).AddTicks(1733), "Imagenes/image1.png", "Texto de Prueba para blog de noticias", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Noticias",
                keyColumn: "Id",
                keyValue: new Guid("05f4f68e-9bb1-4e36-836c-0a9daec8736a"));
        }
    }
}
