using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace newAlcogolMarket.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Absents",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Absents_CategoryofAlcogol_CategoryId",
                table: "Absents");

            migrationBuilder.DropTable(
                name: "CategoryofAlcogol");

            migrationBuilder.DropIndex(
                name: "IX_Absents_CategoryId",
                table: "Absents");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Absents");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }
    }
}
