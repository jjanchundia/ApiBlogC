using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogC.Migrations
{
    public partial class tableUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Correo = table.Column<string>(type: "varchar(MAX)", nullable: true),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: true),
                    Password = table.Column<string>(type: "varchar(MAX)", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Noticias",
                keyColumn: "Id",
                keyValue: new Guid("05f4f68e-9bb1-4e36-836c-0a9daec8736a"),
                columns: new[] { "FechaCreacion", "FechaModificacion" },
                values: new object[] { new DateTime(2021, 12, 3, 22, 8, 44, 1, DateTimeKind.Local).AddTicks(8521), new DateTime(2021, 12, 3, 22, 8, 44, 3, DateTimeKind.Local).AddTicks(1045) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.UpdateData(
                table: "Noticias",
                keyColumn: "Id",
                keyValue: new Guid("05f4f68e-9bb1-4e36-836c-0a9daec8736a"),
                columns: new[] { "FechaCreacion", "FechaModificacion" },
                values: new object[] { new DateTime(2021, 12, 2, 1, 56, 14, 622, DateTimeKind.Local).AddTicks(8792), new DateTime(2021, 12, 2, 1, 56, 14, 624, DateTimeKind.Local).AddTicks(308) });
        }
    }
}
