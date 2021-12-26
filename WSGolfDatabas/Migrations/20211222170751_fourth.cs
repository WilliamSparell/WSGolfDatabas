using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WSGolfDatabas.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseIdId",
                table: "Scores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WeatherIdId",
                table: "Scores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Scores_CourseIdId",
                table: "Scores",
                column: "CourseIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_WeatherIdId",
                table: "Scores",
                column: "WeatherIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Scores_Courses_CourseIdId",
                table: "Scores",
                column: "CourseIdId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Scores_Weathers_WeatherIdId",
                table: "Scores",
                column: "WeatherIdId",
                principalTable: "Weathers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scores_Courses_CourseIdId",
                table: "Scores");

            migrationBuilder.DropForeignKey(
                name: "FK_Scores_Weathers_WeatherIdId",
                table: "Scores");

            migrationBuilder.DropIndex(
                name: "IX_Scores_CourseIdId",
                table: "Scores");

            migrationBuilder.DropIndex(
                name: "IX_Scores_WeatherIdId",
                table: "Scores");

            migrationBuilder.DropColumn(
                name: "CourseIdId",
                table: "Scores");

            migrationBuilder.DropColumn(
                name: "WeatherIdId",
                table: "Scores");
        }
    }
}
