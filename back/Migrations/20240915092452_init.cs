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
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
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
                    PlaygroundId = table.Column<int>(type: "int", nullable: false)
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
                name: "FavouriteList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PlaygroundId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavouriteList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavouriteList_Playground_PlaygroundId",
                        column: x => x.PlaygroundId,
                        principalTable: "Playground",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavouriteList_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Moderator",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaygroundId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moderator", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moderator_Playground_PlaygroundId",
                        column: x => x.PlaygroundId,
                        principalTable: "Playground",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Moderator_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScheduledSessionParticipants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduledSessionParticipants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduledSessionParticipants_ScheduledSession_EventId",
                        column: x => x.EventId,
                        principalTable: "ScheduledSession",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduledSessionParticipants_User_UserId",
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

            migrationBuilder.CreateIndex(
                name: "IX_FavouriteList_PlaygroundId",
                table: "FavouriteList",
                column: "PlaygroundId");

            migrationBuilder.CreateIndex(
                name: "IX_FavouriteList_UserId",
                table: "FavouriteList",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Moderator_PlaygroundId",
                table: "Moderator",
                column: "PlaygroundId");

            migrationBuilder.CreateIndex(
                name: "IX_Moderator_UserId",
                table: "Moderator",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduledSession_PlaygroundId",
                table: "ScheduledSession",
                column: "PlaygroundId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduledSessionParticipants_EventId",
                table: "ScheduledSessionParticipants",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduledSessionParticipants_UserId",
                table: "ScheduledSessionParticipants",
                column: "UserId");

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
                name: "FavouriteList");

            migrationBuilder.DropTable(
                name: "Moderator");

            migrationBuilder.DropTable(
                name: "ScheduledSessionParticipants");

            migrationBuilder.DropTable(
                name: "Vote");

            migrationBuilder.DropTable(
                name: "ScheduledSession");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Voting");

            migrationBuilder.DropTable(
                name: "Playground");
        }
    }
}
