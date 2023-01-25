using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "EpisodeComments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AnimeVotes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AnimeUserStatuses");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AnimeFavorites");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AnimeComments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "EpisodeComments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "AnimeVotes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "AnimeUserStatuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "AnimeFavorites",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "AnimeComments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
