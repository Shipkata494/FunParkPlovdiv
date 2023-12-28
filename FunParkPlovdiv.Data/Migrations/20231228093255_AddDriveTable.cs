using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FunParkPlovdiv.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDriveTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("26e70ea4-8f51-475b-9543-a2841c4a2c0b"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("acfc4385-8f3d-479b-95f8-8dd2e89c2b17"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("d6732edf-6f6b-4fcf-b7ed-6d9a2a3bf51d"));

            migrationBuilder.DropColumn(
                name: "Course",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RidesCount",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "Drive",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Courses = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drive", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drive_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "Description", "Title", "Value" },
                values: new object[,]
                {
                    { new Guid("60259d98-357e-4142-a3b6-090b803b8624"), "BirthDay", "1 час", 200m },
                    { new Guid("a6d2f475-9e77-4c5b-96d1-e7071ea0d6fa"), "BigCourse", "15 мин", 35m },
                    { new Guid("e9546273-749d-4113-bc01-62ba54b12d00"), "MiniCourse", "10 мин", 25m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drive_UserId",
                table: "Drive",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drive");

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("60259d98-357e-4142-a3b6-090b803b8624"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("a6d2f475-9e77-4c5b-96d1-e7071ea0d6fa"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("e9546273-749d-4113-bc01-62ba54b12d00"));

            migrationBuilder.AddColumn<int>(
                name: "Course",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RidesCount",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "Description", "Title", "Value" },
                values: new object[,]
                {
                    { new Guid("26e70ea4-8f51-475b-9543-a2841c4a2c0b"), "MiniCourse", "10 мин", 25m },
                    { new Guid("acfc4385-8f3d-479b-95f8-8dd2e89c2b17"), "BirthDay", "1 час", 200m },
                    { new Guid("d6732edf-6f6b-4fcf-b7ed-6d9a2a3bf51d"), "BigCourse", "15 мин", 35m }
                });
        }
    }
}
