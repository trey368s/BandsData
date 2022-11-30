using Microsoft.EntityFrameworkCore.Migrations;

namespace BandsData.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bands",
                columns: table => new
                {
                    BandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    members = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    founded = table.Column<int>(type: "int", nullable: false),
                    origin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    notableWorks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bands", x => x.BandId);
                });

            migrationBuilder.InsertData(
                table: "Bands",
                columns: new[] { "BandId", "founded", "genre", "members", "name", "notableWorks", "origin" },
                values: new object[] { 1, 1965, "Progressive Rock", "Syd Barrett, Roger Waters, Richard Wright, David Gilmour, Nick Mason", "Pink Floyd", "Dark Side of the Moon, Another Brick in the Wall, Wish You Were Here", "London, England" });

            migrationBuilder.InsertData(
                table: "Bands",
                columns: new[] { "BandId", "founded", "genre", "members", "name", "notableWorks", "origin" },
                values: new object[] { 2, 1968, "Hard Rock", "Jimmy Page, Robert Plant, John Bonham, John Paul Jones", "Led Zeppelin", "Stairway to Heaven, Immigrant Song, Kashmir", "London, England" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bands");
        }
    }
}
