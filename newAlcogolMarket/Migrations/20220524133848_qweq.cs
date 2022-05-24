using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace newAlcogolMarket.Migrations
{
    public partial class qweq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Basket",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Basket");
        }
    }
}
