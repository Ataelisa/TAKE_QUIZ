using Microsoft.EntityFrameworkCore.Migrations;

namespace Quiz_back.Migrations
{
    public partial class UPDATETABLEQUIZ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Quiz");

            migrationBuilder.RenameColumn(
                name: "username",
                table: "Quiz",
                newName: "QuizPassword");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Quiz",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImgPath",
                table: "Quiz",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Quiz",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Theme",
                table: "Quiz",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quiz",
                table: "Quiz",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Quiz",
                table: "Quiz");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Quiz");

            migrationBuilder.DropColumn(
                name: "ImgPath",
                table: "Quiz");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Quiz");

            migrationBuilder.DropColumn(
                name: "Theme",
                table: "Quiz");

            migrationBuilder.RenameTable(
                name: "Quiz",
                newName: "users");

            migrationBuilder.RenameColumn(
                name: "QuizPassword",
                table: "users",
                newName: "username");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "Id");
        }
    }
}
