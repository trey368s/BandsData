using Microsoft.EntityFrameworkCore.Migrations;

namespace BandsData.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bands",
                keyColumn: "BandId",
                keyValue: 4,
                columns: new[] { "founded", "genre", "members", "name", "notableWorks", "origin" },
                values: new object[] { 1998, "Indie Rock", "Julian Casablancas, Nikolai Fraiture, Albert Hammond, Jr. Fabrizio Moretti, Nick Valensi", "The Strokes", "The Adults Are Talking, Reptilia, Last Nite", "New York City, New York" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bands",
                keyColumn: "BandId",
                keyValue: 4,
                columns: new[] { "founded", "genre", "members", "name", "notableWorks", "origin" },
                values: new object[] { 1968, "Progressive Rock", "Steve Howe, Geoff Downes, Billy Sherwood, Jon Davison", "Yes", "Roundabout, Owner Of A Lonley Heart, Starship Trooper", "London, England" });
        }
    }
}
