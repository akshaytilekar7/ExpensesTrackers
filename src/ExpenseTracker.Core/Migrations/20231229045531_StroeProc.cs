using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTracker.Core.Migrations
{
    public partial class StroeProc : Migration
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
                    sc.ExpectedAmount as ExpectedAmount,
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
                    c.[Name], sc.[Name],sc.ExpectedAmount ;
             END;
        ");


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

            migrationBuilder.Sql(@"
           CREATE PROCEDURE GetBanksSummaryForYear
                @Year INT
                AS
             BEGIN
                SELECT
                    b.Name AS BankName,
                    ISNULL(i.TotalIncome, 0) AS TotalIncome,
                    ISNULL(t.TotalTransaction, 0) AS TotalExpense,
                    ISNULL(i.TotalIncome, 0) - ISNULL(t.TotalTransaction, 0) AS Balance
                FROM
                    [dbo].[Bank] b
                LEFT JOIN (
                    SELECT
                        BankId,
                        SUM(Amount) AS TotalIncome
                    FROM
                        [dbo].[Income]
                    WHERE
                        YEAR(Date) = @Year
                    GROUP BY
                        BankId
                ) i ON b.Id = i.BankId
                LEFT JOIN (
                    SELECT
                        BankId,
                        SUM(Amount) AS TotalTransaction
                    FROM
                        [dbo].[Transaction]
                    WHERE
                        YEAR(Date) = @Year
                    GROUP BY
                        BankId
                ) t ON b.Id = t.BankId;
            END;
        ");


            migrationBuilder.Sql(@"
            CREATE PROCEDURE GetExpenseByCategoryForYear
                @Year INT
            AS
            BEGIN
                SELECT
                    SC.Name,
                    SUM(T.Amount) AS Year
                FROM
                    [dbo].[Transaction] T
                INNER JOIN
                    [dbo].[SubCategory] SC ON T.SubCategoryId = SC.Id
                WHERE
                    YEAR(T.Date) = @Year
                GROUP BY
                    SC.Name;
            END;

        ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
