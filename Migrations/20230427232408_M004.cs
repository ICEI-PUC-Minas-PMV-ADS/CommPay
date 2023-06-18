using System;
using Microsoft.EntityFrameworkCore.Migrations;
#nullable disable
namespace Commpay.Migrations
{
    /// <inheritdoc />
    public partial class M004 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Usuario",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "Produto",
                type: "int",
                nullable: true);


            migrationBuilder.CreateTable(
                name: "Venda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vendedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data_Compra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Valor_Total = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Entregador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data_Entrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VendaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Venda_Venda_VendaId",
                        column: x => x.VendaId,
                        principalTable: "Venda",
                        principalColumn: "Id");
                });
            migrationBuilder.CreateTable(
                name: "ItemVenda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Id_Venda = table.Column<int>(type: "int", nullable: false),
                    Id_Produto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemVenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemVenda_Produto_Id_Produto",
                        column: x => x.Id_Produto,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemVenda_Venda_Id_Venda",
                        column: x => x.Id_Venda,
                        principalTable: "Venda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produto_ProdutoId",
                table: "Produto",
                column: "ProdutoId");


            migrationBuilder.CreateIndex(
                name: "IX_ItemVenda_Id_Produto",
                table: "ItemVenda",
                column: "Id_Produto");
            migrationBuilder.CreateIndex(
                name: "IX_ItemVenda_Id_Venda",
                table: "ItemVenda",
                column: "Id_Venda");
            migrationBuilder.CreateIndex(
                name: "IX_Venda_VendaId",
                table: "Venda",
                column: "VendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Produto_ProdutoId",
                table: "Produto",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Produto_ProdutoId",
                table: "Produto");
            {

                migrationBuilder.DropTable(
                    name: "ItemVenda");

                migrationBuilder.DropTable(
                    name: "Venda");

                migrationBuilder.DropIndex(
                    name: "IX_Produto_ProdutoId",
                    table: "Produto");

                migrationBuilder.DropColumn(
                    name: "ProdutoId",
                    table: "Produto");



                migrationBuilder.AlterColumn<string>(
                    name: "Cpf",
                    table: "Usuario",
                    type: "nvarchar(max)",
                    nullable: false,
                    oldClrType: typeof(string),
                    oldType: "nvarchar(11)",
                    oldMaxLength: 11);
            }
        }
    }
}