using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnimeFavorites",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    AnimeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeFavorites", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AnimeFavorites_Animes_AnimeId",
                        column: x => x.AnimeId,
                        principalTable: "Animes",
                        principalColumn: "AnimeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimeFavorites_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimeStatuses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeStatuses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AnimeVotes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    AnimeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeVotes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AnimeVotes_Animes_AnimeID",
                        column: x => x.AnimeID,
                        principalTable: "Animes",
                        principalColumn: "AnimeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimeVotes_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EpisodeComments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    EpisodeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EpisodeComments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EpisodeComments_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EpisodeComments_Episodes_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "Episodes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimeUserStatuses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    AnimeID = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    AnimeStatusID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeUserStatuses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AnimeUserStatuses_Animes_AnimeID",
                        column: x => x.AnimeID,
                        principalTable: "Animes",
                        principalColumn: "AnimeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimeUserStatuses_AnimeStatuses_AnimeStatusID",
                        column: x => x.AnimeStatusID,
                        principalTable: "AnimeStatuses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimeUserStatuses_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimeFavorites_AnimeId",
                table: "AnimeFavorites",
                column: "AnimeId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimeFavorites_AppUserId",
                table: "AnimeFavorites",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimeUserStatuses_AnimeID",
                table: "AnimeUserStatuses",
                column: "AnimeID");

            migrationBuilder.CreateIndex(
                name: "IX_AnimeUserStatuses_AnimeStatusID",
                table: "AnimeUserStatuses",
                column: "AnimeStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_AnimeUserStatuses_AppUserId",
                table: "AnimeUserStatuses",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimeVotes_AnimeID",
                table: "AnimeVotes",
                column: "AnimeID");

            migrationBuilder.CreateIndex(
                name: "IX_AnimeVotes_AppUserId",
                table: "AnimeVotes",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_EpisodeComments_AppUserId",
                table: "EpisodeComments",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_EpisodeComments_EpisodeId",
                table: "EpisodeComments",
                column: "EpisodeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimeFavorites");

            migrationBuilder.DropTable(
                name: "AnimeUserStatuses");

            migrationBuilder.DropTable(
                name: "AnimeVotes");

            migrationBuilder.DropTable(
                name: "EpisodeComments");

            migrationBuilder.DropTable(
                name: "AnimeStatuses");
        }
    }
}
