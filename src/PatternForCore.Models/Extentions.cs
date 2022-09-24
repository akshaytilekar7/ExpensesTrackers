using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PatternForCore.Models
{
    public static class Extentions
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
    }
}
