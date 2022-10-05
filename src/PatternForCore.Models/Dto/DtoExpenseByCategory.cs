﻿namespace PatternForCore.Models.Dto
{
    public class DtoExpenseByCategory
    {
        public DtoExpenseByCategory(string month)
        {
            Month = month;
        }

        public string ExpensesType { get; set; }
        public int Amount { get; set; }
        public string Percent { get; set; }
        public string Month { get; set; }

    }

}
