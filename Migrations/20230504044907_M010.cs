using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Commpay.Migrations
{
    /// <inheritdoc />
    public partial class M010 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Produto_ProdutoId",
                table: "Produto");
        }
    }
}
