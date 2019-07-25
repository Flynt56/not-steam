using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace NotSteam.Migrations
{
    public partial class Temp5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 6, 42, 34, 230, DateTimeKind.Utc).AddTicks(3730), new DateTime(2019, 7, 25, 6, 42, 34, 230, DateTimeKind.Utc).AddTicks(3731) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 6, 42, 34, 230, DateTimeKind.Utc).AddTicks(5879), new DateTime(2019, 7, 25, 6, 42, 34, 230, DateTimeKind.Utc).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 6, 42, 34, 230, DateTimeKind.Utc).AddTicks(5905), new DateTime(2019, 7, 25, 6, 42, 34, 230, DateTimeKind.Utc).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 6, 42, 34, 231, DateTimeKind.Utc).AddTicks(4365), new DateTime(2019, 7, 25, 6, 42, 34, 231, DateTimeKind.Utc).AddTicks(4366) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 6, 42, 34, 231, DateTimeKind.Utc).AddTicks(5909), new DateTime(2019, 7, 25, 6, 42, 34, 231, DateTimeKind.Utc).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 6, 42, 34, 231, DateTimeKind.Utc).AddTicks(5934), new DateTime(2019, 7, 25, 6, 42, 34, 231, DateTimeKind.Utc).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 6, 42, 34, 231, DateTimeKind.Utc).AddTicks(5936), new DateTime(2019, 7, 25, 6, 42, 34, 231, DateTimeKind.Utc).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 6, 42, 34, 231, DateTimeKind.Utc).AddTicks(5938), new DateTime(2019, 7, 25, 6, 42, 34, 231, DateTimeKind.Utc).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 6, 42, 34, 231, DateTimeKind.Utc).AddTicks(5940), new DateTime(2019, 7, 25, 6, 42, 34, 231, DateTimeKind.Utc).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 6, 42, 34, 231, DateTimeKind.Utc).AddTicks(807), new DateTime(2019, 7, 25, 6, 42, 34, 231, DateTimeKind.Utc).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 6, 42, 34, 231, DateTimeKind.Utc).AddTicks(2962), new DateTime(2019, 7, 25, 6, 42, 34, 231, DateTimeKind.Utc).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 6, 42, 34, 231, DateTimeKind.Utc).AddTicks(2991), new DateTime(2019, 7, 25, 6, 42, 34, 231, DateTimeKind.Utc).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt", "LastPlayedDate" },
                values: new object[] { new DateTime(2019, 7, 25, 6, 42, 34, 231, DateTimeKind.Utc).AddTicks(7317), new DateTime(2019, 7, 25, 6, 42, 34, 231, DateTimeKind.Utc).AddTicks(7318), new DateTime(2019, 7, 25, 6, 42, 34, 231, DateTimeKind.Utc).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateAcquired", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 6, 42, 34, 231, DateTimeKind.Utc).AddTicks(9175), new DateTime(2019, 7, 25, 6, 42, 34, 231, DateTimeKind.Utc).AddTicks(9174), new DateTime(2019, 7, 25, 6, 42, 34, 231, DateTimeKind.Utc).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt", "LastPlayedDate", "TotalPlayTimeHours" },
                values: new object[] { new DateTime(2019, 7, 25, 6, 42, 34, 231, DateTimeKind.Utc).AddTicks(9216), new DateTime(2019, 7, 25, 6, 42, 34, 231, DateTimeKind.Utc).AddTicks(9217), new DateTime(2019, 7, 25, 6, 42, 34, 231, DateTimeKind.Utc).AddTicks(9215), 150 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 6, 42, 34, 232, DateTimeKind.Utc).AddTicks(586), new DateTime(2019, 7, 25, 6, 42, 34, 232, DateTimeKind.Utc).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 6, 42, 34, 232, DateTimeKind.Utc).AddTicks(2431), new DateTime(2019, 7, 25, 6, 42, 34, 232, DateTimeKind.Utc).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 6, 42, 34, 232, DateTimeKind.Utc).AddTicks(2460), new DateTime(2019, 7, 25, 6, 42, 34, 232, DateTimeKind.Utc).AddTicks(2461) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 6, 42, 34, 232, DateTimeKind.Utc).AddTicks(3775), new DateTime(2019, 7, 25, 6, 42, 34, 232, DateTimeKind.Utc).AddTicks(3775) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 6, 42, 34, 232, DateTimeKind.Utc).AddTicks(5858), new DateTime(2019, 7, 25, 6, 42, 34, 232, DateTimeKind.Utc).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 6, 42, 34, 230, DateTimeKind.Utc).AddTicks(7726), new DateTime(2019, 7, 25, 6, 42, 34, 230, DateTimeKind.Utc).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 6, 42, 34, 230, DateTimeKind.Utc).AddTicks(9429), new DateTime(2019, 7, 25, 6, 42, 34, 230, DateTimeKind.Utc).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 6, 42, 34, 230, DateTimeKind.Utc).AddTicks(9454), new DateTime(2019, 7, 25, 6, 42, 34, 230, DateTimeKind.Utc).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 6, 42, 34, 229, DateTimeKind.Utc).AddTicks(4568), new DateTime(2019, 7, 25, 6, 42, 34, 229, DateTimeKind.Utc).AddTicks(4569) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 6, 42, 34, 229, DateTimeKind.Utc).AddTicks(7450), new DateTime(2019, 7, 25, 6, 42, 34, 229, DateTimeKind.Utc).AddTicks(7452) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 6, 42, 34, 229, DateTimeKind.Utc).AddTicks(7487), new DateTime(2019, 7, 25, 6, 42, 34, 229, DateTimeKind.Utc).AddTicks(7487) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 11, 13, 32, 797, DateTimeKind.Utc).AddTicks(6812), new DateTime(2019, 7, 24, 11, 13, 32, 797, DateTimeKind.Utc).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 11, 13, 32, 797, DateTimeKind.Utc).AddTicks(8945), new DateTime(2019, 7, 24, 11, 13, 32, 797, DateTimeKind.Utc).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 11, 13, 32, 797, DateTimeKind.Utc).AddTicks(8972), new DateTime(2019, 7, 24, 11, 13, 32, 797, DateTimeKind.Utc).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 11, 13, 32, 798, DateTimeKind.Utc).AddTicks(7533), new DateTime(2019, 7, 24, 11, 13, 32, 798, DateTimeKind.Utc).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 11, 13, 32, 798, DateTimeKind.Utc).AddTicks(9091), new DateTime(2019, 7, 24, 11, 13, 32, 798, DateTimeKind.Utc).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 11, 13, 32, 798, DateTimeKind.Utc).AddTicks(9117), new DateTime(2019, 7, 24, 11, 13, 32, 798, DateTimeKind.Utc).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 11, 13, 32, 798, DateTimeKind.Utc).AddTicks(9119), new DateTime(2019, 7, 24, 11, 13, 32, 798, DateTimeKind.Utc).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 11, 13, 32, 798, DateTimeKind.Utc).AddTicks(9121), new DateTime(2019, 7, 24, 11, 13, 32, 798, DateTimeKind.Utc).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 11, 13, 32, 798, DateTimeKind.Utc).AddTicks(9123), new DateTime(2019, 7, 24, 11, 13, 32, 798, DateTimeKind.Utc).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 11, 13, 32, 798, DateTimeKind.Utc).AddTicks(3915), new DateTime(2019, 7, 24, 11, 13, 32, 798, DateTimeKind.Utc).AddTicks(3916) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 11, 13, 32, 798, DateTimeKind.Utc).AddTicks(6083), new DateTime(2019, 7, 24, 11, 13, 32, 798, DateTimeKind.Utc).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 11, 13, 32, 798, DateTimeKind.Utc).AddTicks(6111), new DateTime(2019, 7, 24, 11, 13, 32, 798, DateTimeKind.Utc).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt", "LastPlayedDate" },
                values: new object[] { new DateTime(2019, 7, 24, 11, 13, 32, 799, DateTimeKind.Utc).AddTicks(465), new DateTime(2019, 7, 24, 11, 13, 32, 799, DateTimeKind.Utc).AddTicks(466), new DateTime(2019, 7, 24, 11, 13, 32, 799, DateTimeKind.Utc).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateAcquired", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 11, 13, 32, 799, DateTimeKind.Utc).AddTicks(2341), new DateTime(2019, 7, 24, 11, 13, 32, 799, DateTimeKind.Utc).AddTicks(2340), new DateTime(2019, 7, 24, 11, 13, 32, 799, DateTimeKind.Utc).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt", "LastPlayedDate", "TotalPlayTimeHours" },
                values: new object[] { new DateTime(2019, 7, 24, 11, 13, 32, 799, DateTimeKind.Utc).AddTicks(2375), new DateTime(2019, 7, 24, 11, 13, 32, 799, DateTimeKind.Utc).AddTicks(2376), new DateTime(2019, 7, 24, 11, 13, 32, 799, DateTimeKind.Utc).AddTicks(2375), 131 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 11, 13, 32, 799, DateTimeKind.Utc).AddTicks(3694), new DateTime(2019, 7, 24, 11, 13, 32, 799, DateTimeKind.Utc).AddTicks(3695) });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 11, 13, 32, 799, DateTimeKind.Utc).AddTicks(5564), new DateTime(2019, 7, 24, 11, 13, 32, 799, DateTimeKind.Utc).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 11, 13, 32, 799, DateTimeKind.Utc).AddTicks(5592), new DateTime(2019, 7, 24, 11, 13, 32, 799, DateTimeKind.Utc).AddTicks(5592) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 11, 13, 32, 799, DateTimeKind.Utc).AddTicks(6947), new DateTime(2019, 7, 24, 11, 13, 32, 799, DateTimeKind.Utc).AddTicks(6947) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 11, 13, 32, 799, DateTimeKind.Utc).AddTicks(8866), new DateTime(2019, 7, 24, 11, 13, 32, 799, DateTimeKind.Utc).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 11, 13, 32, 798, DateTimeKind.Utc).AddTicks(681), new DateTime(2019, 7, 24, 11, 13, 32, 798, DateTimeKind.Utc).AddTicks(682) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 11, 13, 32, 798, DateTimeKind.Utc).AddTicks(2391), new DateTime(2019, 7, 24, 11, 13, 32, 798, DateTimeKind.Utc).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 11, 13, 32, 798, DateTimeKind.Utc).AddTicks(2418), new DateTime(2019, 7, 24, 11, 13, 32, 798, DateTimeKind.Utc).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 11, 13, 32, 796, DateTimeKind.Utc).AddTicks(8284), new DateTime(2019, 7, 24, 11, 13, 32, 796, DateTimeKind.Utc).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 11, 13, 32, 797, DateTimeKind.Utc).AddTicks(1295), new DateTime(2019, 7, 24, 11, 13, 32, 797, DateTimeKind.Utc).AddTicks(1297) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 11, 13, 32, 797, DateTimeKind.Utc).AddTicks(1327), new DateTime(2019, 7, 24, 11, 13, 32, 797, DateTimeKind.Utc).AddTicks(1327) });
        }
    }
}
