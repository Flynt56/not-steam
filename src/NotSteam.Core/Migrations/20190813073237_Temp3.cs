using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NotSteam.Core.Migrations
{
    public partial class Temp3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 7, 32, 36, 237, DateTimeKind.Utc).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 7, 32, 36, 237, DateTimeKind.Utc).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 7, 32, 36, 237, DateTimeKind.Utc).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 7, 32, 36, 240, DateTimeKind.Utc).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 7, 32, 36, 241, DateTimeKind.Utc).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 7, 32, 36, 241, DateTimeKind.Utc).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 7, 32, 36, 241, DateTimeKind.Utc).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 7, 32, 36, 241, DateTimeKind.Utc).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { 3, 1 },
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 7, 32, 36, 241, DateTimeKind.Utc).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 7, 32, 36, 239, DateTimeKind.Utc).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 7, 32, 36, 240, DateTimeKind.Utc).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 7, 32, 36, 240, DateTimeKind.Utc).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedAt", "LastPlayedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 7, 32, 36, 242, DateTimeKind.Utc).AddTicks(1355), new DateTime(2019, 8, 13, 7, 32, 36, 242, DateTimeKind.Utc).AddTicks(1353) });

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreatedAt", "DateAcquired" },
                values: new object[] { new DateTime(2019, 8, 13, 7, 32, 36, 242, DateTimeKind.Utc).AddTicks(3541), new DateTime(2019, 8, 13, 7, 32, 36, 242, DateTimeKind.Utc).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "CreatedAt", "LastPlayedDate", "TotalPlayTimeHours" },
                values: new object[] { new DateTime(2019, 8, 13, 7, 32, 36, 242, DateTimeKind.Utc).AddTicks(3579), new DateTime(2019, 8, 13, 7, 32, 36, 242, DateTimeKind.Utc).AddTicks(3579), 607 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 7, 32, 36, 243, DateTimeKind.Utc).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 7, 32, 36, 243, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 7, 32, 36, 243, DateTimeKind.Utc).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 7, 32, 36, 244, DateTimeKind.Utc).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 7, 32, 36, 244, DateTimeKind.Utc).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 7, 32, 36, 238, DateTimeKind.Utc).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 7, 32, 36, 238, DateTimeKind.Utc).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 7, 32, 36, 238, DateTimeKind.Utc).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 7, 32, 36, 235, DateTimeKind.Utc).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 7, 32, 36, 236, DateTimeKind.Utc).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 8, 13, 7, 32, 36, 236, DateTimeKind.Utc).AddTicks(1244));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
