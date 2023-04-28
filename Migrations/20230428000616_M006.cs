using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Commpay.Migrations
{
    /// <inheritdoc />
    public partial class M006 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Usuario_Id_Usuario",
                table: "Venda");

            migrationBuilder.DropIndex(
                name: "IX_Venda_Id_Usuario",
                table: "Venda");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Venda",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Venda_UsuarioId",
                table: "Venda",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Usuario_UsuarioId",
                table: "Venda",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Usuario_UsuarioId",
                table: "Venda");

            migrationBuilder.DropIndex(
                name: "IX_Venda_UsuarioId",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Venda");

            migrationBuilder.CreateIndex(
                name: "IX_Venda_Id_Usuario",
                table: "Venda",
                column: "Id_Usuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Usuario_Id_Usuario",
                table: "Venda",
                column: "Id_Usuario",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
