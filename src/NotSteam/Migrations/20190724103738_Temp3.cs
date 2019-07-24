using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NotSteam.Migrations
{
    public partial class Temp3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 10, 37, 38, 115, DateTimeKind.Utc).AddTicks(8513), new DateTime(2019, 7, 24, 10, 37, 38, 115, DateTimeKind.Utc).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(613), new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(614) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(640), new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(641) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(9052), new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(9054) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(815), new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(841), new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(843), new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(845), new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(847), new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(848) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(5460), new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(5461) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(7612), new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(7641), new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt", "LastPlayedDate" },
                values: new object[] { new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(2251), new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(2252), new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateAcquired", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(4129), new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(4127), new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt", "LastPlayedDate", "TotalPlayTimeHours" },
                values: new object[] { new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(4163), new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(4163), new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(4162), 130 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(5667), new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(5669) });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(7525), new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(7553), new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(8873), new DateTime(2019, 7, 24, 10, 37, 38, 117, DateTimeKind.Utc).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 10, 37, 38, 118, DateTimeKind.Utc).AddTicks(774), new DateTime(2019, 7, 24, 10, 37, 38, 118, DateTimeKind.Utc).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(2350), new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(2352) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(4066), new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(4092), new DateTime(2019, 7, 24, 10, 37, 38, 116, DateTimeKind.Utc).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 10, 37, 38, 115, DateTimeKind.Utc).AddTicks(144), new DateTime(2019, 7, 24, 10, 37, 38, 115, DateTimeKind.Utc).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 10, 37, 38, 115, DateTimeKind.Utc).AddTicks(2999), new DateTime(2019, 7, 24, 10, 37, 38, 115, DateTimeKind.Utc).AddTicks(3001) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 10, 37, 38, 115, DateTimeKind.Utc).AddTicks(3031), new DateTime(2019, 7, 24, 10, 37, 38, 115, DateTimeKind.Utc).AddTicks(3031) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 9, 12, 16, 562, DateTimeKind.Utc).AddTicks(111), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 9, 12, 16, 562, DateTimeKind.Utc).AddTicks(2184), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 9, 12, 16, 562, DateTimeKind.Utc).AddTicks(2211), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 9, 12, 16, 563, DateTimeKind.Utc).AddTicks(603), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 9, 12, 16, 563, DateTimeKind.Utc).AddTicks(2147), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 9, 12, 16, 563, DateTimeKind.Utc).AddTicks(2171), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 9, 12, 16, 563, DateTimeKind.Utc).AddTicks(2173), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 9, 12, 16, 563, DateTimeKind.Utc).AddTicks(2174), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 9, 12, 16, 563, DateTimeKind.Utc).AddTicks(2175), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 9, 12, 16, 562, DateTimeKind.Utc).AddTicks(7052), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 9, 12, 16, 562, DateTimeKind.Utc).AddTicks(9210), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 9, 12, 16, 562, DateTimeKind.Utc).AddTicks(9237), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt", "LastPlayedDate" },
                values: new object[] { new DateTime(2019, 7, 24, 9, 12, 16, 563, DateTimeKind.Utc).AddTicks(3495), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 24, 9, 12, 16, 563, DateTimeKind.Utc).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateAcquired", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 9, 12, 16, 563, DateTimeKind.Utc).AddTicks(5360), new DateTime(2019, 7, 24, 9, 12, 16, 563, DateTimeKind.Utc).AddTicks(5359), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt", "LastPlayedDate", "TotalPlayTimeHours" },
                values: new object[] { new DateTime(2019, 7, 24, 9, 12, 16, 563, DateTimeKind.Utc).AddTicks(5393), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 24, 9, 12, 16, 563, DateTimeKind.Utc).AddTicks(5392), 129 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 9, 12, 16, 563, DateTimeKind.Utc).AddTicks(6856), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 9, 12, 16, 563, DateTimeKind.Utc).AddTicks(8717), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 9, 12, 16, 563, DateTimeKind.Utc).AddTicks(8743), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 9, 12, 16, 564, DateTimeKind.Utc).AddTicks(223), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 9, 12, 16, 564, DateTimeKind.Utc).AddTicks(2114), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 9, 12, 16, 562, DateTimeKind.Utc).AddTicks(3907), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 9, 12, 16, 562, DateTimeKind.Utc).AddTicks(5678), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 9, 12, 16, 562, DateTimeKind.Utc).AddTicks(5705), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 9, 12, 16, 561, DateTimeKind.Utc).AddTicks(1727), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 9, 12, 16, 561, DateTimeKind.Utc).AddTicks(4568), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 24, 9, 12, 16, 561, DateTimeKind.Utc).AddTicks(4601), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
