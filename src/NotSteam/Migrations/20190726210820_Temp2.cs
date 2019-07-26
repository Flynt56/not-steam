using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NotSteam.Migrations
{
    public partial class Temp2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 1, 1 },
                column: "LastPlayedDate",
                value: new DateTime(2019, 7, 26, 21, 8, 20, 21, DateTimeKind.Utc).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 1, 2 },
                column: "DateAcquired",
                value: new DateTime(2019, 7, 26, 21, 8, 20, 21, DateTimeKind.Utc).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "LastPlayedDate", "TotalPlayTimeHours" },
                values: new object[] { new DateTime(2019, 7, 26, 21, 8, 20, 21, DateTimeKind.Utc).AddTicks(7446), 189 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 1, 1 },
                column: "LastPlayedDate",
                value: new DateTime(2019, 7, 26, 18, 42, 29, 294, DateTimeKind.Utc).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 1, 2 },
                column: "DateAcquired",
                value: new DateTime(2019, 7, 26, 18, 42, 29, 294, DateTimeKind.Utc).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "LastPlayedDate", "TotalPlayTimeHours" },
                values: new object[] { new DateTime(2019, 7, 26, 18, 42, 29, 294, DateTimeKind.Utc).AddTicks(1244), 186 });
        }
    }
}
