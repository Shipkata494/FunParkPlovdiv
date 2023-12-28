using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FunParkPlovdiv.Data.Migrations
{
    /// <inheritdoc />
    public partial class AjustDefaultDateTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Id", "Description", "Title", "Value" },
                values: new object[,]
                {
                    { new Guid("1db856fe-ec7f-4a79-bede-7f42a0bab10a"), "MiniCourse", "10 мин", 25m },
                    { new Guid("3f20b6ec-0843-4249-95c3-3f9c0c866a09"), "BirthDay", "1 час", 200m },
                    { new Guid("b1e3d403-7b40-4f0e-86ee-4b57558be3d5"), "BigCourse", "15 мин", 35m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("1db856fe-ec7f-4a79-bede-7f42a0bab10a"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("3f20b6ec-0843-4249-95c3-3f9c0c866a09"));

            migrationBuilder.DeleteData(
                table: "Prices",
                keyColumn: "Id",
                keyValue: new Guid("b1e3d403-7b40-4f0e-86ee-4b57558be3d5"));

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
    }
}
