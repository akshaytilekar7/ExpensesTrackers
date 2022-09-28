using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatternForCore.Core.Migrations
{
    public partial class IdAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MasterCategoryType_MasterExpenseType_MasterExpenseTypeId",
                table: "MasterCategoryType");

            migrationBuilder.AlterColumn<int>(
                name: "MasterExpenseTypeId",
                table: "MasterCategoryType",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterCategoryType_MasterExpenseType_MasterExpenseTypeId",
                table: "MasterCategoryType",
                column: "MasterExpenseTypeId",
                principalTable: "MasterExpenseType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MasterCategoryType_MasterExpenseType_MasterExpenseTypeId",
                table: "MasterCategoryType");

            migrationBuilder.AlterColumn<int>(
                name: "MasterExpenseTypeId",
                table: "MasterCategoryType",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_MasterCategoryType_MasterExpenseType_MasterExpenseTypeId",
                table: "MasterCategoryType",
                column: "MasterExpenseTypeId",
                principalTable: "MasterExpenseType",
                principalColumn: "Id");
        }
    }
}
