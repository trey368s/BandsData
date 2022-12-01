using Microsoft.EntityFrameworkCore.Migrations;

namespace BandsData.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bands",
                keyColumn: "BandId",
                keyValue: 3,
                columns: new[] { "founded", "genre", "members", "name", "notableWorks", "origin" },
                values: new object[] { 1999, "Alternative Rock", "Tyson Ritter, Nick Wheeler, Mike Kennerty, Chris Gaylor", "The All-American Rejects", "Gives You Hell, My Paper Heart, Dirty Little Secret", "Stillwater, Oklahoma" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bands",
                keyColumn: "BandId",
                keyValue: 3,
                columns: new[] { "founded", "genre", "members", "name", "notableWorks", "origin" },
                values: new object[] { 1987, "Grunge", "Jerry Cantrell, Sean Kinney, Mike Inez, William DuVall", "Alice In Chains", "Down In A Hole, I Stay Away, Rotten Apple", "Seattle, Washington" });
        }
    }
}
