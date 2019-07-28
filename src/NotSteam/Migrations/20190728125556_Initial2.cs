using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NotSteam.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                column: "LastPlayedDate",
                value: new DateTime(2019, 7, 28, 12, 55, 56, 459, DateTimeKind.Utc).AddTicks(7424));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 1, 1 },
                column: "LastPlayedDate",
                value: new DateTime(2019, 7, 28, 12, 53, 0, 942, DateTimeKind.Utc).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 1, 2 },
                column: "DateAcquired",
                value: new DateTime(2019, 7, 28, 12, 53, 0, 942, DateTimeKind.Utc).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 2, 1 },
                column: "LastPlayedDate",
                value: new DateTime(2019, 7, 28, 12, 53, 0, 942, DateTimeKind.Utc).AddTicks(2381));
        }
    }
}
