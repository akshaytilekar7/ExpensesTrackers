using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTracker.Core.Migrations
{
    public partial class GetTransactionsByYear : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            CREATE PROCEDURE GetTransactionsByYear
            @year INT
            AS
            BEGIN
                 SELECT
                    c.[Name] as CategoryName,
					sc.[Name] as SubCategoryName,
                    SUM(CASE WHEN YEAR(trans.[Date]) = @year and MONTH(trans.[Date]) = 1 THEN trans.[Amount] ELSE 0 END) AS January,
                    SUM(CASE WHEN YEAR(trans.[Date]) = @year and MONTH(trans.[Date]) = 2 THEN trans.[Amount] ELSE 0 END) AS February,
                    SUM(CASE WHEN YEAR(trans.[Date]) = @year and MONTH(trans.[Date]) = 3 THEN trans.[Amount] ELSE 0 END) AS March,
                    SUM(CASE WHEN YEAR(trans.[Date]) = @year and MONTH(trans.[Date]) = 4 THEN trans.[Amount] ELSE 0 END) AS April,
                    SUM(CASE WHEN YEAR(trans.[Date]) = @year and MONTH(trans.[Date]) = 5 THEN trans.[Amount] ELSE 0 END) AS May,
                    SUM(CASE WHEN YEAR(trans.[Date]) = @year and MONTH(trans.[Date]) = 6 THEN trans.[Amount] ELSE 0 END) AS June,
                    SUM(CASE WHEN YEAR(trans.[Date]) = @year and MONTH(trans.[Date]) = 7 THEN trans.[Amount] ELSE 0 END) AS July,
                    SUM(CASE WHEN YEAR(trans.[Date]) = @year and MONTH(trans.[Date]) = 8 THEN trans.[Amount] ELSE 0 END) AS August,
                    SUM(CASE WHEN YEAR(trans.[Date]) = @year and MONTH(trans.[Date]) = 9 THEN trans.[Amount] ELSE 0 END) AS September,
                    SUM(CASE WHEN YEAR(trans.[Date]) = @year and MONTH(trans.[Date]) = 10 THEN trans.[Amount] ELSE 0 END) AS October,
                    SUM(CASE WHEN YEAR(trans.[Date]) = @year and MONTH(trans.[Date]) = 11 THEN trans.[Amount] ELSE 0 END) AS November,
                    SUM(CASE WHEN YEAR(trans.[Date]) = @year and MONTH(trans.[Date]) = 12 THEN trans.[Amount] ELSE 0 END) AS December
                    FROM
                    [dbo].[Transaction] trans INNER JOIN [dbo].[SubCategory] sc 
                    ON trans.[SubCategoryId] = sc.[Id]
                    INNER JOIN [dbo].[Category] c 
                    ON sc.[CategoryId] = c.[Id]
                    WHERE
                    YEAR(trans.[Date]) = @year 
                    GROUP BY
                    c.[Name], sc.[Name];
             END;
        ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
