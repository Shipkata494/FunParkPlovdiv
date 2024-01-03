using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FunParkPlovdiv.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePhoneNumberMaxLenght : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("078e5a93-717e-4471-9bde-5762c26e42f9"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("bd92d5b6-a477-4c96-8e89-da28cf5b3126"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("f4b7927c-9c1d-41af-ac38-1a2c489db3df"));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "Description", "Title", "Value" },
                values: new object[,]
                {
                    { new Guid("21bc81e9-7d81-47a6-84e5-a7f468e1f7e7"), "BigCourse", "15 мин", 35m },
                    { new Guid("5564179a-3517-41c4-abfb-2ffb5bf04319"), "BirthDay", "1 час", 200m },
                    { new Guid("fd6aa988-cf6b-44cf-9551-6536a96c92d0"), "MiniCourse", "10 мин", 25m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("21bc81e9-7d81-47a6-84e5-a7f468e1f7e7"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("5564179a-3517-41c4-abfb-2ffb5bf04319"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("fd6aa988-cf6b-44cf-9551-6536a96c92d0"));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "Description", "Title", "Value" },
                values: new object[,]
                {
                    { new Guid("078e5a93-717e-4471-9bde-5762c26e42f9"), "MiniCourse", "10 мин", 25m },
                    { new Guid("bd92d5b6-a477-4c96-8e89-da28cf5b3126"), "BigCourse", "15 мин", 35m },
                    { new Guid("f4b7927c-9c1d-41af-ac38-1a2c489db3df"), "BirthDay", "1 час", 200m }
                });
        }
    }
}
