using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BodyPart",
                columns: new[] { "IdBodyPart", "Name" },
                values: new object[] { 1, "Chest" });

            migrationBuilder.InsertData(
                table: "ClothingType",
                columns: new[] { "IdClothingType", "Name" },
                values: new object[,]
                {
                    { 1, "Shirt" },
                    { 2, "T-Shirt" }
                });

            migrationBuilder.InsertData(
                table: "Pattern",
                columns: new[] { "IdPattern", "Name" },
                values: new object[] { 1, "Check " });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "IdUser", "AvatarUrl", "CreatedAt", "DeletedAt", "Email", "FirstName", "LastLogin", "LastName", "Password", "Salt" },
                values: new object[] { 1, "url", new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "qwert@gmail.com", "Artur", new DateTime(2019, 12, 10, 10, 30, 50, 0, DateTimeKind.Unspecified), "Pendragon", "1234", "wtf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BodyPart",
                keyColumn: "IdBodyPart",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ClothingType",
                keyColumn: "IdClothingType",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ClothingType",
                keyColumn: "IdClothingType",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pattern",
                keyColumn: "IdPattern",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1);
        }
    }
}
