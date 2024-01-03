using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FunParkPlovdiv.Data.Migrations
{
    /// <inheritdoc />
    public partial class addPhoneNumberInUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
