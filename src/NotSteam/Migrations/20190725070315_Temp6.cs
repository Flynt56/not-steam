using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace NotSteam.Migrations
{
    public partial class Temp6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                maxLength: 254,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 7, 3, 14, 526, DateTimeKind.Utc).AddTicks(8985), new DateTime(2019, 7, 25, 7, 3, 14, 526, DateTimeKind.Utc).AddTicks(8987) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 7, 3, 14, 527, DateTimeKind.Utc).AddTicks(1120), new DateTime(2019, 7, 25, 7, 3, 14, 527, DateTimeKind.Utc).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 7, 3, 14, 527, DateTimeKind.Utc).AddTicks(1150), new DateTime(2019, 7, 25, 7, 3, 14, 527, DateTimeKind.Utc).AddTicks(1151) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 7, 3, 14, 527, DateTimeKind.Utc).AddTicks(9638), new DateTime(2019, 7, 25, 7, 3, 14, 527, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 7, 3, 14, 528, DateTimeKind.Utc).AddTicks(1225), new DateTime(2019, 7, 25, 7, 3, 14, 528, DateTimeKind.Utc).AddTicks(1227) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 7, 3, 14, 528, DateTimeKind.Utc).AddTicks(1253), new DateTime(2019, 7, 25, 7, 3, 14, 528, DateTimeKind.Utc).AddTicks(1254) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 7, 3, 14, 528, DateTimeKind.Utc).AddTicks(1256), new DateTime(2019, 7, 25, 7, 3, 14, 528, DateTimeKind.Utc).AddTicks(1256) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 7, 3, 14, 528, DateTimeKind.Utc).AddTicks(1258), new DateTime(2019, 7, 25, 7, 3, 14, 528, DateTimeKind.Utc).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 7, 3, 14, 528, DateTimeKind.Utc).AddTicks(1259), new DateTime(2019, 7, 25, 7, 3, 14, 528, DateTimeKind.Utc).AddTicks(1260) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 7, 3, 14, 527, DateTimeKind.Utc).AddTicks(6053), new DateTime(2019, 7, 25, 7, 3, 14, 527, DateTimeKind.Utc).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 7, 3, 14, 527, DateTimeKind.Utc).AddTicks(8233), new DateTime(2019, 7, 25, 7, 3, 14, 527, DateTimeKind.Utc).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 7, 3, 14, 527, DateTimeKind.Utc).AddTicks(8262), new DateTime(2019, 7, 25, 7, 3, 14, 527, DateTimeKind.Utc).AddTicks(8263) });

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt", "LastPlayedDate" },
                values: new object[] { new DateTime(2019, 7, 25, 7, 3, 14, 528, DateTimeKind.Utc).AddTicks(2632), new DateTime(2019, 7, 25, 7, 3, 14, 528, DateTimeKind.Utc).AddTicks(2632), new DateTime(2019, 7, 25, 7, 3, 14, 528, DateTimeKind.Utc).AddTicks(2631) });

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateAcquired", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 7, 3, 14, 528, DateTimeKind.Utc).AddTicks(4532), new DateTime(2019, 7, 25, 7, 3, 14, 528, DateTimeKind.Utc).AddTicks(4530), new DateTime(2019, 7, 25, 7, 3, 14, 528, DateTimeKind.Utc).AddTicks(4532) });

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt", "LastPlayedDate", "TotalPlayTimeHours" },
                values: new object[] { new DateTime(2019, 7, 25, 7, 3, 14, 528, DateTimeKind.Utc).AddTicks(4568), new DateTime(2019, 7, 25, 7, 3, 14, 528, DateTimeKind.Utc).AddTicks(4568), new DateTime(2019, 7, 25, 7, 3, 14, 528, DateTimeKind.Utc).AddTicks(4567), 151 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 7, 3, 14, 528, DateTimeKind.Utc).AddTicks(6233), new DateTime(2019, 7, 25, 7, 3, 14, 528, DateTimeKind.Utc).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 7, 3, 14, 528, DateTimeKind.Utc).AddTicks(8136), new DateTime(2019, 7, 25, 7, 3, 14, 528, DateTimeKind.Utc).AddTicks(8137) });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 7, 3, 14, 528, DateTimeKind.Utc).AddTicks(8166), new DateTime(2019, 7, 25, 7, 3, 14, 528, DateTimeKind.Utc).AddTicks(8166) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 7, 3, 14, 528, DateTimeKind.Utc).AddTicks(9600), new DateTime(2019, 7, 25, 7, 3, 14, 528, DateTimeKind.Utc).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 7, 3, 14, 529, DateTimeKind.Utc).AddTicks(1546), new DateTime(2019, 7, 25, 7, 3, 14, 529, DateTimeKind.Utc).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 7, 3, 14, 527, DateTimeKind.Utc).AddTicks(2898), new DateTime(2019, 7, 25, 7, 3, 14, 527, DateTimeKind.Utc).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 7, 3, 14, 527, DateTimeKind.Utc).AddTicks(4643), new DateTime(2019, 7, 25, 7, 3, 14, 527, DateTimeKind.Utc).AddTicks(4645) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 7, 3, 14, 527, DateTimeKind.Utc).AddTicks(4670), new DateTime(2019, 7, 25, 7, 3, 14, 527, DateTimeKind.Utc).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 7, 3, 14, 525, DateTimeKind.Utc).AddTicks(9896), new DateTime(2019, 7, 25, 7, 3, 14, 525, DateTimeKind.Utc).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 7, 3, 14, 526, DateTimeKind.Utc).AddTicks(2745), new DateTime(2019, 7, 25, 7, 3, 14, 526, DateTimeKind.Utc).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2019, 7, 25, 7, 3, 14, 526, DateTimeKind.Utc).AddTicks(2784), new DateTime(2019, 7, 25, 7, 3, 14, 526, DateTimeKind.Utc).AddTicks(2785) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 254);

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
    }
}
