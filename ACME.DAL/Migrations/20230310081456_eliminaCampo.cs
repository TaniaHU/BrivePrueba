using Microsoft.EntityFrameworkCore.Migrations;

namespace ACME.DAL.Migrations
{
    public partial class eliminaCampo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Sucursal");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Producto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Sucursal",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Producto",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
