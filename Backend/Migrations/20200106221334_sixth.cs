using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Trip",
                columns: new[] { "IdTrip", "CreatedAt", "DeletedAt", "End", "Name", "Start" },
                values: new object[] { 1, new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trip-1 ", new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trip",
                columns: new[] { "IdTrip", "CreatedAt", "DeletedAt", "End", "Name", "Start" },
                values: new object[] { 2, new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trip-2 ", new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trip",
                columns: new[] { "IdTrip", "CreatedAt", "DeletedAt", "End", "Name", "Start" },
                values: new object[] { 3, new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trip-3 ", new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trip",
                keyColumn: "IdTrip",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trip",
                keyColumn: "IdTrip",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trip",
                keyColumn: "IdTrip",
                keyValue: 3);
        }
    }
}
