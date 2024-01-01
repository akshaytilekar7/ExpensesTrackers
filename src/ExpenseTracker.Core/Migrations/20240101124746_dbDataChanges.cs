using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTracker.Core.Migrations
{
    public partial class dbDataChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "YealyTotal");

            migrationBuilder.AddColumn<decimal>(
                name: "ExpectedAmount",
                table: "TransactionByYear",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpectedAmount",
                table: "TransactionByYear");

            migrationBuilder.CreateTable(
                name: "YealyTotal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SubCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year2022 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year2023 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year2024 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Year2025 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Year2026 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Year2027 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Year2028 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Year2029 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Year2030 = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YealyTotal", x => x.Id);
                });
        }
    }
}
