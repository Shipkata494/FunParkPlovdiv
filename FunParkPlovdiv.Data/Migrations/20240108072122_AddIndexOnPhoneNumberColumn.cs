using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FunParkPlovdiv.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddIndexOnPhoneNumberColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "Description", "Title", "Value" },
                values: new object[,]
                {
                    { new Guid("c3d60d86-18d9-493b-9fcc-0fc1fc084e6f"), "MiniCourse", "10 мин", 25m },
                    { new Guid("c417fe0f-b11a-4bf2-8cee-23f4d4209f65"), "BirthDay", "1 час", 200m },
                    { new Guid("cdc56f79-0a6e-435f-bf47-009fc067c974"), "BigCourse", "15 мин", 35m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_PhoneNumber",
                table: "Users",
                column: "PhoneNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_PhoneNumber",
                table: "Users");

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
    }
}
