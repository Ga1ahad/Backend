using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class seventh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Suitcase",
                columns: new[] { "IdSuitcase", "IdTrip", "IdUser", "Name" },
                values: new object[] { 1, 1, 1, "Suitcase-1 " });

            migrationBuilder.InsertData(
                table: "Suitcase",
                columns: new[] { "IdSuitcase", "IdTrip", "IdUser", "Name" },
                values: new object[] { 2, 2, 1, "Suitcase-2 " });

            migrationBuilder.InsertData(
                table: "Suitcase",
                columns: new[] { "IdSuitcase", "IdTrip", "IdUser", "Name" },
                values: new object[] { 3, 3, 2, "Suitcase-3 " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Suitcase",
                keyColumn: "IdSuitcase",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suitcase",
                keyColumn: "IdSuitcase",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Suitcase",
                keyColumn: "IdSuitcase",
                keyValue: 3);
        }
    }
}
