using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Commpay.Migrations
{
    /// <inheritdoc />
    public partial class M009 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Usuario_UsuarioId",
                table: "Venda");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Venda",
                newName: "IdUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_Venda_UsuarioId",
                table: "Venda",
                newName: "IX_Venda_IdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Usuario_IdUsuario",
                table: "Venda",
                column: "IdUsuario",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Usuario_IdUsuario",
                table: "Venda");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Venda",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Venda_IdUsuario",
                table: "Venda",
                newName: "IX_Venda_UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Usuario_UsuarioId",
                table: "Venda",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
