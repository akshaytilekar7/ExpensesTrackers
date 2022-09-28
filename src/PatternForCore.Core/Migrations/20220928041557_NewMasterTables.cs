using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatternForCore.Core.Migrations
{
    public partial class NewMasterTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MasterExpenseType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterExpenseType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterCategoryType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterExpenseTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterCategoryType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MasterCategoryType_MasterExpenseType_MasterExpenseTypeId",
                        column: x => x.MasterExpenseTypeId,
                        principalTable: "MasterExpenseType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MasterCategoryType_MasterExpenseTypeId",
                table: "MasterCategoryType",
                column: "MasterExpenseTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasterCategoryType");

            migrationBuilder.DropTable(
                name: "MasterExpenseType");
        }
    }
}
