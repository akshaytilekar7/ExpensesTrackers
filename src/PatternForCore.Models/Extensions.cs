using ExpenseTracker.Models.Dto;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExpenseTracker.Models
{
    public static class Extensions
    {
        public static string GetTooltipData(this IEnumerable<Expense> expenses)
        {
            var str = string.Empty;

            foreach (var item in expenses)
            {
                string monthName = item.Date.ToString("MMM", CultureInfo.InvariantCulture);
                str += item.Date.Day + " " + monthName + " " + item.Date.DayOfWeek.ToString() + " || " + item.Amount + " || " + item.Comment;
                str += "\n";
            }
            return str;
        }

        public static List<DtoExpense> GenereateSrNo(this List<DtoExpense> dtoExpenses)
        {
            int index = 1;
            for (int i = 0; i < dtoExpenses.Count; i++)

            {
                var x = index++;
                dtoExpenses[i].SrNo = x;
            }

            return dtoExpenses;
        }
    }
}
