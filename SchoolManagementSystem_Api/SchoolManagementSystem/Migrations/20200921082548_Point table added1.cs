using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagementSystem.Migrations
{
    public partial class Pointtableadded1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamMark_Subject_SubjectId",
                table: "ExamMark");

            migrationBuilder.DropIndex(
                name: "IX_ExamMark_SubjectId",
                table: "ExamMark");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "ExamMark");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "ExamMark",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExamMark_SubjectId",
                table: "ExamMark",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamMark_Subject_SubjectId",
                table: "ExamMark",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
