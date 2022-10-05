﻿using System.Collections.Generic;

namespace PatternForCore.Models.Dto
{
    public class ExcelYearly
    {
        public List<DtoExpense> dtoExpenses { get; set; }
        public string Name { get; set; }

    }

    public class ExcelYearlyExpenseByCategory
    {
        public ExcelYearlyExpenseByCategory()
        {
            dtoExpenseByCategories = new List<DtoExpenseByCategory>();
        }
        public List<DtoExpenseByCategory> dtoExpenseByCategories { get; set; }

        public string Name { get; set; }

    }
    public enum Months
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
}