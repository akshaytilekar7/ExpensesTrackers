using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTracker.Core.Migrations
{
    public partial class GetTransactionByMonth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            CREATE PROCEDURE GetTransactionsByMonth
            @year INT,
            @month INT,
            @subCategoryId INT
            AS
            BEGIN
                   SELECT
                    trans.Amount,
                    b.Name as Bank,
                    trans.Comment,
                    c.[Name] as CategoryName,
                    sc.[Name] as SubCategoryName,
                    trans.CreatedDate
                    FROM
                    [dbo].[Transaction] trans INNER JOIN [dbo].[SubCategory] sc 
                    ON trans.[SubCategoryId] = sc.[Id]
                    INNER JOIN [dbo].[Category] c 
                    ON sc.[CategoryId] = c.[Id]
					INNER JOIN [dbo].Bank b
					ON b.Id = trans.BankId
                    WHERE
                        YEAR(trans.[Date]) = @year 
                    and MONTH(trans.[Date]) = @month
                    and sc.[id] = @subCategoryId
                    GROUP BY
                    trans.Amount,
                    b.Name,
                    trans.Comment,
                    c.[Name],
                    sc.[Name],
                    trans.CreatedDate
             END;
        ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
