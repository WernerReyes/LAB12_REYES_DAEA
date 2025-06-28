using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LAB12_REYES.Migrations
{
    /// <inheritdoc />
    public partial class updatev4database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GradeIdGrade",
                table: "Students");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GradeIdGrade",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
