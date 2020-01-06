using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clothing",
                columns: new[] { "IdClothing", "CreatedAt", "DeletedAt", "Description", "IdBodyPart", "IdClothingType", "IdPattern", "IdUser", "Name" },
                values: new object[] { 8, new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "desc", 1, 2, 1, 2, "T-Shirt-3 " });

            migrationBuilder.InsertData(
                table: "Clothing",
                columns: new[] { "IdClothing", "CreatedAt", "DeletedAt", "Description", "IdBodyPart", "IdClothingType", "IdPattern", "IdUser", "Name" },
                values: new object[] { 9, new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "desc", 1, 2, 1, 2, "T-Shirt-4 " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clothing",
                keyColumn: "IdClothing",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clothing",
                keyColumn: "IdClothing",
                keyValue: 9);
        }
    }
}
