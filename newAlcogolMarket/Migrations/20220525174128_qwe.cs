using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace newAlcogolMarket.Migrations
{
    public partial class qwe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beers_Strengths_FortressId",
                table: "Beers");

            migrationBuilder.DropForeignKey(
                name: "FK_Champagnes_Strengths_FortressId",
                table: "Champagnes");

            migrationBuilder.DropForeignKey(
                name: "FK_Cognacs_Strengths_FortressId",
                table: "Cognacs");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Liquors");

            migrationBuilder.DropColumn(
                name: "Degree",
                table: "Liquors");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Liquors");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Basket");

            migrationBuilder.RenameColumn(
                name: "DegreeId",
                table: "Liquors",
                newName: "StrengthId");

            migrationBuilder.RenameColumn(
                name: "FortressId",
                table: "Cognacs",
                newName: "StrengthId");

            migrationBuilder.RenameIndex(
                name: "IX_Cognacs_FortressId",
                table: "Cognacs",
                newName: "IX_Cognacs_StrengthId");

            migrationBuilder.RenameColumn(
                name: "FortressId",
                table: "Champagnes",
                newName: "StrengthId");

            migrationBuilder.RenameIndex(
                name: "IX_Champagnes_FortressId",
                table: "Champagnes",
                newName: "IX_Champagnes_StrengthId");

            migrationBuilder.RenameColumn(
                name: "FortressId",
                table: "Beers",
                newName: "StrengthId");

            migrationBuilder.RenameIndex(
                name: "IX_Beers_FortressId",
                table: "Beers",
                newName: "IX_Beers_StrengthId");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Absents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Liquors_CountryId",
                table: "Liquors",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Liquors_SizeId",
                table: "Liquors",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Liquors_StrengthId",
                table: "Liquors",
                column: "StrengthId");

            migrationBuilder.AddForeignKey(
                name: "FK_Beers_Strengths_StrengthId",
                table: "Beers",
                column: "StrengthId",
                principalTable: "Strengths",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Champagnes_Strengths_StrengthId",
                table: "Champagnes",
                column: "StrengthId",
                principalTable: "Strengths",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cognacs_Strengths_StrengthId",
                table: "Cognacs",
                column: "StrengthId",
                principalTable: "Strengths",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Liquors_Сountries_CountryId",
                table: "Liquors",
                column: "CountryId",
                principalTable: "Сountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Liquors_Sizes_SizeId",
                table: "Liquors",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Liquors_Strengths_StrengthId",
                table: "Liquors",
                column: "StrengthId",
                principalTable: "Strengths",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beers_Strengths_StrengthId",
                table: "Beers");

            migrationBuilder.DropForeignKey(
                name: "FK_Champagnes_Strengths_StrengthId",
                table: "Champagnes");

            migrationBuilder.DropForeignKey(
                name: "FK_Cognacs_Strengths_StrengthId",
                table: "Cognacs");

            migrationBuilder.DropForeignKey(
                name: "FK_Liquors_Сountries_CountryId",
                table: "Liquors");

            migrationBuilder.DropForeignKey(
                name: "FK_Liquors_Sizes_SizeId",
                table: "Liquors");

            migrationBuilder.DropForeignKey(
                name: "FK_Liquors_Strengths_StrengthId",
                table: "Liquors");

            migrationBuilder.DropIndex(
                name: "IX_Liquors_CountryId",
                table: "Liquors");

            migrationBuilder.DropIndex(
                name: "IX_Liquors_SizeId",
                table: "Liquors");

            migrationBuilder.DropIndex(
                name: "IX_Liquors_StrengthId",
                table: "Liquors");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Absents");

            migrationBuilder.RenameColumn(
                name: "StrengthId",
                table: "Liquors",
                newName: "DegreeId");

            migrationBuilder.RenameColumn(
                name: "StrengthId",
                table: "Cognacs",
                newName: "FortressId");

            migrationBuilder.RenameIndex(
                name: "IX_Cognacs_StrengthId",
                table: "Cognacs",
                newName: "IX_Cognacs_FortressId");

            migrationBuilder.RenameColumn(
                name: "StrengthId",
                table: "Champagnes",
                newName: "FortressId");

            migrationBuilder.RenameIndex(
                name: "IX_Champagnes_StrengthId",
                table: "Champagnes",
                newName: "IX_Champagnes_FortressId");

            migrationBuilder.RenameColumn(
                name: "StrengthId",
                table: "Beers",
                newName: "FortressId");

            migrationBuilder.RenameIndex(
                name: "IX_Beers_StrengthId",
                table: "Beers",
                newName: "IX_Beers_FortressId");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Liquors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Degree",
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
                name: "UserId",
                table: "Basket",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Beers_Strengths_FortressId",
                table: "Beers",
                column: "FortressId",
                principalTable: "Strengths",
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
                name: "FK_Cognacs_Strengths_FortressId",
                table: "Cognacs",
                column: "FortressId",
                principalTable: "Strengths",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
