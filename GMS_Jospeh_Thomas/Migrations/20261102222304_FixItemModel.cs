using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GMS_Jospeh_Thomas.Migrations
{
    /// <inheritdoc />
    public partial class FixItemModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemInfos");

            migrationBuilder.CreateTable(
                name: "ItemInfo",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemInfo", x => x.ItemId);
                });

            migrationBuilder.InsertData(
                table: "ItemInfo",
                columns: new[] { "ItemId", "Category", "Name", "Price", "PurchaseDate", "Quantity" },
                values: new object[,]
                {
                    { 1, 0, "Milk", 4.99m, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 },
                    { 2, 0, "Cheese", 8.49m, new DateTime(2026, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 3, 1, "Chicken", 12.99m, new DateTime(2026, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 4, 1, "Ground Beef", 10.75m, new DateTime(2026, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 5, 2, "Potato Crisps", 3.49m, new DateTime(2026, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { 6, 2, "Chocolate Bar", 1.99m, new DateTime(2026, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 150 },
                    { 7, 3, "Sourdough Bread", 5.25m, new DateTime(2026, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 8, 3, "Raspberry Muffin", 2.50m, new DateTime(2026, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { 9, 4, "Gala Apples", 0.99m, new DateTime(2026, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 200 },
                    { 10, 4, "Spinach", 3.99m, new DateTime(2026, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemInfo");

            migrationBuilder.CreateTable(
                name: "ItemInfos",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemInfos", x => x.ItemId);
                });
        }
    }
}
