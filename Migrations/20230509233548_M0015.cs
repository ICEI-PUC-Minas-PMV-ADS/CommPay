using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Commpay.Migrations
{
    /// <inheritdoc />
    public partial class M0015 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Usuario_IdUsuario",
                table: "Venda");

            migrationBuilder.DropIndex(
                name: "IX_Venda_IdUsuario",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Venda");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "Venda",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Venda_IdUsuario",
                table: "Venda",
                column: "IdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Usuario_IdUsuario",
                table: "Venda",
                column: "IdUsuario",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
