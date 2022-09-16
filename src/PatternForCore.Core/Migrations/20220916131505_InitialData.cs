using Microsoft.EntityFrameworkCore.Migrations;

namespace PatternForCore.Core.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Cash Akshay Pragati', 'Home expenses')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Cash Aai Pappa','Family security')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Fruit','Lifestyle')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
