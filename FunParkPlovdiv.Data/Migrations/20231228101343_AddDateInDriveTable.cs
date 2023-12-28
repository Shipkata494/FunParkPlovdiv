using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FunParkPlovdiv.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDateInDriveTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Drive",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "Description", "Title", "Value" },
                values: new object[,]
                {
                    { new Guid("372361ca-eef4-4ebc-bacc-be7dfb0e0391"), "MiniCourse", "10 мин", 25m },
                    { new Guid("c4404eae-b97c-485f-89f4-c49b8ca2d94d"), "BirthDay", "1 час", 200m },
                    { new Guid("ef9dc987-075d-43ee-88de-243f701f758b"), "BigCourse", "15 мин", 35m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("372361ca-eef4-4ebc-bacc-be7dfb0e0391"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("c4404eae-b97c-485f-89f4-c49b8ca2d94d"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("ef9dc987-075d-43ee-88de-243f701f758b"));

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Drive");

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "Description", "Title", "Value" },
                values: new object[,]
                {
                    { new Guid("60259d98-357e-4142-a3b6-090b803b8624"), "BirthDay", "1 час", 200m },
                    { new Guid("a6d2f475-9e77-4c5b-96d1-e7071ea0d6fa"), "BigCourse", "15 мин", 35m },
                    { new Guid("e9546273-749d-4113-bc01-62ba54b12d00"), "MiniCourse", "10 мин", 25m }
                });
        }
    }
}
