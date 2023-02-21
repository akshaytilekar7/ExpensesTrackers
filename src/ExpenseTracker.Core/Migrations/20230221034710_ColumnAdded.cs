using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTracker.Core.Migrations
{
    public partial class ColumnAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Year2024",
                table: "YealyTotal",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Year2025",
                table: "YealyTotal",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Year2026",
                table: "YealyTotal",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Year2027",
                table: "YealyTotal",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Year2028",
                table: "YealyTotal",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Year2029",
                table: "YealyTotal",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Year2030",
                table: "YealyTotal",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Year2024",
                table: "YealyTotal");

            migrationBuilder.DropColumn(
                name: "Year2025",
                table: "YealyTotal");

            migrationBuilder.DropColumn(
                name: "Year2026",
                table: "YealyTotal");

            migrationBuilder.DropColumn(
                name: "Year2027",
                table: "YealyTotal");

            migrationBuilder.DropColumn(
                name: "Year2028",
                table: "YealyTotal");

            migrationBuilder.DropColumn(
                name: "Year2029",
                table: "YealyTotal");

            migrationBuilder.DropColumn(
                name: "Year2030",
                table: "YealyTotal");
        }
    }
}
