using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTracker.Core.Migrations
{
    public partial class InitData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
GO
SET IDENTITY_INSERT [dbo].[Category] ON 
GO
INSERT [dbo].[Category] ([Id], [Name], [CreatedDate]) VALUES (1, N'Investment', CAST(N'2023-01-18T20:01:07.3835935' AS DateTime2))
GO
INSERT [dbo].[Category] ([Id], [Name], [CreatedDate]) VALUES (2, N'Lifestyle', CAST(N'2023-01-18T20:01:07.3835941' AS DateTime2))
GO
INSERT [dbo].[Category] ([Id], [Name], [CreatedDate]) VALUES (3, N'EMI', CAST(N'2023-01-18T20:01:07.3835947' AS DateTime2))
GO
INSERT [dbo].[Category] ([Id], [Name], [CreatedDate]) VALUES (4, N'Home Expenses', CAST(N'2023-01-18T20:01:07.3835954' AS DateTime2))
GO
INSERT [dbo].[Category] ([Id], [Name], [CreatedDate]) VALUES (5, N'Loan To Others', CAST(N'2023-01-18T20:01:07.3835963' AS DateTime2))
GO
INSERT [dbo].[Category] ([Id], [Name], [CreatedDate]) VALUES (6, N'Swapnangan', CAST(N'2023-01-18T20:01:07.3835970' AS DateTime2))
GO
INSERT [dbo].[Category] ([Id], [Name], [CreatedDate]) VALUES (7, N'Extra', CAST(N'2023-01-18T20:01:07.3835976' AS DateTime2))
GO
INSERT [dbo].[Category] ([Id], [Name], [CreatedDate]) VALUES (8, N'Lawyer Audumber', CAST(N'2023-01-18T20:01:07.3835982' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[SubCategory] ON 
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (1, N'Snacks', N' vada, wada, idli,pani puri,panipuri,bhel,nira,pav,pav bhaji,misal pav,misal,pohe,chick,khichade,dosa,pizza,burger,mac d,macd,peter,petercafe,ccd,chaha,tea,coffee,snacks,snack,sncks', 2, NULL, CAST(3000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (2, N'Hotel/outing', N'hotel', 2, NULL, CAST(3000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (3, N'FD', N'FD', 1, NULL, CAST(-1.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (4, N'Gold', N'GOLD', 1, NULL, CAST(5000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (5, N'EMI', N'EMI', 3, NULL, CAST(-1.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (6, N'Cash aai pappa', N'cash', 4, NULL, CAST(15000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (7, N'Cash Akshay Pragati', NULL, 2, NULL, CAST(5000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (8, N'Electricity/light bill', N'light bill,electricity', 4, NULL, CAST(1500.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (9, N'Gas', N'gas', 4, NULL, CAST(1500.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (10, N'Internet', N'internet', 4, NULL, CAST(900.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (11, N'Mobile recharge', N'mobile, recharge', 4, NULL, CAST(-1.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (12, N'Salon', N'cutting,parlour,parlor,makeup, baroda', 2, NULL, CAST(1500.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (13, N'Tata sky', N'tata sky', 4, NULL, CAST(-1.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (14, N'Term Insurance', NULL, 2, NULL, CAST(-1.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (15, N'Society Fees', NULL, 4, NULL, CAST(-1.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (16, N'Office', N'office,office', 2, NULL, CAST(-1.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (17, N'Movies', N'movies,movie', 2, NULL, CAST(-1.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (18, N'Petrol/Bike Servicng', N'petrol, air, hawa, service, servicing, puncture, hawa, hava', 2, NULL, CAST(3000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (19, N'Travel/cab', N' ola, auto, riksha, cab, bus', 2, NULL, CAST(-1.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (20, N'Hospital', N'dr,doctor,hospital', 4, NULL, CAST(-1.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (21, N'Medicines', N'medicine,medicle,medicines, medical', 4, NULL, CAST(-1.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (22, N'RD', N'RD', 1, NULL, CAST(20000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (23, N'SIP', N'SIP', 1, NULL, CAST(25500.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (24, N'Axis Saving', N'axis,saving,save', 1, NULL, NULL)
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (25, N'Groceries (kirana)', N'kirana, Groceries', 4, NULL, CAST(5000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (26, N'Fruits', N'naral,naral pani,fruit,fruits', 4, NULL, CAST(3500.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (27, N'Trip', NULL, 2, NULL, CAST(-1.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (28, N'Shopping', N'shop,shopping,shoping', 2, NULL, CAST(-1.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (29, N'Home tax', NULL, 4, NULL, CAST(-1.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (30, N'Health insurance', NULL, 2, NULL, CAST(-1.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (31, N'Donation', NULL, 2, NULL, CAST(-1.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (32, N'Receivable', NULL, 5, NULL, CAST(-1.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (33, N'Other', NULL, 1, NULL, CAST(-1.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (34, N'Swapnagan Flat', NULL, 6, NULL, CAST(-1.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (35, N'Swapnagan Extra Principal', NULL, 6, NULL, CAST(-1.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (36, N'Swapnagan EMI', NULL, 6, NULL, CAST(-1.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (37, N'Extra Expenses', NULL, 7, NULL, CAST(-1.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SubCategory] ([Id], [Name], [CommaSeparatedTags], [CategoryId], [CreatedDate], [ExpectedAmount]) VALUES (38, N'Audumber court case', NULL, 8, CAST(N'2023-01-18T20:01:07.3835877' AS DateTime2), CAST(-1.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[SubCategory] OFF
GO



        ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
