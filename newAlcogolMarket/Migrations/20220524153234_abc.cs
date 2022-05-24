using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace newAlcogolMarket.Migrations
{
    public partial class abc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Basket");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Absents");

            migrationBuilder.DropColumn(
                name: "Degree",
                table: "Absents");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Absents");

            migrationBuilder.RenameColumn(
                name: "DegreeId",
                table: "Absents",
                newName: "FortressId");

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fortress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Degree = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fortress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Volume = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Absents_CountryId",
                table: "Absents",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Absents_FortressId",
                table: "Absents",
                column: "FortressId");

            migrationBuilder.CreateIndex(
                name: "IX_Absents_SizeId",
                table: "Absents",
                column: "SizeId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Country");

            migrationBuilder.DropTable(
                name: "Fortress");

            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.DropIndex(
                name: "IX_Absents_CountryId",
                table: "Absents");

            migrationBuilder.DropIndex(
                name: "IX_Absents_FortressId",
                table: "Absents");

            migrationBuilder.DropIndex(
                name: "IX_Absents_SizeId",
                table: "Absents");

            migrationBuilder.RenameColumn(
                name: "FortressId",
                table: "Absents",
                newName: "DegreeId");

            migrationBuilder.AddColumn<int>(
                name: "Name",
                table: "Basket",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Absents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Degree",
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
        }
    }
}
