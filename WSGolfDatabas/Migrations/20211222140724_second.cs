using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WSGolfDatabas.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Scores");

            migrationBuilder.DropColumn(
                name: "WeatherId",
                table: "Scores");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Scores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WeatherId",
                table: "Scores",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
