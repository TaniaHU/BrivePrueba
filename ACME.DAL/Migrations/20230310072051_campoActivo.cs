using Microsoft.EntityFrameworkCore.Migrations;

namespace ACME.DAL.Migrations
{
    public partial class campoActivo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Sucursal",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Producto",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Sucursal");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Producto");
        }
    }
}
