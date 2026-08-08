using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StorageManager.Migrations
{
    /// <inheritdoc />
    public partial class better : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "distributers",
                columns: table => new
                {
                    distributerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    firstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_distributers", x => x.distributerId);
                });

            migrationBuilder.CreateTable(
                name: "groupOfProducts",
                columns: table => new
                {
                    goupProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    groupName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_groupOfProducts", x => x.goupProductId);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    productId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    companyName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    goupProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.productId);
                    table.ForeignKey(
                        name: "FK_products_groupOfProducts_goupProductId",
                        column: x => x.goupProductId,
                        principalTable: "groupOfProducts",
                        principalColumn: "goupProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "factors",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DistributerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuyDate = table.Column<DateOnly>(type: "date", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_factors", x => new { x.ProductId, x.DistributerId });
                    table.ForeignKey(
                        name: "FK_factors_distributers_DistributerId",
                        column: x => x.DistributerId,
                        principalTable: "distributers",
                        principalColumn: "distributerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_factors_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "storages",
                columns: table => new
                {
                    StorageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuyPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SellPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExpiredDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_storages", x => x.StorageId);
                    table.ForeignKey(
                        name: "FK_storages_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_factors_DistributerId",
                table: "factors",
                column: "DistributerId");

            migrationBuilder.CreateIndex(
                name: "IX_products_goupProductId",
                table: "products",
                column: "goupProductId");

            migrationBuilder.CreateIndex(
                name: "IX_storages_ProductId",
                table: "storages",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "factors");

            migrationBuilder.DropTable(
                name: "storages");

            migrationBuilder.DropTable(
                name: "distributers");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "groupOfProducts");
        }
    }
}
