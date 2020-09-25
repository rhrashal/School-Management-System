using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagementSystem.Migrations
{
    public partial class Pointtableadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamMark_Subject_SubjectId",
                table: "ExamMark");

            migrationBuilder.DropColumn(
                name: "GradePoint",
                table: "ExamResult");

            migrationBuilder.DropColumn(
                name: "GradePoint",
                table: "ExamMark");

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "ExamResult",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Grade",
                table: "ExamResult",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Point",
                table: "ExamResult",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "ExamMark",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Grade",
                table: "ExamMark",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Point",
                table: "ExamMark",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "ExamResultPoint",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaximumMark = table.Column<int>(nullable: false),
                    MinimumMark = table.Column<int>(nullable: false),
                    Point = table.Column<double>(nullable: false),
                    Grade = table.Column<string>(maxLength: 2, nullable: false),
                    Note = table.Column<string>(maxLength: 500, nullable: false),
                    BranchId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamResultPoint", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamResultPoint_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExamResultPoint_BranchId",
                table: "ExamResultPoint",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamMark_Subject_SubjectId",
                table: "ExamMark",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamMark_Subject_SubjectId",
                table: "ExamMark");

            migrationBuilder.DropTable(
                name: "ExamResultPoint");

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "ExamResult");

            migrationBuilder.DropColumn(
                name: "Point",
                table: "ExamResult");

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "ExamMark");

            migrationBuilder.DropColumn(
                name: "Point",
                table: "ExamMark");

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "ExamResult",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "GradePoint",
                table: "ExamResult",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "ExamMark",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "GradePoint",
                table: "ExamMark",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamMark_Subject_SubjectId",
                table: "ExamMark",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
