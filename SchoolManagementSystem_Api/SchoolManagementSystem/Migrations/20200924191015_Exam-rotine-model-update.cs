using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagementSystem.Migrations
{
    public partial class Examrotinemodelupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Exam");

            migrationBuilder.AddColumn<string>(
                name: "Duration",
                table: "ExamRoutine",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "EndTime",
                table: "ExamRoutine",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "StartTime",
                table: "ExamRoutine",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "ExamRoutine");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "ExamRoutine");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "ExamRoutine");

            migrationBuilder.AddColumn<string>(
                name: "Duration",
                table: "Exam",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
