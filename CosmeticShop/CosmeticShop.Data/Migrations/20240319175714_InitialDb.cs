using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CosmeticShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CategoryDescription = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "date('now')"),
                    Price = table.Column<decimal>(type: "real", nullable: false),
                    Properties = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "date('now')"),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
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
                name: "ProductCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    ShoppingCartId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItem_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItem_ShoppingCart_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "06db5e59-dd7b-407a-8a96-d9050b10ba04", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" },
                    { "5fcde580-987e-4008-a445-2cab118242c2", null, "Müşteri haklarını taşıyan rol", "Customer", "CUSTOMER" },
                    { "8b90e8f7-baf5-4624-ba14-8080d72fc5ab", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "27196054-ff0d-4cc9-b94b-f5db85b17836", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "a92aae12-c92e-4040-93dc-2289f8e1acd7", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEIJ7qnObBh7ssi97+cHEjcmvlvz+5Z93ZtPG9UZdXWz5ZDMz8V6bLZTNLedcQA8VdA==", "5558779966", false, "2b5f9cd6-7b5a-451d-8b76-a2306d3d0f5a", false, "denizfoca" },
                    { "2bedcf20-6315-447a-8453-2a5b02e3e368", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "c9636e01-ca4b-4ea6-a14c-f7038724453e", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEBH8VeK0zAQCsIBpr+QO4YW7kV0Nmvt65m7m/iEdPszHK0M1VXEBP6MClSJ2QO89nw==", "5387996655", false, "fadf8664-60b8-4a89-a132-8939162caf20", false, "kemaldurukan" },
                    { "f342cdaa-f5cf-40f8-996d-45481869b8f8", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "7778f66c-b1b5-4632-803e-2427db5fd6fb", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAEEEP6hGfTugsbtNV+areYcpz72HnLPcZtDIAAsA05aTQEvqXv6+V2K2wjuvFCzPs6g==", "5387996655", false, "5cfe5ea8-8308-41dd-b535-8316933fd8d1", false, "selinmete" },
                    { "f368bc77-81f0-413b-91f1-b6c0562233b0", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "5c5e539d-8c52-4484-addc-0cc06d2a5a36", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAEKFDkWdARskCpIFZNHlRLY3ng1WqmCjtUNqDXe90ofZf8qa0Bdhg2vIax0mm15TjyA==", "5387996655", false, "826f8277-1695-4e95-9e71-2571e1381a9d", false, "aysenumay" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryDescription", "CreatedDate", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Parfüm Kategorisi", new DateTime(2024, 3, 19, 20, 57, 14, 74, DateTimeKind.Local).AddTicks(5526), false, false, new DateTime(2024, 3, 19, 20, 57, 14, 74, DateTimeKind.Local).AddTicks(5534), "Parfüm", "parfum" },
                    { 2, "Ruj Kategorisi", new DateTime(2024, 3, 19, 20, 57, 14, 74, DateTimeKind.Local).AddTicks(5537), false, false, new DateTime(2024, 3, 19, 20, 57, 14, 74, DateTimeKind.Local).AddTicks(5538), "Ruj", "ruj" },
                    { 3, "Oje Kategorisi", new DateTime(2024, 3, 19, 20, 57, 14, 74, DateTimeKind.Local).AddTicks(5539), false, false, new DateTime(2024, 3, 19, 20, 57, 14, 74, DateTimeKind.Local).AddTicks(5539), "Oje", "oje" },
                    { 4, "Krem Kategorisi", new DateTime(2024, 3, 19, 20, 57, 14, 74, DateTimeKind.Local).AddTicks(5540), false, false, new DateTime(2024, 3, 19, 20, 57, 14, 74, DateTimeKind.Local).AddTicks(5540), "Krem", "krem" },
                    { 5, "Göz Makyajı Kategorisi", new DateTime(2024, 3, 19, 20, 57, 14, 74, DateTimeKind.Local).AddTicks(5541), false, false, new DateTime(2024, 3, 19, 20, 57, 14, 74, DateTimeKind.Local).AddTicks(5541), "Göz Makyajı", "goz-makyajı" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "IsActive", "IsDeleted", "IsHome", "ModifiedDate", "Name", "Price", "Properties", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 19, 20, 57, 14, 75, DateTimeKind.Local).AddTicks(1280), "1.png", false, false, true, new DateTime(2024, 3, 19, 20, 57, 14, 75, DateTimeKind.Local).AddTicks(1283), "Diorm Sauvage EDP", 13000m, "Mükemmel bir parfüm", "dior-sauvage" },
                    { 2, new DateTime(2024, 3, 19, 20, 57, 14, 75, DateTimeKind.Local).AddTicks(1287), "2.png", false, false, false, new DateTime(2024, 3, 19, 20, 57, 14, 75, DateTimeKind.Local).AddTicks(1288), "Avon Full Speed", 69000m, "Mükemmel parfüm", "avon-full-speed" },
                    { 3, new DateTime(2024, 3, 19, 20, 57, 14, 75, DateTimeKind.Local).AddTicks(1289), "3.png", false, false, true, new DateTime(2024, 3, 19, 20, 57, 14, 75, DateTimeKind.Local).AddTicks(1290), "Tom Ford Bois Marocain Eau de Parfum 250 Ml", 29000m, "İdare eder", "tom-ford-bois-marocain" },
                    { 4, new DateTime(2024, 3, 19, 20, 57, 14, 75, DateTimeKind.Local).AddTicks(1291), "4.png", false, false, true, new DateTime(2024, 3, 19, 20, 57, 14, 75, DateTimeKind.Local).AddTicks(1292), "Givenchy Gentleman Boisee Eau de Parfum EDP 200 Ml", 39000m, "Harika bir parfüm", "givenchy-gentlemen-boisee" },
                    { 5, new DateTime(2024, 3, 19, 20, 57, 14, 75, DateTimeKind.Local).AddTicks(1293), "5.png", false, false, true, new DateTime(2024, 3, 19, 20, 57, 14, 75, DateTimeKind.Local).AddTicks(1294), "Dior Fahrenheit / Erkek Parfüm", 52000m, "Harika bir parfüm", "dior-fahrenheit" },
                    { 6, new DateTime(2024, 3, 19, 20, 57, 14, 75, DateTimeKind.Local).AddTicks(1295), "6.png", false, false, false, new DateTime(2024, 3, 19, 20, 57, 14, 75, DateTimeKind.Local).AddTicks(1295), "Blvgari BVLGARI Man Wood Essence - Eau de Parfum 150ml", 79000m, "harika bir parfüm", "blvgari-man-vood" },
                    { 7, new DateTime(2024, 3, 19, 20, 57, 14, 75, DateTimeKind.Local).AddTicks(1296), "7.png", false, false, true, new DateTime(2024, 3, 19, 20, 57, 14, 75, DateTimeKind.Local).AddTicks(1297), "Creed Aventus Edp 100 ml Erkek Parfüm", 19000m, "harika bir parfüm", "creed-aventus-edp" },
                    { 8, new DateTime(2024, 3, 19, 20, 57, 14, 75, DateTimeKind.Local).AddTicks(1298), "8.png", false, false, false, new DateTime(2024, 3, 19, 20, 57, 14, 75, DateTimeKind.Local).AddTicks(1302), "Parfums De Marly Pegasus Exclusif Edp 125 ml", 21000m, "Süper bir parfüm", "parfums-de-marly-pegasus" },
                    { 9, new DateTime(2024, 3, 19, 20, 57, 14, 75, DateTimeKind.Local).AddTicks(1316), "9.png", false, false, true, new DateTime(2024, 3, 19, 20, 57, 14, 75, DateTimeKind.Local).AddTicks(1317), "Tom Ford Tobacco Vanille Eau de Parfum 50 Ml", 1250m, "Klasik sevenler için", "tom-ford-tobacco-vanille" },
                    { 10, new DateTime(2024, 3, 19, 20, 57, 14, 75, DateTimeKind.Local).AddTicks(1318), "10.png", false, false, true, new DateTime(2024, 3, 19, 20, 57, 14, 75, DateTimeKind.Local).AddTicks(1318), "Spice Bomb Extreme", 2100m, "Dayanılmaz koku", "spice-bomb-extreme" },
                    { 11, new DateTime(2024, 3, 19, 20, 57, 14, 75, DateTimeKind.Local).AddTicks(1319), "11.png", false, false, true, new DateTime(2024, 3, 19, 20, 57, 14, 75, DateTimeKind.Local).AddTicks(1320), "Paco Rabanne Invictus EDT Erkek Parfüm, 100 ml", 9800m, "Dünya klasiği dayanılmaz koku", "paco-rabanne-invictus" }
                });

            migrationBuilder.InsertData(
                table: "ShoppingCart",
                columns: new[] { "Id", "CreatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 19, 20, 57, 14, 71, DateTimeKind.Local).AddTicks(2629), "27196054-ff0d-4cc9-b94b-f5db85b17836" },
                    { 2, new DateTime(2024, 3, 19, 20, 57, 14, 71, DateTimeKind.Local).AddTicks(2655), "f342cdaa-f5cf-40f8-996d-45481869b8f8" },
                    { 3, new DateTime(2024, 3, 19, 20, 57, 14, 71, DateTimeKind.Local).AddTicks(2656), "2bedcf20-6315-447a-8453-2a5b02e3e368" },
                    { 4, new DateTime(2024, 3, 19, 20, 57, 14, 71, DateTimeKind.Local).AddTicks(2657), "f368bc77-81f0-413b-91f1-b6c0562233b0" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8b90e8f7-baf5-4624-ba14-8080d72fc5ab", "27196054-ff0d-4cc9-b94b-f5db85b17836" },
                    { "06db5e59-dd7b-407a-8a96-d9050b10ba04", "2bedcf20-6315-447a-8453-2a5b02e3e368" },
                    { "06db5e59-dd7b-407a-8a96-d9050b10ba04", "f342cdaa-f5cf-40f8-996d-45481869b8f8" },
                    { "5fcde580-987e-4008-a445-2cab118242c2", "f368bc77-81f0-413b-91f1-b6c0562233b0" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 5, 1 },
                    { 3, 2 },
                    { 5, 2 },
                    { 3, 3 },
                    { 5, 3 },
                    { 3, 4 },
                    { 5, 4 },
                    { 2, 5 },
                    { 3, 5 },
                    { 2, 6 },
                    { 3, 6 },
                    { 3, 7 },
                    { 4, 7 },
                    { 3, 8 },
                    { 4, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 4, 10 },
                    { 1, 11 },
                    { 3, 11 },
                    { 4, 11 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItem_ProductId",
                table: "ShoppingCartItem",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItem_ShoppingCartId",
                table: "ShoppingCartItem",
                column: "ShoppingCartId");
        }

        /// <inheritdoc />
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
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ShoppingCartItem");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ShoppingCart");
        }
    }
}
