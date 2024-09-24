using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace back.Migrations
{
    /// <inheritdoc />
    public partial class extendPlaygroundAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "ScheduledSession",
                newName: "Title");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Playground",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Playground",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Province",
                table: "Playground",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Playground");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Playground");

            migrationBuilder.DropColumn(
                name: "Province",
                table: "Playground");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "ScheduledSession",
                newName: "Description");
        }
    }
}
