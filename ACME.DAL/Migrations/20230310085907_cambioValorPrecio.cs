using Microsoft.EntityFrameworkCore.Migrations;

namespace ACME.DAL.Migrations
{
    public partial class cambioValorPrecio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "PrecioUnitario",
                table: "Producto",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "PrecioUnitario",
                table: "Producto",
                type: "bit",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
