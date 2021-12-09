using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiTemplate.Migrations
{
    public partial class AddedMissingRelationsAndInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TeacherId",
                table: "Courses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherId);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Description", "TeacherId", "Title" },
                values: new object[,]
                {
                    { new Guid("01725814-8660-4493-b42b-b90082b45c88"), "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam.", new Guid("00000000-0000-0000-0000-000000000000"), "Programming 1" },
                    { new Guid("a9e69332-e9b6-4ff5-aeaa-c65a40189fc1"), "Lorem ipsum dolor sit amet, consetetur sadipscing elitr.", new Guid("00000000-0000-0000-0000-000000000000"), "Math Part 1" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[,]
                {
                    { new Guid("b1fd6091-bad7-4cf0-bbdd-65a77dfcb8b7"), 17, "Jane Doe" },
                    { new Guid("de6764bf-3490-4ce0-ac06-dd6d9345b52b"), 16, "John Doe" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "CourseId", "Name" },
                values: new object[,]
                {
                    { new Guid("46a47703-8405-459a-95a3-dae276e0eb46"), new Guid("a9e69332-e9b6-4ff5-aeaa-c65a40189fc1"), "Hans Georg" },
                    { new Guid("fdffc1b3-da38-4cc6-b946-f9f2a98e6e6a"), new Guid("01725814-8660-4493-b42b-b90082b45c88"), "Hans Georg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teachers_TeacherId",
                table: "Courses",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_TeacherId",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("01725814-8660-4493-b42b-b90082b45c88"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("a9e69332-e9b6-4ff5-aeaa-c65a40189fc1"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("b1fd6091-bad7-4cf0-bbdd-65a77dfcb8b7"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("de6764bf-3490-4ce0-ac06-dd6d9345b52b"));

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Courses");
        }
    }
}
