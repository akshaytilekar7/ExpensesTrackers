using Microsoft.EntityFrameworkCore.Migrations;

namespace PatternForCore.Core.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Donation', 'Family security')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Health insurance', 'Family security')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Office parent HI', 'Family security')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Term insurance', 'Family security')");

            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Trip', 'Lifestyle')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Akshay Pragati cash', 'Lifestyle')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Cloths', 'Lifestyle')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Office', 'Lifestyle')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Petrol/Service', 'Lifestyle')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Salon/Parolor', 'Lifestyle')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Hoteling', 'Lifestyle')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Snakcs', 'Lifestyle')");

            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Internet', 'Home expenses')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Cash aai papa   ', 'Home expenses')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Medical', 'Home expenses')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Mobile recharge', 'Home expenses')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Society fees', 'Home expenses')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Tata sky', 'Home expenses')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Electricity', 'Home expenses')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Gas', 'Home expenses')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Groceries (kirana)', 'Home expenses')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Home tax', 'Home expenses')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Home cash', 'Home expenses')");

            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Others', 'Home expenses')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
