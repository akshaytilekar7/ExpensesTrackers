using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTracker.Core.Migrations
{
    public partial class ExpesneTableStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expense_MasterCategoryType_CategoryId",
                table: "Expense");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Expense",
                newName: "MasterCategoryTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Expense_CategoryId",
                table: "Expense",
                newName: "IX_Expense_MasterCategoryTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expense_MasterCategoryType_MasterCategoryTypeId",
                table: "Expense",
                column: "MasterCategoryTypeId",
                principalTable: "MasterCategoryType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expense_MasterCategoryType_MasterCategoryTypeId",
                table: "Expense");

            migrationBuilder.RenameColumn(
                name: "MasterCategoryTypeId",
                table: "Expense",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Expense_MasterCategoryTypeId",
                table: "Expense",
                newName: "IX_Expense_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expense_MasterCategoryType_CategoryId",
                table: "Expense",
                column: "CategoryId",
                principalTable: "MasterCategoryType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
