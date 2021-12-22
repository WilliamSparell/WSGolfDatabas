using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WSGolfDatabas.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GolfCourse",
                table: "Weathers");

            migrationBuilder.DropColumn(
                name: "Score",
                table: "Weathers");

            migrationBuilder.DropColumn(
                name: "Score",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Weather",
                table: "Courses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GolfCourse",
                table: "Weathers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "Weathers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Weather",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
