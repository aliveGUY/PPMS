using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace back.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Playground",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequiredVotesElectModerator = table.Column<int>(type: "int", nullable: false),
                    RequiredVotesDismissModerator = table.Column<int>(type: "int", nullable: false),
                    RequiredVotesScheduleSession = table.Column<int>(type: "int", nullable: false),
                    RequiredVotesDiscardSession = table.Column<int>(type: "int", nullable: false),
                    RequiredVotesEditPlayground = table.Column<int>(type: "int", nullable: false),
                    RequiredVotesDeletePlayground = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playground", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModeratorList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaygroundId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModeratorList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModeratorList_Playground_PlaygroundId",
                        column: x => x.PlaygroundId,
                        principalTable: "Playground",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScheduledSession",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventType = table.Column<int>(type: "int", nullable: false),
                    Repeat = table.Column<int>(type: "int", nullable: false),
                    PlaygroundId = table.Column<int>(type: "int", nullable: false),
                    ParticipantIds = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduledSession", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduledSession_Playground_PlaygroundId",
                        column: x => x.PlaygroundId,
                        principalTable: "Playground",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Voting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Agenda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VotingCategory = table.Column<int>(type: "int", nullable: false),
                    PlaygroundId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Voting_Playground_PlaygroundId",
                        column: x => x.PlaygroundId,
                        principalTable: "Playground",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScheduledSessionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_ScheduledSession_ScheduledSessionId",
                        column: x => x.ScheduledSessionId,
                        principalTable: "ScheduledSession",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FavouriteList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PlaygroundId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavouriteList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavouriteList_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModeratorListUser",
                columns: table => new
                {
                    ModeratorListsId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModeratorListUser", x => new { x.ModeratorListsId, x.UserId });
                    table.ForeignKey(
                        name: "FK_ModeratorListUser_ModeratorList_ModeratorListsId",
                        column: x => x.ModeratorListsId,
                        principalTable: "ModeratorList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModeratorListUser_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vote",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoteChoice = table.Column<int>(type: "int", nullable: false),
                    VotingId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vote", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vote_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vote_Voting_VotingId",
                        column: x => x.VotingId,
                        principalTable: "Voting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavouriteListPlayground",
                columns: table => new
                {
                    FavouriteListsId = table.Column<int>(type: "int", nullable: false),
                    PlaygroundId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavouriteListPlayground", x => new { x.FavouriteListsId, x.PlaygroundId });
                    table.ForeignKey(
                        name: "FK_FavouriteListPlayground_FavouriteList_FavouriteListsId",
                        column: x => x.FavouriteListsId,
                        principalTable: "FavouriteList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavouriteListPlayground_Playground_PlaygroundId",
                        column: x => x.PlaygroundId,
                        principalTable: "Playground",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FavouriteList_UserId",
                table: "FavouriteList",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FavouriteListPlayground_PlaygroundId",
                table: "FavouriteListPlayground",
                column: "PlaygroundId");

            migrationBuilder.CreateIndex(
                name: "IX_ModeratorList_PlaygroundId",
                table: "ModeratorList",
                column: "PlaygroundId");

            migrationBuilder.CreateIndex(
                name: "IX_ModeratorListUser_UserId",
                table: "ModeratorListUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduledSession_PlaygroundId",
                table: "ScheduledSession",
                column: "PlaygroundId");

            migrationBuilder.CreateIndex(
                name: "IX_User_ScheduledSessionId",
                table: "User",
                column: "ScheduledSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Vote_UserId",
                table: "Vote",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Vote_VotingId",
                table: "Vote",
                column: "VotingId");

            migrationBuilder.CreateIndex(
                name: "IX_Voting_PlaygroundId",
                table: "Voting",
                column: "PlaygroundId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavouriteListPlayground");

            migrationBuilder.DropTable(
                name: "ModeratorListUser");

            migrationBuilder.DropTable(
                name: "Vote");

            migrationBuilder.DropTable(
                name: "FavouriteList");

            migrationBuilder.DropTable(
                name: "ModeratorList");

            migrationBuilder.DropTable(
                name: "Voting");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "ScheduledSession");

            migrationBuilder.DropTable(
                name: "Playground");
        }
    }
}
