using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NotSteam.Migrations
{
    public partial class Temp4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Games",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Companies",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Games",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Companies",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 250);

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
    }
}
