using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTracker.Core.Migrations
{
    public partial class UserAndBankData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

        INSERT INTO [dbo].[User]
                   ([Name]
                   ,[Email]
                   ,[CreatedDate])
             VALUES
                   ('Akshay',
                   'akshaytilekar7@gmail.com',
                   null);

        INSERT INTO [dbo].[User]
                   ([Name]
                   ,[Email]
                   ,[CreatedDate])
             VALUES
                   ('Pragati',
                   'capragatin@gmail.com',
                   null);


        INSERT INTO [dbo].[Bank]
                   ([Name]
                   ,[UserId]
                   ,[CreatedDate])
             VALUES
                   ('ICICI',
                   1,
                   null);


        INSERT INTO [dbo].[Bank]
                   ([Name]
                   ,[UserId]
                   ,[CreatedDate])
             VALUES
                   ('AXIS',
                   1,
                   null);


         INSERT INTO [dbo].[Bank]
                   ([Name]
                   ,[UserId]
                   ,[CreatedDate])
             VALUES
                   ('HDFC',
                   2,
                   null);

         INSERT INTO [dbo].[Bank]
                   ([Name]
                   ,[UserId]
                   ,[CreatedDate])
             VALUES
                   ('Bank Of Baroda',
                   2,
                   null);

    ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
