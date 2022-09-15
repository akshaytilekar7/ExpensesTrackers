using Microsoft.EntityFrameworkCore.Migrations;

namespace PatternForCore.Core.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Category ([Name]) Values ('Cash Akshay Pragati')");
            migrationBuilder.Sql("INSERT INTO Category ([Name]) Values ('Cash Aai Pappa')");

            migrationBuilder.Sql("INSERT INTO Category ([Name]) Values ('Fruit')");
            migrationBuilder.Sql("INSERT INTO Category ([Name]) Values ('Cloth')");
            migrationBuilder.Sql("INSERT INTO Category ([Name]) Values ('Hotel')");
            migrationBuilder.Sql("INSERT INTO Category ([Name]) Values ('Snacks')");

            migrationBuilder.Sql("INSERT INTO Category ([Name]) Values ('Petrol & Servcing')");
            migrationBuilder.Sql("INSERT INTO Category ([Name]) Values ('Saloon')");

            migrationBuilder.Sql("INSERT INTO Category ([Name]) Values ('Groceries (kirana)')");
            migrationBuilder.Sql("INSERT INTO Category ([Name]) Values ('Gas')");
            migrationBuilder.Sql("INSERT INTO Category ([Name]) Values ('Light Bill')");
            migrationBuilder.Sql("INSERT INTO Category ([Name]) Values ('Tax')");
            migrationBuilder.Sql("INSERT INTO Category ([Name]) Values ('Internet')");
            migrationBuilder.Sql("INSERT INTO Category ([Name]) Values ('Tata Sky')");
            migrationBuilder.Sql("INSERT INTO Category ([Name]) Values ('Society Fee')");

            migrationBuilder.Sql("INSERT INTO Category ([Name]) Values ('Health insurance')");
            migrationBuilder.Sql("INSERT INTO Category ([Name]) Values ('Medical/Doctor')");
            migrationBuilder.Sql("INSERT INTO Category ([Name]) Values ('Term Insurance')");

            migrationBuilder.Sql("INSERT INTO Category ([Name]) Values ('Emi')");
            migrationBuilder.Sql("INSERT INTO Category ([Name]) Values ('RD')");
            migrationBuilder.Sql("INSERT INTO Category ([Name]) Values ('SIP')");
            migrationBuilder.Sql("INSERT INTO Category ([Name]) Values ('Share')");

            migrationBuilder.Sql("INSERT INTO Category ([Name]) Values ('Donation')");
            migrationBuilder.Sql("INSERT INTO Category ([Name]) Values ('Unknown')");
            migrationBuilder.Sql("INSERT INTO Category ([Name]) Values ('Trip')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
