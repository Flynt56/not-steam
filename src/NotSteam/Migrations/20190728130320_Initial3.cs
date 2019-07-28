using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NotSteam.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 1, 1 },
                column: "LastPlayedDate",
                value: new DateTime(2019, 7, 28, 13, 3, 20, 138, DateTimeKind.Utc).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 1, 2 },
                column: "DateAcquired",
                value: new DateTime(2019, 7, 28, 13, 3, 20, 138, DateTimeKind.Utc).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "LastPlayedDate", "TotalPlayTimeHours" },
                values: new object[] { new DateTime(2019, 7, 28, 13, 3, 20, 138, DateTimeKind.Utc).AddTicks(3483), 229 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 1, 1 },
                column: "LastPlayedDate",
                value: new DateTime(2019, 7, 28, 12, 55, 56, 459, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 1, 2 },
                column: "DateAcquired",
                value: new DateTime(2019, 7, 28, 12, 55, 56, 459, DateTimeKind.Utc).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "LastPlayedDate", "TotalPlayTimeHours" },
                values: new object[] { new DateTime(2019, 7, 28, 12, 55, 56, 459, DateTimeKind.Utc).AddTicks(7424), 228 });
        }
    }
}
