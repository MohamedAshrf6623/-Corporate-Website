using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC5_Day15.Migrations
{
    /// <inheritdoc />
    public partial class UPDATENO : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Results_Courses_CourseId",
                table: "Course_Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Results_Students_SSN",
                table: "Course_Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructores_Courses_CourseId",
                table: "Instructores");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructores_Departments_DepartmentId",
                table: "Instructores");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Results_Courses_CourseId",
                table: "Course_Results",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Results_Students_SSN",
                table: "Course_Results",
                column: "SSN",
                principalTable: "Students",
                principalColumn: "SSN",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructores_Courses_CourseId",
                table: "Instructores",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructores_Departments_DepartmentId",
                table: "Instructores",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Results_Courses_CourseId",
                table: "Course_Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Results_Students_SSN",
                table: "Course_Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructores_Courses_CourseId",
                table: "Instructores");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructores_Departments_DepartmentId",
                table: "Instructores");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Results_Courses_CourseId",
                table: "Course_Results",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Results_Students_SSN",
                table: "Course_Results",
                column: "SSN",
                principalTable: "Students",
                principalColumn: "SSN");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructores_Courses_CourseId",
                table: "Instructores",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructores_Departments_DepartmentId",
                table: "Instructores",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId");
        }
    }
}
