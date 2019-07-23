using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NotSteam.Migrations
{
    public partial class Temp4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "Email" },
                values: new object[] { new DateTime(1996, 4, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Player123@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "Email" },
                values: new object[] { new DateTime(1996, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "wdwd@dwdwd.com" });
        }
    }
}
