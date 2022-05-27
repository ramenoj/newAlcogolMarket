using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace newAlcogolMarket.Migrations
{
    public partial class asd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Recommendations");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Basket");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Wines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Whiskey",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Vodkas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Liquors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Cognacs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Champagnes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Beers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Wines");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Whiskey");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Vodkas");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Liquors");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Cognacs");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Champagnes");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Beers");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Recommendations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Basket",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
