using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBookSpotData.Migrations
{
    public partial class CapitalizeBookPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "price",
                table: "Books",
                newName: "Price");

            migrationBuilder.AddColumn<decimal>(
                name: "_price",
                table: "Books",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "_price",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Books",
                newName: "price");
        }
    }
}
