using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NotSteam.Migrations
{
    public partial class Temp3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Username",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                maxLength: 32,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                maxLength: 32,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                maxLength: 254,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 254);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tags",
                maxLength: 48,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 48);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Games",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Companies",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64);

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 1, 1 },
                column: "LastPlayedDate",
                value: new DateTime(2019, 7, 28, 11, 16, 0, 16, DateTimeKind.Utc).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 1, 2 },
                column: "DateAcquired",
                value: new DateTime(2019, 7, 28, 11, 16, 0, 16, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumns: new[] { "UserId", "GameId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "LastPlayedDate", "TotalPlayTimeHours" },
                values: new object[] { new DateTime(2019, 7, 28, 11, 16, 0, 16, DateTimeKind.Utc).AddTicks(8870), 227 });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true,
                filter: "[Username] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Username",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 32,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 32,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                maxLength: 254,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 254,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tags",
                maxLength: 48,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 48,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Games",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Companies",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 64,
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }
    }
}
