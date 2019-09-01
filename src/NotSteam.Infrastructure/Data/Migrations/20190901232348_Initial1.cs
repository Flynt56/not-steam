using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NotSteam.Infrastructure.Data.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Nickname = table.Column<string>(maxLength: 32, nullable: true),
                    ProfileImageUri = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
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
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 48, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
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
                    DeletedAt = table.Column<DateTime>(nullable: true)
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
                    DeletedAt = table.Column<DateTime>(nullable: true),
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
                        name: "FK_Libraries_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
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
                    DeletedAt = table.Column<DateTime>(nullable: true),
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
                        name: "FK_Purchases_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
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
                    DeletedAt = table.Column<DateTime>(nullable: true),
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
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nickname", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUri", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, null, new DateTime(1996, 4, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Player123@gmail.com", true, false, null, "xXSlayerXx", null, null, null, null, false, "https://cdn.notsteam.com/images/1", null, false, null },
                    { 2, 0, null, new DateTime(1992, 2, 12, 0, 0, 0, 0, DateTimeKind.Utc), "NobodyReally@outlook.com", true, false, null, "Sgt. Harry", null, null, null, null, false, "https://cdn.notsteam.com/images/2", null, false, null },
                    { 3, 0, null, new DateTime(1989, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc), "SampleText@gmail.com", true, false, null, "Mr.Boom", null, null, null, null, false, "https://cdn.notsteam.com/images/3", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "HomepageUri", "LogoImageUri", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 9, 1, 23, 23, 48, 37, DateTimeKind.Utc).AddTicks(1539), null, "We make really cool games!", "https://www.methesda-softworks.com", "https://cdn.notsteam.com/images/101", "Methesda Softworks Inc.", null },
                    { 2, new DateTime(2019, 9, 1, 23, 23, 48, 37, DateTimeKind.Utc).AddTicks(2934), null, "We make tech demos!", "https://www.crymearivertek.com", "https://cdn.notsteam.com/images/102", "CryMeARiverTek GmbH", null },
                    { 3, new DateTime(2019, 9, 1, 23, 23, 48, 37, DateTimeKind.Utc).AddTicks(2946), null, "We make great action-adventure, role-playing games!", "https://www.dvd-projekt-blue.com", "https://cdn.notsteam.com/images/103", "DVD Projekt Blue", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 9, 1, 23, 23, 48, 37, DateTimeKind.Utc).AddTicks(7620), null, "This item contains single-player content (e.g. campaign, story mode, etc.)", "Single-Player", null },
                    { 2, new DateTime(2019, 9, 1, 23, 23, 48, 37, DateTimeKind.Utc).AddTicks(8853), null, "This item contains multi-player content. Requires an internet connection.", "Multi-Player", null },
                    { 3, new DateTime(2019, 9, 1, 23, 23, 48, 37, DateTimeKind.Utc).AddTicks(8865), null, "This item contains ce-op content. Requires an internet connection. A limited amount of players can group up and play!", "Co-Op", null }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "BasePrice", "CompanyId", "CreatedAt", "DeletedAt", "Description", "ReleaseDate", "Title", "UpdatedAt" },
                values: new object[] { 2, 79.99m, 1, new DateTime(2019, 9, 1, 23, 23, 48, 38, DateTimeKind.Utc).AddTicks(6703), null, "What we really want from EA.", new DateTime(2018, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Need for Speed: Underground 3", null });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "BasePrice", "CompanyId", "CreatedAt", "DeletedAt", "Description", "ReleaseDate", "Title", "UpdatedAt" },
                values: new object[] { 3, 69.69m, 2, new DateTime(2019, 9, 1, 23, 23, 48, 38, DateTimeKind.Utc).AddTicks(6715), null, "One of these days…", new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Age of Empires 4", null });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "BasePrice", "CompanyId", "CreatedAt", "DeletedAt", "Description", "ReleaseDate", "Title", "UpdatedAt" },
                values: new object[] { 1, 59.99m, 3, new DateTime(2019, 9, 1, 23, 23, 48, 38, DateTimeKind.Utc).AddTicks(5164), null, "New year, new game!", new DateTime(2019, 6, 22, 0, 0, 0, 0, DateTimeKind.Utc), "C4ll of $$$$: Covert Ops", null });

            migrationBuilder.InsertData(
                table: "GameTags",
                columns: new[] { "GameId", "TagId", "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2019, 9, 1, 23, 23, 48, 39, DateTimeKind.Utc).AddTicks(2543), null, null },
                    { 2, 2, new DateTime(2019, 9, 1, 23, 23, 48, 39, DateTimeKind.Utc).AddTicks(2544), null, null },
                    { 2, 3, new DateTime(2019, 9, 1, 23, 23, 48, 39, DateTimeKind.Utc).AddTicks(2545), null, null },
                    { 3, 1, new DateTime(2019, 9, 1, 23, 23, 48, 39, DateTimeKind.Utc).AddTicks(2546), null, null },
                    { 1, 1, new DateTime(2019, 9, 1, 23, 23, 48, 39, DateTimeKind.Utc).AddTicks(1219), null, null },
                    { 1, 2, new DateTime(2019, 9, 1, 23, 23, 48, 39, DateTimeKind.Utc).AddTicks(2531), null, null }
                });

            migrationBuilder.InsertData(
                table: "Libraries",
                columns: new[] { "UserId", "GameId", "CreatedAt", "DateAcquired", "DeletedAt", "LastPlayedDate", "TotalPlayTimeHours", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2019, 9, 1, 23, 23, 48, 39, DateTimeKind.Utc).AddTicks(9415), new DateTime(2019, 9, 1, 23, 23, 48, 39, DateTimeKind.Utc).AddTicks(9414), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 1, 1, new DateTime(2019, 9, 1, 23, 23, 48, 39, DateTimeKind.Utc).AddTicks(8085), new DateTime(2019, 7, 20, 0, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2019, 9, 1, 23, 23, 48, 39, DateTimeKind.Utc).AddTicks(8084), 20, null },
                    { 2, 1, new DateTime(2019, 9, 1, 23, 23, 48, 39, DateTimeKind.Utc).AddTicks(9489), new DateTime(2019, 7, 18, 0, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2019, 9, 1, 23, 23, 48, 39, DateTimeKind.Utc).AddTicks(9489), 1079, null }
                });

            migrationBuilder.InsertData(
                table: "Purchases",
                columns: new[] { "UserId", "GameId", "CreatedAt", "DateOfPurchase", "DeletedAt", "TotalPrice", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2019, 9, 1, 23, 23, 48, 40, DateTimeKind.Utc).AddTicks(6282), new DateTime(2019, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), null, 64.99m, null },
                    { 1, 1, new DateTime(2019, 9, 1, 23, 23, 48, 40, DateTimeKind.Utc).AddTicks(4942), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Utc), null, 59.99m, null },
                    { 2, 1, new DateTime(2019, 9, 1, 23, 23, 48, 40, DateTimeKind.Utc).AddTicks(6295), new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, 24.99m, null }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "UserId", "GameId", "CreatedAt", "DeletedAt", "Description", "Rating", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 9, 1, 23, 23, 48, 40, DateTimeKind.Utc).AddTicks(9864), null, "This is a really good game! You should get it too!", 8, null },
                    { 2, 1, new DateTime(2019, 9, 1, 23, 23, 48, 41, DateTimeKind.Utc).AddTicks(1287), null, "It's a good game, but I don't like \"surprise mechanics\".", 6, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "GameTags");

            migrationBuilder.DropTable(
                name: "Libraries");

            migrationBuilder.DropTable(
                name: "Purchases");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
