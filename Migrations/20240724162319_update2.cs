using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC5_Day15.Migrations
{
    /// <inheritdoc />
    public partial class update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Department_DepartmentId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Result_Course_CourseId",
                table: "Course_Result");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Result_Students_SSN",
                table: "Course_Result");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructore_Course_CourseId",
                table: "Instructore");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructore_Department_DepartmentId",
                table: "Instructore");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Department_DepartmentId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructore",
                table: "Instructore");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Result",
                table: "Course_Result");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "Instructore",
                newName: "Instructores");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Departments");

            migrationBuilder.RenameTable(
                name: "Course_Result",
                newName: "Course_Results");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "Courses");

            migrationBuilder.RenameIndex(
                name: "IX_Instructore_DepartmentId",
                table: "Instructores",
                newName: "IX_Instructores_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Instructore_CourseId",
                table: "Instructores",
                newName: "IX_Instructores_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Course_Result_SSN",
                table: "Course_Results",
                newName: "IX_Course_Results_SSN");

            migrationBuilder.RenameIndex(
                name: "IX_Course_Result_CourseId",
                table: "Course_Results",
                newName: "IX_Course_Results_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Course_DepartmentId",
                table: "Courses",
                newName: "IX_Courses_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructores",
                table: "Instructores",
                column: "InstructoreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Results",
                table: "Course_Results",
                column: "Course_ResultId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "CourseId");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructores",
                table: "Instructores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Results",
                table: "Course_Results");

            migrationBuilder.RenameTable(
                name: "Instructores",
                newName: "Instructore");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course");

            migrationBuilder.RenameTable(
                name: "Course_Results",
                newName: "Course_Result");

            migrationBuilder.RenameIndex(
                name: "IX_Instructores_DepartmentId",
                table: "Instructore",
                newName: "IX_Instructore_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Instructores_CourseId",
                table: "Instructore",
                newName: "IX_Instructore_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_DepartmentId",
                table: "Course",
                newName: "IX_Course_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Course_Results_SSN",
                table: "Course_Result",
                newName: "IX_Course_Result_SSN");

            migrationBuilder.RenameIndex(
                name: "IX_Course_Results_CourseId",
                table: "Course_Result",
                newName: "IX_Course_Result_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructore",
                table: "Instructore",
                column: "InstructoreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Result",
                table: "Course_Result",
                column: "Course_ResultId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Department_DepartmentId",
                table: "Course",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Result_Course_CourseId",
                table: "Course_Result",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Result_Students_SSN",
                table: "Course_Result",
                column: "SSN",
                principalTable: "Students",
                principalColumn: "SSN");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructore_Course_CourseId",
                table: "Instructore",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructore_Department_DepartmentId",
                table: "Instructore",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Department_DepartmentId",
                table: "Students",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "DepartmentId");
        }
    }
}
