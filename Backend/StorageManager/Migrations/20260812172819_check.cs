using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StorageManager.Migrations
{
    /// <inheritdoc />
    public partial class check : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_factors",
                table: "factors");

            migrationBuilder.AddColumn<Guid>(
                name: "FactorId",
                table: "factors",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_factors",
                table: "factors",
                column: "FactorId");

            migrationBuilder.CreateIndex(
                name: "IX_factors_ProductId_DistributerId",
                table: "factors",
                columns: new[] { "ProductId", "DistributerId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_factors",
                table: "factors");

            migrationBuilder.DropIndex(
                name: "IX_factors_ProductId_DistributerId",
                table: "factors");

            migrationBuilder.DropColumn(
                name: "FactorId",
                table: "factors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_factors",
                table: "factors",
                columns: new[] { "ProductId", "DistributerId" });
        }
    }
}
