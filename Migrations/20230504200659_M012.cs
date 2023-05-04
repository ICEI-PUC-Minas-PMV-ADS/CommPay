using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Commpay.Migrations
{
    /// <inheritdoc />
    public partial class M012 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "Venda",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "Venda");

        }
    }
}
