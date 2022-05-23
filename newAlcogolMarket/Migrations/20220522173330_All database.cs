using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace newAlcogolMarket.Migrations
{
    public partial class Alldatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Absents_CategoryofAlcogol_CategoryId",
                table: "Absents");

            migrationBuilder.DropTable(
                name: "CategoryofAlcogol");

            migrationBuilder.DropTable(
                name: "Whiskis");

            migrationBuilder.DropIndex(
                name: "IX_Absents_CategoryId",
                table: "Absents");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Wines");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Vodkas");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Snacks");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Liquors");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Cognacs");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Champagnes");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Beers");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Absents");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Wines",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "degree",
                table: "Wines",
                newName: "Degree");

            migrationBuilder.RenameColumn(
                name: "country",
                table: "Wines",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Vodkas",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "degree",
                table: "Vodkas",
                newName: "Degree");

            migrationBuilder.RenameColumn(
                name: "country",
                table: "Vodkas",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Snacks",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Liquors",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "degree",
                table: "Liquors",
                newName: "Degree");

            migrationBuilder.RenameColumn(
                name: "country",
                table: "Liquors",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Cognacs",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "degree",
                table: "Cognacs",
                newName: "Degree");

            migrationBuilder.RenameColumn(
                name: "country",
                table: "Cognacs",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Champagnes",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "degree",
                table: "Champagnes",
                newName: "Degree");

            migrationBuilder.RenameColumn(
                name: "country",
                table: "Champagnes",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Beers",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "degree",
                table: "Beers",
                newName: "Degree");

            migrationBuilder.RenameColumn(
                name: "country",
                table: "Beers",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Absents",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "degree",
                table: "Absents",
                newName: "Degree");

            migrationBuilder.RenameColumn(
                name: "country",
                table: "Absents",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Absents",
                newName: "SizeId");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Wines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DegreeId",
                table: "Wines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Size",
                table: "Wines",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "SizeId",
                table: "Wines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Vodkas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DegreeId",
                table: "Vodkas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Size",
                table: "Vodkas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "SizeId",
                table: "Vodkas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Liquors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DegreeId",
                table: "Liquors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Size",
                table: "Liquors",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "SizeId",
                table: "Liquors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Cognacs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DegreeId",
                table: "Cognacs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Size",
                table: "Cognacs",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "SizeId",
                table: "Cognacs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Champagnes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DegreeId",
                table: "Champagnes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Size",
                table: "Champagnes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "SizeId",
                table: "Champagnes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Beers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DegreeId",
                table: "Beers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Size",
                table: "Beers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "SizeId",
                table: "Beers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Absents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DegreeId",
                table: "Absents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Size",
                table: "Absents",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "Basket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basket", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recommendations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recommendations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Whiskey",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Degree = table.Column<int>(type: "int", nullable: false),
                    DegreeId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<double>(type: "float", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Whiskey", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Basket");

            migrationBuilder.DropTable(
                name: "Recommendations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Whiskey");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Wines");

            migrationBuilder.DropColumn(
                name: "DegreeId",
                table: "Wines");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Wines");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "Wines");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Vodkas");

            migrationBuilder.DropColumn(
                name: "DegreeId",
                table: "Vodkas");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Vodkas");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "Vodkas");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Liquors");

            migrationBuilder.DropColumn(
                name: "DegreeId",
                table: "Liquors");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Liquors");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "Liquors");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Cognacs");

            migrationBuilder.DropColumn(
                name: "DegreeId",
                table: "Cognacs");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Cognacs");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "Cognacs");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Champagnes");

            migrationBuilder.DropColumn(
                name: "DegreeId",
                table: "Champagnes");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Champagnes");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "Champagnes");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Beers");

            migrationBuilder.DropColumn(
                name: "DegreeId",
                table: "Beers");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Beers");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "Beers");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Absents");

            migrationBuilder.DropColumn(
                name: "DegreeId",
                table: "Absents");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Absents");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Wines",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Degree",
                table: "Wines",
                newName: "degree");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Wines",
                newName: "country");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Vodkas",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Degree",
                table: "Vodkas",
                newName: "degree");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Vodkas",
                newName: "country");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Snacks",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Liquors",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Degree",
                table: "Liquors",
                newName: "degree");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Liquors",
                newName: "country");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Cognacs",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Degree",
                table: "Cognacs",
                newName: "degree");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Cognacs",
                newName: "country");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Champagnes",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Degree",
                table: "Champagnes",
                newName: "degree");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Champagnes",
                newName: "country");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Beers",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Degree",
                table: "Beers",
                newName: "degree");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Beers",
                newName: "country");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Absents",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Degree",
                table: "Absents",
                newName: "degree");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Absents",
                newName: "country");

            migrationBuilder.RenameColumn(
                name: "SizeId",
                table: "Absents",
                newName: "CategoryId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Wines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Vodkas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Snacks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Liquors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Cognacs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Champagnes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Beers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Absents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CategoryofAlcogol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryofAlcogol", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Whiskis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    degree = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Whiskis", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Absents_CategoryId",
                table: "Absents",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Absents_CategoryofAlcogol_CategoryId",
                table: "Absents",
                column: "CategoryId",
                principalTable: "CategoryofAlcogol",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
