using Microsoft.EntityFrameworkCore.Migrations;

namespace PatternForCore.Core.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Health insurance', 'Family security')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Parent Health insurance', 'Family security')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Term insurance', 'Family security')");

            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Trip', 'Lifestyle')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Cloths', 'Lifestyle')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Office', 'Lifestyle')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Bike - Petrol/Service', 'Lifestyle')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Salon/Parlour', 'Lifestyle')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Hotel/outing', 'Lifestyle')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Snacks', 'Lifestyle')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Akshay Pragati cash', 'Lifestyle')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Travel - cab', 'Lifestyle')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Donation', 'Lifestyle')");

            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Cash aai papa', 'Home expenses')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Internet', 'Home expenses')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Medical/Hospital', 'Home expenses')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Mobile recharge', 'Home expenses')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Society fees', 'Home expenses')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Tata sky', 'Home expenses')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Electricity/Light bill', 'Home expenses')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Gas', 'Home expenses')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Groceries (kirana)', 'Home expenses')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Income Tax', 'Home expenses')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Maid', 'Home expenses')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Fruit', 'Home expenses')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Others', 'Home expenses')");

            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Babycare', 'Child expense')");

            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Extra', 'Extra / unexpected')");

            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('RD', 'Investment')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('SIP', 'Investment')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Money given', 'Investment')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('EMI', 'Investment')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Gold', 'Investment')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Axis Saving', 'Investment')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
