using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimeUserStatuses_AnimeStatuses_AnimeStatusID",
                table: "AnimeUserStatuses");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "AnimeUserStatuses");

            migrationBuilder.RenameColumn(
                name: "AnimeStatusID",
                table: "AnimeUserStatuses",
                newName: "AnimeStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_AnimeUserStatuses_AnimeStatusID",
                table: "AnimeUserStatuses",
                newName: "IX_AnimeUserStatuses_AnimeStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnimeUserStatuses_AnimeStatuses_AnimeStatusId",
                table: "AnimeUserStatuses",
                column: "AnimeStatusId",
                principalTable: "AnimeStatuses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimeUserStatuses_AnimeStatuses_AnimeStatusId",
                table: "AnimeUserStatuses");

            migrationBuilder.RenameColumn(
                name: "AnimeStatusId",
                table: "AnimeUserStatuses",
                newName: "AnimeStatusID");

            migrationBuilder.RenameIndex(
                name: "IX_AnimeUserStatuses_AnimeStatusId",
                table: "AnimeUserStatuses",
                newName: "IX_AnimeUserStatuses_AnimeStatusID");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "AnimeUserStatuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_AnimeUserStatuses_AnimeStatuses_AnimeStatusID",
                table: "AnimeUserStatuses",
                column: "AnimeStatusID",
                principalTable: "AnimeStatuses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
