using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FunParkPlovdiv.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Prices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Description",
                table: "Prices");
        }
    }
}
