using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "IdUser", "AvatarUrl", "CreatedAt", "DeletedAt", "Email", "FirstName", "LastLogin", "LastName", "Password", "Salt" },
                values: new object[] { 2, "url", new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "asdf@gmail.com", "Sherlock", new DateTime(2019, 12, 10, 10, 30, 50, 0, DateTimeKind.Unspecified), "Holmes", "1234", "wtf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 2);
        }
    }
}
