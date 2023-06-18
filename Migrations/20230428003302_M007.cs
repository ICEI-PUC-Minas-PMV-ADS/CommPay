using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Commpay.Migrations
{
    /// <inheritdoc />
    public partial class M007 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Venda_VendaId",
                table: "Venda");

            migrationBuilder.DropIndex(
                name: "IX_Venda_VendaId",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "Id_Usuario",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "VendaId",
                table: "Venda");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id_Usuario",
                table: "Venda",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VendaId",
                table: "Venda",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Venda_VendaId",
                table: "Venda",
                column: "VendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Venda_VendaId",
                table: "Venda",
                column: "VendaId",
                principalTable: "Venda",
                principalColumn: "Id");
        }
    }
}
