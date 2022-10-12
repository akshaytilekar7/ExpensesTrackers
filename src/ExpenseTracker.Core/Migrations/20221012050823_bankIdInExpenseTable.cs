using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTracker.Core.Migrations
{
    public partial class bankIdInExpenseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BankId",
                table: "Expense",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Expense_BankId",
                table: "Expense",
                column: "BankId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expense_Bank_BankId",
                table: "Expense",
                column: "BankId",
                principalTable: "Bank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expense_Bank_BankId",
                table: "Expense");

            migrationBuilder.DropIndex(
                name: "IX_Expense_BankId",
                table: "Expense");

            migrationBuilder.DropColumn(
                name: "BankId",
                table: "Expense");
        }
    }
}
