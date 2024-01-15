using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FunParkPlovdiv.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationBetweenDriveAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drive_Users_UserId",
                table: "Drive");

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("c3d60d86-18d9-493b-9fcc-0fc1fc084e6f"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("c417fe0f-b11a-4bf2-8cee-23f4d4209f65"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("cdc56f79-0a6e-435f-bf47-009fc067c974"));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Drive",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "Description", "Title", "Value" },
                values: new object[,]
                {
                    { new Guid("32276af8-5780-4ee2-85e9-095b18e2d29d"), "BirthDay", "1 час", 200m },
                    { new Guid("38555926-bda2-4680-af09-8f32895c257b"), "MiniCourse", "10 мин", 25m },
                    { new Guid("819eb240-56c8-4040-9e8d-832ff597f9c6"), "BigCourse", "15 мин", 35m }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Drive_Users_UserId",
                table: "Drive",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drive_Users_UserId",
                table: "Drive");

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("32276af8-5780-4ee2-85e9-095b18e2d29d"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("38555926-bda2-4680-af09-8f32895c257b"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("819eb240-56c8-4040-9e8d-832ff597f9c6"));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Drive",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "Description", "Title", "Value" },
                values: new object[,]
                {
                    { new Guid("c3d60d86-18d9-493b-9fcc-0fc1fc084e6f"), "MiniCourse", "10 мин", 25m },
                    { new Guid("c417fe0f-b11a-4bf2-8cee-23f4d4209f65"), "BirthDay", "1 час", 200m },
                    { new Guid("cdc56f79-0a6e-435f-bf47-009fc067c974"), "BigCourse", "15 мин", 35m }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Drive_Users_UserId",
                table: "Drive",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
