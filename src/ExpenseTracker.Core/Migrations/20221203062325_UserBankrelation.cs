using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTracker.Core.Migrations
{
    public partial class UserBankrelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Bank",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bank_UserId",
                table: "Bank",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bank_User_UserId",
                table: "Bank",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bank_User_UserId",
                table: "Bank");

            migrationBuilder.DropIndex(
                name: "IX_Bank_UserId",
                table: "Bank");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Bank");
        }
    }
}
