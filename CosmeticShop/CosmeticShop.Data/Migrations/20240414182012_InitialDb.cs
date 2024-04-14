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
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SendingDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Text = table.Column<string>(type: "TEXT", nullable: false),
                    ToId = table.Column<string>(type: "TEXT", nullable: false),
                    ToName = table.Column<string>(type: "TEXT", nullable: false),
                    FromId = table.Column<string>(type: "TEXT", nullable: false),
                    FromName = table.Column<string>(type: "TEXT", nullable: false),
                    IsRead = table.Column<bool>(type: "INTEGER", nullable: false),
                    RelatedId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
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
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
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
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderNumber = table.Column<string>(type: "TEXT", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Note = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentType = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderState = table.Column<int>(type: "INTEGER", nullable: false),
                    ConversationId = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
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
                name: "ShoppingCartItems",
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
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0123cd7a-3ccb-43e7-b3ad-0faa4e49dcbf", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" },
                    { "05f30794-ff2e-4377-9d46-80b0b296a165", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" },
                    { "f8626d43-ee81-48bd-9da2-270512d29c1a", null, "Müşteri haklarını taşıyan rol", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8742dbdd-e949-44fe-8f1e-3054f743669c", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "1b10aa06-f02c-4166-a645-75164eb5b211", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAEH1UMU/dvmkHvyN+DhNUOXgfCF4+KI7s9k43erbGVolWf8edie5kBCAwKCIPJaJ5DA==", "5387996655", false, "547a9f9a-6c18-4551-ad65-e5e8a4e71714", false, "aysenumay" },
                    { "8a7e663b-95b0-49e7-99d0-d2c0e92d3262", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "89af4471-d32f-4a3d-ad85-a6ba2ad910ad", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAEK4hMmTySBZb0USHF3NtZkUOLwnhuujlbB0qH1DmbNLAA89oSlYrCkuRTn3YWIKRFg==", "5387996655", false, "0bc0c9a0-6579-4e32-b068-abdee1f80ce9", false, "selinmete" },
                    { "ae5c0669-de3d-4a51-83af-f40c6a73dec4", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "9135e8f2-07bf-48ce-97d5-c290963b8490", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEGSY9kxxqxk196FERmu6ERDUutgJmUPZo1jc/jcRHChwC4rk0C955TTbltes5GO4Ww==", "5387996655", false, "3965e7da-7aa0-4274-9e56-1189aa6f643e", false, "kemaldurukan" },
                    { "fb33ef56-a115-4ec6-ac81-20c2daa71398", 0, "Güngören İstanbul", "İstanbul", "6fdd369d-eaa5-4332-b524-75d28ff082eb", new DateTime(2002, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "surmelimehmet@gmail.com", true, "Mehmet", "Erkek", "Sürmeli", false, null, "SURMELIMEHMET@GMAIL.COM", "SURMELIMEHMET", "AQAAAAIAAYagAAAAEDvOezlwAwAUKhXpqr9T5QGLnSd/RBB9/CyTNy5GzbnsebhcLg0ORxEk5Pf1Sgf8HQ==", "5552225533", false, "c3ca1938-df0c-426a-aea3-9569781d36b4", false, "surmelimehmet" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryDescription", "CreatedDate", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Parfüm Kategorisi", new DateTime(2024, 4, 14, 21, 20, 12, 533, DateTimeKind.Local).AddTicks(3486), true, false, new DateTime(2024, 4, 14, 21, 20, 12, 533, DateTimeKind.Local).AddTicks(3492), "Parfüm", "parfum" },
                    { 2, "Ruj Kategorisi", new DateTime(2024, 4, 14, 21, 20, 12, 533, DateTimeKind.Local).AddTicks(3496), true, false, new DateTime(2024, 4, 14, 21, 20, 12, 533, DateTimeKind.Local).AddTicks(3496), "Ruj", "ruj" },
                    { 3, "Oje Kategorisi", new DateTime(2024, 4, 14, 21, 20, 12, 533, DateTimeKind.Local).AddTicks(3498), true, false, new DateTime(2024, 4, 14, 21, 20, 12, 533, DateTimeKind.Local).AddTicks(3498), "Oje", "oje" },
                    { 4, "Krem Kategorisi", new DateTime(2024, 4, 14, 21, 20, 12, 533, DateTimeKind.Local).AddTicks(3499), true, false, new DateTime(2024, 4, 14, 21, 20, 12, 533, DateTimeKind.Local).AddTicks(3499), "Krem", "krem" },
                    { 5, "Göz Makyajı Kategorisi", new DateTime(2024, 4, 14, 21, 20, 12, 533, DateTimeKind.Local).AddTicks(3500), true, false, new DateTime(2024, 4, 14, 21, 20, 12, 533, DateTimeKind.Local).AddTicks(3500), "Göz Makyajı", "goz-makyaji" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "IsActive", "IsDeleted", "IsHome", "ModifiedDate", "Name", "Price", "Properties", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 14, 21, 20, 12, 534, DateTimeKind.Local).AddTicks(1608), "1.png", true, false, true, new DateTime(2024, 4, 14, 21, 20, 12, 534, DateTimeKind.Local).AddTicks(1612), "Diorm Sauvage EDP", 13000m, "Mükemmel bir parfüm", "dior-sauvage" },
                    { 2, new DateTime(2024, 4, 14, 21, 20, 12, 534, DateTimeKind.Local).AddTicks(1621), "2.png", true, false, false, new DateTime(2024, 4, 14, 21, 20, 12, 534, DateTimeKind.Local).AddTicks(1621), "Avon Full Speed", 69000m, "Mükemmel parfüm", "avon-full-speed" },
                    { 3, new DateTime(2024, 4, 14, 21, 20, 12, 534, DateTimeKind.Local).AddTicks(1623), "3.png", true, false, true, new DateTime(2024, 4, 14, 21, 20, 12, 534, DateTimeKind.Local).AddTicks(1623), "Tom Ford Bois Marocain Eau de Parfum 250 Ml", 29000m, "İdare eder", "tom-ford-bois-marocain" },
                    { 4, new DateTime(2024, 4, 14, 21, 20, 12, 534, DateTimeKind.Local).AddTicks(1624), "4.png", true, false, true, new DateTime(2024, 4, 14, 21, 20, 12, 534, DateTimeKind.Local).AddTicks(1625), "Givenchy Gentleman Boisee Eau de Parfum EDP 200 Ml", 39000m, "Harika bir parfüm", "givenchy-gentlemen-boisee" },
                    { 5, new DateTime(2024, 4, 14, 21, 20, 12, 534, DateTimeKind.Local).AddTicks(1627), "5.png", true, false, true, new DateTime(2024, 4, 14, 21, 20, 12, 534, DateTimeKind.Local).AddTicks(1627), "Dior Fahrenheit / Erkek Parfüm", 52000m, "Harika bir parfüm", "dior-fahrenheit" },
                    { 6, new DateTime(2024, 4, 14, 21, 20, 12, 534, DateTimeKind.Local).AddTicks(1628), "6.png", true, false, false, new DateTime(2024, 4, 14, 21, 20, 12, 534, DateTimeKind.Local).AddTicks(1629), "Blvgari BVLGARI Man Wood Essence - Eau de Parfum 150ml", 79000m, "harika bir parfüm", "blvgari-man-vood" },
                    { 7, new DateTime(2024, 4, 14, 21, 20, 12, 534, DateTimeKind.Local).AddTicks(1630), "7.png", true, false, true, new DateTime(2024, 4, 14, 21, 20, 12, 534, DateTimeKind.Local).AddTicks(1630), "Creed Aventus Edp 100 ml Erkek Parfüm", 19000m, "harika bir parfüm", "creed-aventus-edp" },
                    { 8, new DateTime(2024, 4, 14, 21, 20, 12, 534, DateTimeKind.Local).AddTicks(1632), "8.png", true, false, false, new DateTime(2024, 4, 14, 21, 20, 12, 534, DateTimeKind.Local).AddTicks(1638), "Parfums De Marly Pegasus Exclusif Edp 125 ml", 21000m, "Süper bir parfüm", "parfums-de-marly-pegasus" },
                    { 9, new DateTime(2024, 4, 14, 21, 20, 12, 534, DateTimeKind.Local).AddTicks(1650), "9.png", true, false, true, new DateTime(2024, 4, 14, 21, 20, 12, 534, DateTimeKind.Local).AddTicks(1651), "Tom Ford Tobacco Vanille Eau de Parfum 50 Ml", 1250m, "Klasik sevenler için", "tom-ford-tobacco-vanille" },
                    { 10, new DateTime(2024, 4, 14, 21, 20, 12, 534, DateTimeKind.Local).AddTicks(1652), "10.png", true, false, true, new DateTime(2024, 4, 14, 21, 20, 12, 534, DateTimeKind.Local).AddTicks(1652), "Spice Bomb Extreme", 2100m, "Dayanılmaz koku", "spice-bomb-extreme" },
                    { 11, new DateTime(2024, 4, 14, 21, 20, 12, 534, DateTimeKind.Local).AddTicks(1654), "11.png", true, false, true, new DateTime(2024, 4, 14, 21, 20, 12, 534, DateTimeKind.Local).AddTicks(1654), "Paco Rabanne Invictus EDT Erkek Parfüm, 100 ml", 9800m, "Dünya klasiği dayanılmaz koku", "paco-rabanne-invictus" }
                });

            migrationBuilder.InsertData(
                table: "ShoppingCarts",
                columns: new[] { "Id", "CreatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 14, 21, 20, 12, 532, DateTimeKind.Local).AddTicks(8560), "fb33ef56-a115-4ec6-ac81-20c2daa71398" },
                    { 2, new DateTime(2024, 4, 14, 21, 20, 12, 532, DateTimeKind.Local).AddTicks(8586), "8a7e663b-95b0-49e7-99d0-d2c0e92d3262" },
                    { 3, new DateTime(2024, 4, 14, 21, 20, 12, 532, DateTimeKind.Local).AddTicks(8587), "ae5c0669-de3d-4a51-83af-f40c6a73dec4" },
                    { 4, new DateTime(2024, 4, 14, 21, 20, 12, 532, DateTimeKind.Local).AddTicks(8588), "8742dbdd-e949-44fe-8f1e-3054f743669c" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f8626d43-ee81-48bd-9da2-270512d29c1a", "8742dbdd-e949-44fe-8f1e-3054f743669c" },
                    { "05f30794-ff2e-4377-9d46-80b0b296a165", "8a7e663b-95b0-49e7-99d0-d2c0e92d3262" },
                    { "05f30794-ff2e-4377-9d46-80b0b296a165", "ae5c0669-de3d-4a51-83af-f40c6a73dec4" },
                    { "0123cd7a-3ccb-43e7-b3ad-0faa4e49dcbf", "fb33ef56-a115-4ec6-ac81-20c2daa71398" }
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
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ShoppingCartId",
                table: "ShoppingCartItems",
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
                name: "Messages");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
