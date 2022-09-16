using Microsoft.EntityFrameworkCore.Migrations;

namespace PatternForCore.Core.Migrations
{
    public partial class InitialTables2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Hosiptal RD', 'Investment')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('SIP', 'Investment')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Loan', 'Investment')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Gold', 'Investment')");
            migrationBuilder.Sql("INSERT INTO Category ([CategoryName],[ExpensesType]) Values ('Axis', 'Investment')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
