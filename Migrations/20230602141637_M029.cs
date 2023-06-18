using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Commpay.Migrations
{
    /// <inheritdoc />
    public partial class M029 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemVenda_Produto_IdProduto",
                table: "ItemVenda");

            migrationBuilder.RenameColumn(
                name: "IdProduto",
                table: "ItemVenda",
                newName: "ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemVenda_IdProduto",
                table: "ItemVenda",
                newName: "IX_ItemVenda_ProdutoId");

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemVenda_Produto_ProdutoId",
                table: "ItemVenda",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemVenda_Produto_ProdutoId",
                table: "ItemVenda");

            migrationBuilder.RenameColumn(
                name: "ProdutoId",
                table: "ItemVenda",
                newName: "IdProduto");

            migrationBuilder.RenameIndex(
                name: "IX_ItemVenda_ProdutoId",
                table: "ItemVenda",
                newName: "IX_ItemVenda_IdProduto");

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Usuario",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemVenda_Produto_IdProduto",
                table: "ItemVenda",
                column: "IdProduto",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
