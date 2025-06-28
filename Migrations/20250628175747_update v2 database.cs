using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LAB12_REYES.Migrations
{
    /// <inheritdoc />
    public partial class updatev2database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Students_StudentID1",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentID1",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentID1",
                table: "Students");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Enrollments",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Enrollments");

            migrationBuilder.AddColumn<int>(
                name: "StudentID1",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentID1",
                table: "Students",
                column: "StudentID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Students_StudentID1",
                table: "Students",
                column: "StudentID1",
                principalTable: "Students",
                principalColumn: "StudentID");
        }
    }
}
