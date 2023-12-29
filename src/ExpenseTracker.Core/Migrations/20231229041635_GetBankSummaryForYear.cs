using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTracker.Core.Migrations
{
    public partial class GetBankSummaryForYear : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
           CREATE PROCEDURE GetBanksSummaryForYear
                @Year INT
                AS
                BEGIN
                    DECLARE @StartDate DATETIME = CAST(@Year AS VARCHAR) + '-01-01';
                    DECLARE @EndDate DATETIME = DATEADD(SECOND, -1, DATEADD(YEAR, 1, @StartDate));

                    SELECT
                        B.Name AS BankName,
                        ISNULL(SUM(I.Amount), 0) AS TotalIncome,
                        ISNULL(SUM(T.Amount), 0) AS TotalExpense,
                        ISNULL(SUM(I.Amount), 0) - ISNULL(SUM(T.Amount), 0) AS Balance
                    FROM
                        dbo.Bank B
                    LEFT JOIN
                        dbo.Income I ON B.Id = I.BankId AND I.Date BETWEEN @StartDate AND @EndDate
                    LEFT JOIN
                        dbo.[Transaction] T ON B.Id = T.BankId AND T.Date BETWEEN @StartDate AND @EndDate
                    GROUP BY
                        B.Id, B.Name
                    ORDER BY
                        B.Name;
                END;
        ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
