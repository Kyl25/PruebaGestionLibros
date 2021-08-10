using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionLibros.Migrations
{
    public partial class migracionSegunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LibroId",
                table: "VentaLibro",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VentaLibro_LibroId",
                table: "VentaLibro",
                column: "LibroId");

            migrationBuilder.AddForeignKey(
                name: "FK_VentaLibro_Libro_LibroId",
                table: "VentaLibro",
                column: "LibroId",
                principalTable: "Libro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VentaLibro_Libro_LibroId",
                table: "VentaLibro");

            migrationBuilder.DropIndex(
                name: "IX_VentaLibro_LibroId",
                table: "VentaLibro");

            migrationBuilder.DropColumn(
                name: "LibroId",
                table: "VentaLibro");
        }
    }
}
