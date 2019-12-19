using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clothing",
                columns: new[] { "IdClothing", "CreatedAt", "DeletedAt", "Description", "IdBodyPart", "IdClothingType", "IdPattern", "IdUser", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "desc", 1, 1, 1, 1, "Shirt-1 " },
                    { 2, new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "desc", 1, 1, 1, 1, "Shirt-2 " },
                    { 3, new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "desc", 1, 1, 1, 1, "Shirt-3 " },
                    { 4, new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "desc", 1, 1, 1, 1, "Shirt-4 " },
                    { 5, new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "desc", 1, 1, 1, 1, "Shirt-5 " },
                    { 6, new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "desc", 1, 2, 1, 1, "T-Shirt-1 " },
                    { 7, new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "desc", 1, 2, 1, 1, "T-Shirt-2 " }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clothing",
                keyColumn: "IdClothing",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clothing",
                keyColumn: "IdClothing",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clothing",
                keyColumn: "IdClothing",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clothing",
                keyColumn: "IdClothing",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clothing",
                keyColumn: "IdClothing",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clothing",
                keyColumn: "IdClothing",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clothing",
                keyColumn: "IdClothing",
                keyValue: 7);
        }
    }
}
