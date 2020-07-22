using Microsoft.EntityFrameworkCore.Migrations;

namespace Mercadinho.Repositorio.Migrations
{
    public partial class SegundaVersão : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomeProduto",
                table: "Produtos",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeProduto",
                table: "Produtos");
        }
    }
}
