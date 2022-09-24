using System;
using System.Collections.Generic;
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
                str += item.Date.ToShortDateString() + " || " + item.Amount + " || " + item.Comment;
                str += "\n";
            }
            return str;
        }
    }
}
