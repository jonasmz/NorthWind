using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NorthWind.Sales.Backend.DataContexts.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerId = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 5, nullable: false),
                    ShipAddress = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    ShipCity = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    ShipCountry = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    ShipPostalCode = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    ShippingType = table.Column<int>(type: "INTEGER", nullable: false),
                    DiscountType = table.Column<int>(type: "INTEGER", nullable: false),
                    Discount = table.Column<double>(type: "REAL", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "TEXT", precision: 8, scale: 2, nullable: false),
                    Quantity = table.Column<short>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
