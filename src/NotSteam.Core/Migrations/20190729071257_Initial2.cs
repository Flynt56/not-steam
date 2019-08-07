using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NotSteam.Core.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 29, 7, 12, 56, 221, DateTimeKind.Utc).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 29, 7, 12, 56, 221, DateTimeKind.Utc).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 29, 7, 12, 56, 221, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2019, 7, 29, 7, 12, 56, 224, DateTimeKind.Utc).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedAt",
                value: new DateTime(2019, 7, 29, 7, 12, 56, 224, DateTimeKind.Utc).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTime(2019, 7, 29, 7, 12, 56, 224, DateTimeKind.Utc).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTime(2019, 7, 29, 7, 12, 56, 224, DateTimeKind.Utc).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedAt",
                value: new DateTime(2019, 7, 29, 7, 12, 56, 224, DateTimeKind.Utc).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 3, 1 },
                column: "CreatedAt",
                value: new DateTime(2019, 7, 29, 7, 12, 56, 224, DateTimeKind.Utc).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 29, 7, 12, 56, 223, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 29, 7, 12, 56, 223, DateTimeKind.Utc).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 29, 7, 12, 56, 223, DateTimeKind.Utc).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedAt", "LastPlayedDate" },
                values: new object[] { new DateTime(2019, 7, 29, 7, 12, 56, 225, DateTimeKind.Utc).AddTicks(9286), new DateTime(2019, 7, 29, 7, 12, 56, 225, DateTimeKind.Utc).AddTicks(9284) });

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreatedAt", "DateAcquired" },
                values: new object[] { new DateTime(2019, 7, 29, 7, 12, 56, 226, DateTimeKind.Utc).AddTicks(1271), new DateTime(2019, 7, 29, 7, 12, 56, 226, DateTimeKind.Utc).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "CreatedAt", "LastPlayedDate", "TotalPlayTimeHours" },
                values: new object[] { new DateTime(2019, 7, 29, 7, 12, 56, 226, DateTimeKind.Utc).AddTicks(1309), new DateTime(2019, 7, 29, 7, 12, 56, 226, DateTimeKind.Utc).AddTicks(1309), 247 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2019, 7, 29, 7, 12, 56, 227, DateTimeKind.Utc).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedAt",
                value: new DateTime(2019, 7, 29, 7, 12, 56, 227, DateTimeKind.Utc).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTime(2019, 7, 29, 7, 12, 56, 227, DateTimeKind.Utc).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2019, 7, 29, 7, 12, 56, 227, DateTimeKind.Utc).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTime(2019, 7, 29, 7, 12, 56, 228, DateTimeKind.Utc).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 29, 7, 12, 56, 222, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 29, 7, 12, 56, 222, DateTimeKind.Utc).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 29, 7, 12, 56, 222, DateTimeKind.Utc).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 29, 7, 12, 56, 219, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 29, 7, 12, 56, 219, DateTimeKind.Utc).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 29, 7, 12, 56, 219, DateTimeKind.Utc).AddTicks(9271));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 28, 15, 58, 33, 631, DateTimeKind.Utc).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 28, 15, 58, 33, 631, DateTimeKind.Utc).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 28, 15, 58, 33, 631, DateTimeKind.Utc).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2019, 7, 28, 15, 58, 33, 633, DateTimeKind.Utc).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedAt",
                value: new DateTime(2019, 7, 28, 15, 58, 33, 633, DateTimeKind.Utc).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTime(2019, 7, 28, 15, 58, 33, 633, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTime(2019, 7, 28, 15, 58, 33, 633, DateTimeKind.Utc).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedAt",
                value: new DateTime(2019, 7, 28, 15, 58, 33, 633, DateTimeKind.Utc).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 3, 1 },
                column: "CreatedAt",
                value: new DateTime(2019, 7, 28, 15, 58, 33, 633, DateTimeKind.Utc).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 28, 15, 58, 33, 632, DateTimeKind.Utc).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 28, 15, 58, 33, 633, DateTimeKind.Utc).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 28, 15, 58, 33, 633, DateTimeKind.Utc).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedAt", "LastPlayedDate" },
                values: new object[] { new DateTime(2019, 7, 28, 15, 58, 33, 634, DateTimeKind.Utc).AddTicks(409), new DateTime(2019, 7, 28, 15, 58, 33, 634, DateTimeKind.Utc).AddTicks(409) });

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreatedAt", "DateAcquired" },
                values: new object[] { new DateTime(2019, 7, 28, 15, 58, 33, 634, DateTimeKind.Utc).AddTicks(1790), new DateTime(2019, 7, 28, 15, 58, 33, 634, DateTimeKind.Utc).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "CreatedAt", "LastPlayedDate", "TotalPlayTimeHours" },
                values: new object[] { new DateTime(2019, 7, 28, 15, 58, 33, 634, DateTimeKind.Utc).AddTicks(1857), new DateTime(2019, 7, 28, 15, 58, 33, 634, DateTimeKind.Utc).AddTicks(1857), 231 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2019, 7, 28, 15, 58, 33, 634, DateTimeKind.Utc).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedAt",
                value: new DateTime(2019, 7, 28, 15, 58, 33, 634, DateTimeKind.Utc).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTime(2019, 7, 28, 15, 58, 33, 634, DateTimeKind.Utc).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2019, 7, 28, 15, 58, 33, 635, DateTimeKind.Utc).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTime(2019, 7, 28, 15, 58, 33, 635, DateTimeKind.Utc).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 28, 15, 58, 33, 632, DateTimeKind.Utc).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 28, 15, 58, 33, 632, DateTimeKind.Utc).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 28, 15, 58, 33, 632, DateTimeKind.Utc).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 28, 15, 58, 33, 630, DateTimeKind.Utc).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 28, 15, 58, 33, 631, DateTimeKind.Utc).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 28, 15, 58, 33, 631, DateTimeKind.Utc).AddTicks(1135));
        }
    }
}
