using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StorageManager.Migrations
{
    /// <inheritdoc />
    public partial class check2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "checks",
                columns: table => new
                {
                    CheckSerie = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    payStatus = table.Column<bool>(type: "bit", nullable: false),
                    DateOfCheck = table.Column<DateOnly>(type: "date", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    FactorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_checks", x => x.CheckSerie);
                    table.ForeignKey(
                        name: "FK_checks_factors_FactorId",
                        column: x => x.FactorId,
                        principalTable: "factors",
                        principalColumn: "FactorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_checks_FactorId",
                table: "checks",
                column: "FactorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "checks");
        }
    }
}
