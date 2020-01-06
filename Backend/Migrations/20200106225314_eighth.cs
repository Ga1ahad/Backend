using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class eighth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clothing_Suitcase",
                columns: new[] { "IdSuitcase", "IdClothing" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 3, 8 },
                    { 3, 9 }
                });

            migrationBuilder.UpdateData(
                table: "Suitcase",
                keyColumn: "IdSuitcase",
                keyValue: 2,
                column: "IdTrip",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clothing_Suitcase",
                keyColumns: new[] { "IdSuitcase", "IdClothing" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Clothing_Suitcase",
                keyColumns: new[] { "IdSuitcase", "IdClothing" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Clothing_Suitcase",
                keyColumns: new[] { "IdSuitcase", "IdClothing" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Clothing_Suitcase",
                keyColumns: new[] { "IdSuitcase", "IdClothing" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "Clothing_Suitcase",
                keyColumns: new[] { "IdSuitcase", "IdClothing" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "Clothing_Suitcase",
                keyColumns: new[] { "IdSuitcase", "IdClothing" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "Clothing_Suitcase",
                keyColumns: new[] { "IdSuitcase", "IdClothing" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "Clothing_Suitcase",
                keyColumns: new[] { "IdSuitcase", "IdClothing" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.UpdateData(
                table: "Suitcase",
                keyColumn: "IdSuitcase",
                keyValue: 2,
                column: "IdTrip",
                value: 21);
        }
    }
}
