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
                    { "3efe0038-2392-4001-ac62-c68fdac20b20", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" },
                    { "4d9f7b78-3df9-4a45-9deb-de7d9a064b3d", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" },
                    { "8df9ed60-4b6a-4133-8176-a5a007939b41", null, "Müşteri haklarını taşıyan rol", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "21caa738-c0e9-4b45-9793-03d9cf2320e0", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "dbd96f8a-ac24-4dcb-9b06-70f08b50e142", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEMx0ZkRjYkVEo1C0rKcwVYhO7irOFVt81z+oLxkYve5Zwtq0EcGMJGGZ7dgVePY+Yw==", "5558779966", false, "910865b2-168c-4481-bf6f-93480a8a9d4e", false, "denizfoca" },
                    { "7f026021-58eb-4d4b-8101-73a5cca611b0", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "ee438376-8d4b-48b7-a7d5-b1e05527ea63", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAELDmh7cwEBEZ3Z7NQCw/82jAnWdbtDfDrZgGGMXrYhNjiGCuZ5/1yVk6jMbkoGNFBg==", "5387996655", false, "badea97e-5d30-4e13-988e-e87ea5dd490a", false, "kemaldurukan" },
                    { "cd67b29b-a7eb-46c6-85d3-31a0d148ba79", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "5c63acb0-0137-49d2-91e0-ebcccf18420d", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAEM5nhXY9EOZp0fTFZJ7CrsacA9azejHZlcCvX2HVfh1NMP3uGtVdHl4lNPj4yjuF8A==", "5387996655", false, "b5f916be-8685-4fe9-95aa-30691197e30f", false, "aysenumay" },
                    { "e888e62b-6d04-4bae-9b08-f6ac65ff680b", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "502565c6-954e-4d1f-9e3d-0f49c8d06161", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAECh/hV53YvMQyuyps4xf/CqpHsAdxdL7e+mZyJzzndtbDjvkJsFBV5rh1XL/ROuxIA==", "5387996655", false, "1452c1db-b6df-43d0-a8e0-d36dd6510423", false, "selinmete" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryDescription", "CreatedDate", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Parfüm Kategorisi", new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(2979), false, false, new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(2990), "Parfüm", "parfum" },
                    { 2, "Ruj Kategorisi", new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(2996), false, false, new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(2997), "Ruj", "ruj" },
                    { 3, "Oje Kategorisi", new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(2998), false, false, new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(2998), "Oje", "oje" },
                    { 4, "Krem Kategorisi", new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(2999), false, false, new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(2999), "Krem", "krem" },
                    { 5, "Göz Makyajı Kategorisi", new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(3000), false, false, new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(3000), "Göz Makyajı", "goz-makyajı" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "IsActive", "IsDeleted", "IsHome", "ModifiedDate", "Name", "Price", "Properties", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(7606), "1.png", false, false, true, new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(7610), "Diorm Sauvage EDP", 13000m, "Mükemmel bir parfüm", "dior-sauvage" },
                    { 2, new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(7617), "2.png", false, false, false, new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(7617), "Avon Full Speed", 69000m, "Mükemmel parfüm", "avon-full-speed" },
                    { 3, new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(7618), "3.png", false, false, true, new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(7619), "Tom Ford Bois Marocain Eau de Parfum 250 Ml", 29000m, "İdare eder", "tom-ford-bois-marocain" },
                    { 4, new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(7620), "4.png", false, false, true, new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(7621), "Givenchy Gentleman Boisee Eau de Parfum EDP 200 Ml", 39000m, "Harika bir parfüm", "givenchy-gentlemen-boisee" },
                    { 5, new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(7622), "5.png", false, false, true, new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(7622), "Dior Fahrenheit / Erkek Parfüm", 52000m, "Harika bir parfüm", "dior-fahrenheit" },
                    { 6, new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(7623), "6.png", false, false, false, new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(7624), "Blvgari BVLGARI Man Wood Essence - Eau de Parfum 150ml", 79000m, "harika bir parfüm", "blvgari-man-vood" },
                    { 7, new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(7625), "7.png", false, false, true, new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(7625), "Creed Aventus Edp 100 ml Erkek Parfüm", 19000m, "harika bir parfüm", "creed-aventus-edp" },
                    { 8, new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(7626), "8.png", false, false, false, new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(7631), "Parfums De Marly Pegasus Exclusif Edp 125 ml", 21000m, "Süper bir parfüm", "parfums-de-marly-pegasus" },
                    { 9, new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(7661), "9.png", false, false, true, new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(7662), "Tom Ford Tobacco Vanille Eau de Parfum 50 Ml", 1250m, "Klasik sevenler için", "tom-ford-tobacco-vanille" },
                    { 10, new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(7663), "10.png", false, false, true, new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(7663), "Spice Bomb Extreme", 2100m, "Dayanılmaz koku", "spice-bomb-extreme" },
                    { 11, new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(7665), "11.png", false, false, true, new DateTime(2024, 3, 19, 15, 32, 8, 459, DateTimeKind.Local).AddTicks(7665), "Paco Rabanne Invictus EDT Erkek Parfüm, 100 ml", 9800m, "Dünya klasiği dayanılmaz koku", "paco-rabanne-invictus" }
                });

            migrationBuilder.InsertData(
                table: "ShoppingCart",
                columns: new[] { "Id", "CreatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 19, 15, 32, 8, 454, DateTimeKind.Local).AddTicks(8673), "21caa738-c0e9-4b45-9793-03d9cf2320e0" },
                    { 2, new DateTime(2024, 3, 19, 15, 32, 8, 454, DateTimeKind.Local).AddTicks(8751), "e888e62b-6d04-4bae-9b08-f6ac65ff680b" },
                    { 3, new DateTime(2024, 3, 19, 15, 32, 8, 454, DateTimeKind.Local).AddTicks(8753), "7f026021-58eb-4d4b-8101-73a5cca611b0" },
                    { 4, new DateTime(2024, 3, 19, 15, 32, 8, 454, DateTimeKind.Local).AddTicks(8754), "cd67b29b-a7eb-46c6-85d3-31a0d148ba79" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4d9f7b78-3df9-4a45-9deb-de7d9a064b3d", "21caa738-c0e9-4b45-9793-03d9cf2320e0" },
                    { "3efe0038-2392-4001-ac62-c68fdac20b20", "7f026021-58eb-4d4b-8101-73a5cca611b0" },
                    { "8df9ed60-4b6a-4133-8176-a5a007939b41", "cd67b29b-a7eb-46c6-85d3-31a0d148ba79" },
                    { "3efe0038-2392-4001-ac62-c68fdac20b20", "e888e62b-6d04-4bae-9b08-f6ac65ff680b" }
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
