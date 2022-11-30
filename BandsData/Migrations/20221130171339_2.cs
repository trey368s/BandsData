using Microsoft.EntityFrameworkCore.Migrations;

namespace BandsData.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bands",
                columns: new[] { "BandId", "founded", "genre", "members", "name", "notableWorks", "origin" },
                values: new object[] { 3, 1987, "Grunge", "Jerry Cantrell, Sean Kinney, Mike Inez, William DuVall", "Alice In Chains", "Down In A Hole, I Stay Away, Rotten Apple", "Seattle, Washington" });

            migrationBuilder.InsertData(
                table: "Bands",
                columns: new[] { "BandId", "founded", "genre", "members", "name", "notableWorks", "origin" },
                values: new object[] { 4, 1968, "Progressive Rock", "Steve Howe, Geoff Downes, Billy Sherwood, Jon Davison", "Yes", "Roundabout, Owner Of A Lonley Heart, Starship Trooper", "London, England" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bands",
                keyColumn: "BandId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bands",
                keyColumn: "BandId",
                keyValue: 4);
        }
    }
}
