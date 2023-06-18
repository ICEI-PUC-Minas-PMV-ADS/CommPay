using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Commpay.Migrations
{
    /// <inheritdoc />
    public partial class M011 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Produto_ProdutoId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
               name: "FK_Produto_Produto_ProdutoId",
               table: "Produto");

            migrationBuilder.DropColumn(
                  name: "ProdutoId",
                  table: "Produto");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
