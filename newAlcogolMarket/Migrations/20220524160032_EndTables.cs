using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace newAlcogolMarket.Migrations
{
    public partial class EndTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Absents_Country_CountryId",
                table: "Absents");

            migrationBuilder.DropForeignKey(
                name: "FK_Absents_Fortress_FortressId",
                table: "Absents");

            migrationBuilder.DropForeignKey(
                name: "FK_Absents_Size_SizeId",
                table: "Absents");

            migrationBuilder.DropTable(
                name: "Fortress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Size",
                table: "Size");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Wines");

            migrationBuilder.DropColumn(
                name: "Degree",
                table: "Wines");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Wines");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Whiskey");

            migrationBuilder.DropColumn(
                name: "Degree",
                table: "Whiskey");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Whiskey");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Vodkas");

            migrationBuilder.DropColumn(
                name: "Degree",
                table: "Vodkas");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Vodkas");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Cognacs");

            migrationBuilder.DropColumn(
                name: "Degree",
                table: "Cognacs");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Cognacs");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Champagnes");

            migrationBuilder.DropColumn(
                name: "Degree",
                table: "Champagnes");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Champagnes");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Beers");

            migrationBuilder.DropColumn(
                name: "Degree",
                table: "Beers");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Beers");

            migrationBuilder.RenameTable(
                name: "Size",
                newName: "Sizes");

            migrationBuilder.RenameTable(
                name: "Country",
                newName: "Сountries");

            migrationBuilder.RenameColumn(
                name: "DegreeId",
                table: "Wines",
                newName: "StrengthId");

            migrationBuilder.RenameColumn(
                name: "DegreeId",
                table: "Whiskey",
                newName: "StrengthId");

            migrationBuilder.RenameColumn(
                name: "DegreeId",
                table: "Vodkas",
                newName: "StrengthId");

            migrationBuilder.RenameColumn(
                name: "DegreeId",
                table: "Cognacs",
                newName: "FortressId");

            migrationBuilder.RenameColumn(
                name: "DegreeId",
                table: "Champagnes",
                newName: "FortressId");

            migrationBuilder.RenameColumn(
                name: "DegreeId",
                table: "Beers",
                newName: "FortressId");

            migrationBuilder.RenameColumn(
                name: "FortressId",
                table: "Absents",
                newName: "StrengthId");

            migrationBuilder.RenameIndex(
                name: "IX_Absents_FortressId",
                table: "Absents",
                newName: "IX_Absents_StrengthId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sizes",
                table: "Sizes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Сountries",
                table: "Сountries",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Strengths",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Degree = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Strengths", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Wines_CountryId",
                table: "Wines",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Wines_SizeId",
                table: "Wines",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Wines_StrengthId",
                table: "Wines",
                column: "StrengthId");

            migrationBuilder.CreateIndex(
                name: "IX_Whiskey_CountryId",
                table: "Whiskey",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Whiskey_SizeId",
                table: "Whiskey",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Whiskey_StrengthId",
                table: "Whiskey",
                column: "StrengthId");

            migrationBuilder.CreateIndex(
                name: "IX_Vodkas_CountryId",
                table: "Vodkas",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Vodkas_SizeId",
                table: "Vodkas",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vodkas_StrengthId",
                table: "Vodkas",
                column: "StrengthId");

            migrationBuilder.CreateIndex(
                name: "IX_Cognacs_CountryId",
                table: "Cognacs",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cognacs_FortressId",
                table: "Cognacs",
                column: "FortressId");

            migrationBuilder.CreateIndex(
                name: "IX_Cognacs_SizeId",
                table: "Cognacs",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Champagnes_CountryId",
                table: "Champagnes",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Champagnes_FortressId",
                table: "Champagnes",
                column: "FortressId");

            migrationBuilder.CreateIndex(
                name: "IX_Champagnes_SizeId",
                table: "Champagnes",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Beers_CountryId",
                table: "Beers",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Beers_FortressId",
                table: "Beers",
                column: "FortressId");

            migrationBuilder.CreateIndex(
                name: "IX_Beers_SizeId",
                table: "Beers",
                column: "SizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Absents_Сountries_CountryId",
                table: "Absents",
                column: "CountryId",
                principalTable: "Сountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Absents_Sizes_SizeId",
                table: "Absents",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Absents_Strengths_StrengthId",
                table: "Absents",
                column: "StrengthId",
                principalTable: "Strengths",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Beers_Сountries_CountryId",
                table: "Beers",
                column: "CountryId",
                principalTable: "Сountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Beers_Sizes_SizeId",
                table: "Beers",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Beers_Strengths_FortressId",
                table: "Beers",
                column: "FortressId",
                principalTable: "Strengths",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Champagnes_Сountries_CountryId",
                table: "Champagnes",
                column: "CountryId",
                principalTable: "Сountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Champagnes_Sizes_SizeId",
                table: "Champagnes",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Champagnes_Strengths_FortressId",
                table: "Champagnes",
                column: "FortressId",
                principalTable: "Strengths",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cognacs_Сountries_CountryId",
                table: "Cognacs",
                column: "CountryId",
                principalTable: "Сountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cognacs_Sizes_SizeId",
                table: "Cognacs",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cognacs_Strengths_FortressId",
                table: "Cognacs",
                column: "FortressId",
                principalTable: "Strengths",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vodkas_Сountries_CountryId",
                table: "Vodkas",
                column: "CountryId",
                principalTable: "Сountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vodkas_Sizes_SizeId",
                table: "Vodkas",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vodkas_Strengths_StrengthId",
                table: "Vodkas",
                column: "StrengthId",
                principalTable: "Strengths",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Whiskey_Сountries_CountryId",
                table: "Whiskey",
                column: "CountryId",
                principalTable: "Сountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Whiskey_Sizes_SizeId",
                table: "Whiskey",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Whiskey_Strengths_StrengthId",
                table: "Whiskey",
                column: "StrengthId",
                principalTable: "Strengths",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wines_Сountries_CountryId",
                table: "Wines",
                column: "CountryId",
                principalTable: "Сountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wines_Sizes_SizeId",
                table: "Wines",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wines_Strengths_StrengthId",
                table: "Wines",
                column: "StrengthId",
                principalTable: "Strengths",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Absents_Сountries_CountryId",
                table: "Absents");

            migrationBuilder.DropForeignKey(
                name: "FK_Absents_Sizes_SizeId",
                table: "Absents");

            migrationBuilder.DropForeignKey(
                name: "FK_Absents_Strengths_StrengthId",
                table: "Absents");

            migrationBuilder.DropForeignKey(
                name: "FK_Beers_Сountries_CountryId",
                table: "Beers");

            migrationBuilder.DropForeignKey(
                name: "FK_Beers_Sizes_SizeId",
                table: "Beers");

            migrationBuilder.DropForeignKey(
                name: "FK_Beers_Strengths_FortressId",
                table: "Beers");

            migrationBuilder.DropForeignKey(
                name: "FK_Champagnes_Сountries_CountryId",
                table: "Champagnes");

            migrationBuilder.DropForeignKey(
                name: "FK_Champagnes_Sizes_SizeId",
                table: "Champagnes");

            migrationBuilder.DropForeignKey(
                name: "FK_Champagnes_Strengths_FortressId",
                table: "Champagnes");

            migrationBuilder.DropForeignKey(
                name: "FK_Cognacs_Сountries_CountryId",
                table: "Cognacs");

            migrationBuilder.DropForeignKey(
                name: "FK_Cognacs_Sizes_SizeId",
                table: "Cognacs");

            migrationBuilder.DropForeignKey(
                name: "FK_Cognacs_Strengths_FortressId",
                table: "Cognacs");

            migrationBuilder.DropForeignKey(
                name: "FK_Vodkas_Сountries_CountryId",
                table: "Vodkas");

            migrationBuilder.DropForeignKey(
                name: "FK_Vodkas_Sizes_SizeId",
                table: "Vodkas");

            migrationBuilder.DropForeignKey(
                name: "FK_Vodkas_Strengths_StrengthId",
                table: "Vodkas");

            migrationBuilder.DropForeignKey(
                name: "FK_Whiskey_Сountries_CountryId",
                table: "Whiskey");

            migrationBuilder.DropForeignKey(
                name: "FK_Whiskey_Sizes_SizeId",
                table: "Whiskey");

            migrationBuilder.DropForeignKey(
                name: "FK_Whiskey_Strengths_StrengthId",
                table: "Whiskey");

            migrationBuilder.DropForeignKey(
                name: "FK_Wines_Сountries_CountryId",
                table: "Wines");

            migrationBuilder.DropForeignKey(
                name: "FK_Wines_Sizes_SizeId",
                table: "Wines");

            migrationBuilder.DropForeignKey(
                name: "FK_Wines_Strengths_StrengthId",
                table: "Wines");

            migrationBuilder.DropTable(
                name: "Strengths");

            migrationBuilder.DropIndex(
                name: "IX_Wines_CountryId",
                table: "Wines");

            migrationBuilder.DropIndex(
                name: "IX_Wines_SizeId",
                table: "Wines");

            migrationBuilder.DropIndex(
                name: "IX_Wines_StrengthId",
                table: "Wines");

            migrationBuilder.DropIndex(
                name: "IX_Whiskey_CountryId",
                table: "Whiskey");

            migrationBuilder.DropIndex(
                name: "IX_Whiskey_SizeId",
                table: "Whiskey");

            migrationBuilder.DropIndex(
                name: "IX_Whiskey_StrengthId",
                table: "Whiskey");

            migrationBuilder.DropIndex(
                name: "IX_Vodkas_CountryId",
                table: "Vodkas");

            migrationBuilder.DropIndex(
                name: "IX_Vodkas_SizeId",
                table: "Vodkas");

            migrationBuilder.DropIndex(
                name: "IX_Vodkas_StrengthId",
                table: "Vodkas");

            migrationBuilder.DropIndex(
                name: "IX_Cognacs_CountryId",
                table: "Cognacs");

            migrationBuilder.DropIndex(
                name: "IX_Cognacs_FortressId",
                table: "Cognacs");

            migrationBuilder.DropIndex(
                name: "IX_Cognacs_SizeId",
                table: "Cognacs");

            migrationBuilder.DropIndex(
                name: "IX_Champagnes_CountryId",
                table: "Champagnes");

            migrationBuilder.DropIndex(
                name: "IX_Champagnes_FortressId",
                table: "Champagnes");

            migrationBuilder.DropIndex(
                name: "IX_Champagnes_SizeId",
                table: "Champagnes");

            migrationBuilder.DropIndex(
                name: "IX_Beers_CountryId",
                table: "Beers");

            migrationBuilder.DropIndex(
                name: "IX_Beers_FortressId",
                table: "Beers");

            migrationBuilder.DropIndex(
                name: "IX_Beers_SizeId",
                table: "Beers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sizes",
                table: "Sizes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Сountries",
                table: "Сountries");

            migrationBuilder.RenameTable(
                name: "Sizes",
                newName: "Size");

            migrationBuilder.RenameTable(
                name: "Сountries",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "StrengthId",
                table: "Wines",
                newName: "DegreeId");

            migrationBuilder.RenameColumn(
                name: "StrengthId",
                table: "Whiskey",
                newName: "DegreeId");

            migrationBuilder.RenameColumn(
                name: "StrengthId",
                table: "Vodkas",
                newName: "DegreeId");

            migrationBuilder.RenameColumn(
                name: "FortressId",
                table: "Cognacs",
                newName: "DegreeId");

            migrationBuilder.RenameColumn(
                name: "FortressId",
                table: "Champagnes",
                newName: "DegreeId");

            migrationBuilder.RenameColumn(
                name: "FortressId",
                table: "Beers",
                newName: "DegreeId");

            migrationBuilder.RenameColumn(
                name: "StrengthId",
                table: "Absents",
                newName: "FortressId");

            migrationBuilder.RenameIndex(
                name: "IX_Absents_StrengthId",
                table: "Absents",
                newName: "IX_Absents_FortressId");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Wines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Degree",
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

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Whiskey",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Degree",
                table: "Whiskey",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Size",
                table: "Whiskey",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Vodkas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Degree",
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

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Cognacs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Degree",
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

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Champagnes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Degree",
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

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Beers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Degree",
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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Size",
                table: "Size",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                table: "Country",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Fortress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Degree = table.Column<double>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fortress", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Absents_Country_CountryId",
                table: "Absents",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Absents_Fortress_FortressId",
                table: "Absents",
                column: "FortressId",
                principalTable: "Fortress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Absents_Size_SizeId",
                table: "Absents",
                column: "SizeId",
                principalTable: "Size",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
