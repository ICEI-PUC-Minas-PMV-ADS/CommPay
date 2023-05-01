using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Commpay.Migrations
{
    /// <inheritdoc />
    public partial class M008 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemVenda_Produto_Id_Produto",
                table: "ItemVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemVenda_Venda_Id_Venda",
                table: "ItemVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Usuario_UsuarioId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_UsuarioId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Usuario");

            migrationBuilder.RenameColumn(
                name: "Id_Venda",
                table: "ItemVenda",
                newName: "IdVenda");

            migrationBuilder.RenameColumn(
                name: "Id_Produto",
                table: "ItemVenda",
                newName: "IdProduto");

            migrationBuilder.RenameIndex(
                name: "IX_ItemVenda_Id_Venda",
                table: "ItemVenda",
                newName: "IX_ItemVenda_IdVenda");

            migrationBuilder.RenameIndex(
                name: "IX_ItemVenda_Id_Produto",
                table: "ItemVenda",
                newName: "IX_ItemVenda_IdProduto");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemVenda_Produto_IdProduto",
                table: "ItemVenda",
                column: "IdProduto",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemVenda_Venda_IdVenda",
                table: "ItemVenda",
                column: "IdVenda",
                principalTable: "Venda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemVenda_Produto_IdProduto",
                table: "ItemVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemVenda_Venda_IdVenda",
                table: "ItemVenda");

            migrationBuilder.RenameColumn(
                name: "IdVenda",
                table: "ItemVenda",
                newName: "Id_Venda");

            migrationBuilder.RenameColumn(
                name: "IdProduto",
                table: "ItemVenda",
                newName: "Id_Produto");

            migrationBuilder.RenameIndex(
                name: "IX_ItemVenda_IdVenda",
                table: "ItemVenda",
                newName: "IX_ItemVenda_Id_Venda");

            migrationBuilder.RenameIndex(
                name: "IX_ItemVenda_IdProduto",
                table: "ItemVenda",
                newName: "IX_ItemVenda_Id_Produto");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Usuario",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_UsuarioId",
                table: "Usuario",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemVenda_Produto_Id_Produto",
                table: "ItemVenda",
                column: "Id_Produto",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemVenda_Venda_Id_Venda",
                table: "ItemVenda",
                column: "Id_Venda",
                principalTable: "Venda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Usuario_UsuarioId",
                table: "Usuario",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id");
        }
    }
}
