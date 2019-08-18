using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NotSteam.Infrastructure.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 64, nullable: false),
                    HomepageUri = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 1500, nullable: true),
                    LogoImageUri = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 48, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Username = table.Column<string>(maxLength: 32, nullable: false),
                    Password = table.Column<string>(maxLength: 32, nullable: false),
                    Email = table.Column<string>(maxLength: 254, nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Nickname = table.Column<string>(maxLength: 32, nullable: true),
                    ProfileImageUri = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(maxLength: 250, nullable: false),
                    Description = table.Column<string>(maxLength: 1500, nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    BasePrice = table.Column<decimal>(type: "decimal(19,4)", nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameTags",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false),
                    TagId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameTags", x => new { x.GameId, x.TagId });
                    table.ForeignKey(
                        name: "FK_GameTags_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Libraries",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    GameId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DateAcquired = table.Column<DateTime>(nullable: false),
                    TotalPlayTimeHours = table.Column<int>(nullable: false),
                    LastPlayedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libraries", x => new { x.UserId, x.GameId });
                    table.ForeignKey(
                        name: "FK_Libraries_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Libraries_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    GameId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DateOfPurchase = table.Column<DateTime>(nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(19,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchases", x => new { x.UserId, x.GameId });
                    table.ForeignKey(
                        name: "FK_Purchases_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Purchases_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    GameId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 1500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => new { x.UserId, x.GameId });
                    table.ForeignKey(
                        name: "FK_Reviews_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CreatedAt", "Description", "HomepageUri", "IsDeleted", "LogoImageUri", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 8, 18, 10, 49, 23, 327, DateTimeKind.Utc).AddTicks(4570), "We make really cool games!", "https://www.methesda-softworks.com", false, "https://cdn.notsteam.com/images/101", "Methesda Softworks Inc.", null },
                    { 2, new DateTime(2019, 8, 18, 10, 49, 23, 327, DateTimeKind.Utc).AddTicks(5606), "We make tech demos!", "https://www.crymearivertek.com", false, "https://cdn.notsteam.com/images/102", "CryMeARiverTek GmbH", null },
                    { 3, new DateTime(2019, 8, 18, 10, 49, 23, 327, DateTimeKind.Utc).AddTicks(5617), "We make great action-adventure, role-playing games!", "https://www.dvd-projekt-blue.com", false, "https://cdn.notsteam.com/images/103", "DVD Projekt Blue", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 8, 18, 10, 49, 23, 327, DateTimeKind.Utc).AddTicks(8718), "This item contains single-player content (e.g. campaign, story mode, etc.)", false, "Single-Player", null },
                    { 2, new DateTime(2019, 8, 18, 10, 49, 23, 327, DateTimeKind.Utc).AddTicks(9568), "This item contains multi-player content. Requires an internet connection.", false, "Multi-Player", null },
                    { 3, new DateTime(2019, 8, 18, 10, 49, 23, 327, DateTimeKind.Utc).AddTicks(9579), "This item contains ce-op content. Requires an internet connection. A limited amount of players can group up and play!", false, "Co-Op", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "Email", "IsDeleted", "Nickname", "Password", "ProfileImageUri", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 8, 18, 10, 49, 23, 326, DateTimeKind.Utc).AddTicks(8710), new DateTime(1996, 4, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Player123@gmail.com", false, "xXSlayerXx", "ReallySecurePlaintextStorage", "https://cdn.notsteam.com/images/1", null, "Player123" },
                    { 2, new DateTime(2019, 8, 18, 10, 49, 23, 326, DateTimeKind.Utc).AddTicks(9968), new DateTime(1992, 2, 12, 0, 0, 0, 0, DateTimeKind.Utc), "NobodyReally@outlook.com", false, "Sgt. Harry", "super_secure_pass123", "https://cdn.notsteam.com/images/2", null, "cool_username2" },
                    { 3, new DateTime(2019, 8, 18, 10, 49, 23, 326, DateTimeKind.Utc).AddTicks(9979), new DateTime(1989, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc), "SampleText@gmail.com", false, "Mr.Boom", "no1C4nGU3sSm3", "https://cdn.notsteam.com/images/3", null, "tru_41iam" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "BasePrice", "CompanyId", "CreatedAt", "Description", "IsDeleted", "ReleaseDate", "Title", "UpdatedAt" },
                values: new object[] { 2, 79.99m, 1, new DateTime(2019, 8, 18, 10, 49, 23, 328, DateTimeKind.Utc).AddTicks(5796), "What we really want from EA.", false, new DateTime(2018, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Need for Speed: Underground 3", null });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "BasePrice", "CompanyId", "CreatedAt", "Description", "IsDeleted", "ReleaseDate", "Title", "UpdatedAt" },
                values: new object[] { 3, 69.69m, 2, new DateTime(2019, 8, 18, 10, 49, 23, 328, DateTimeKind.Utc).AddTicks(5807), "One of these days…", false, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Age of Empires 4", null });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "BasePrice", "CompanyId", "CreatedAt", "Description", "IsDeleted", "ReleaseDate", "Title", "UpdatedAt" },
                values: new object[] { 1, 59.99m, 3, new DateTime(2019, 8, 18, 10, 49, 23, 328, DateTimeKind.Utc).AddTicks(4833), "New year, new game!", false, new DateTime(2019, 6, 22, 0, 0, 0, 0, DateTimeKind.Utc), "C4ll of $$$$: Covert Ops", null });

            migrationBuilder.InsertData(
                table: "GameTags",
                columns: new[] { "GameId", "TagId", "CreatedAt", "IsDeleted", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2019, 8, 18, 10, 49, 23, 329, DateTimeKind.Utc).AddTicks(521), false, null },
                    { 2, 2, new DateTime(2019, 8, 18, 10, 49, 23, 329, DateTimeKind.Utc).AddTicks(521), false, null },
                    { 2, 3, new DateTime(2019, 8, 18, 10, 49, 23, 329, DateTimeKind.Utc).AddTicks(522), false, null },
                    { 3, 1, new DateTime(2019, 8, 18, 10, 49, 23, 329, DateTimeKind.Utc).AddTicks(523), false, null },
                    { 1, 1, new DateTime(2019, 8, 18, 10, 49, 23, 328, DateTimeKind.Utc).AddTicks(9877), false, null },
                    { 1, 2, new DateTime(2019, 8, 18, 10, 49, 23, 329, DateTimeKind.Utc).AddTicks(511), false, null }
                });

            migrationBuilder.InsertData(
                table: "Libraries",
                columns: new[] { "UserId", "GameId", "CreatedAt", "DateAcquired", "IsDeleted", "LastPlayedDate", "TotalPlayTimeHours", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2019, 8, 18, 10, 49, 23, 329, DateTimeKind.Utc).AddTicks(6181), new DateTime(2019, 8, 18, 10, 49, 23, 329, DateTimeKind.Utc).AddTicks(6180), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 1, 1, new DateTime(2019, 8, 18, 10, 49, 23, 329, DateTimeKind.Utc).AddTicks(5394), new DateTime(2019, 7, 20, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2019, 8, 18, 10, 49, 23, 329, DateTimeKind.Utc).AddTicks(5394), 20, null },
                    { 2, 1, new DateTime(2019, 8, 18, 10, 49, 23, 329, DateTimeKind.Utc).AddTicks(6265), new DateTime(2019, 7, 18, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2019, 8, 18, 10, 49, 23, 329, DateTimeKind.Utc).AddTicks(6264), 730, null }
                });

            migrationBuilder.InsertData(
                table: "Purchases",
                columns: new[] { "UserId", "GameId", "CreatedAt", "DateOfPurchase", "IsDeleted", "TotalPrice", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2019, 8, 18, 10, 49, 23, 330, DateTimeKind.Utc).AddTicks(1633), new DateTime(2019, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), false, 64.99m, null },
                    { 1, 1, new DateTime(2019, 8, 18, 10, 49, 23, 330, DateTimeKind.Utc).AddTicks(830), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Utc), false, 59.99m, null },
                    { 2, 1, new DateTime(2019, 8, 18, 10, 49, 23, 330, DateTimeKind.Utc).AddTicks(1645), new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 24.99m, null }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "UserId", "GameId", "CreatedAt", "Description", "IsDeleted", "Rating", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 8, 18, 10, 49, 23, 330, DateTimeKind.Utc).AddTicks(4448), "This is a really good game! You should get it too!", false, 8, null },
                    { 2, 1, new DateTime(2019, 8, 18, 10, 49, 23, 330, DateTimeKind.Utc).AddTicks(5217), "It's a good game, but I don't like \"surprise mechanics\".", false, 6, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_CompanyId",
                table: "Games",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_GameTags_TagId",
                table: "GameTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Libraries_GameId",
                table: "Libraries",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_GameId",
                table: "Purchases",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_GameId",
                table: "Reviews",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_Name",
                table: "Tags",
                column: "Name",
                unique: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameTags");

            migrationBuilder.DropTable(
                name: "Libraries");

            migrationBuilder.DropTable(
                name: "Purchases");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
