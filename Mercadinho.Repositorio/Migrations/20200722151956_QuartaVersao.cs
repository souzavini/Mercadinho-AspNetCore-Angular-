using Microsoft.EntityFrameworkCore.Migrations;

namespace Mercadinho.Repositorio.Migrations
{
    public partial class QuartaVersao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "Vendas",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Vendas");
        }
    }
}
