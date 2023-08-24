using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCodeFrist.Migrations
{
    public partial class AddRelationshipIntoTeacherAndSubject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeachersId",
                table: "Subjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_TeachersId",
                table: "Subjects",
                column: "TeachersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Teachers_TeachersId",
                table: "Subjects",
                column: "TeachersId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Teachers_TeachersId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_TeachersId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "TeachersId",
                table: "Subjects");
        }
    }
}
