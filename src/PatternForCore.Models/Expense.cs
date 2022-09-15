// https://github.com/senvardarsemih/generic-for-core

using System;

namespace PatternForCore.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public DateTime Date
        {
            get { return new DateTime(Year, Month, Day); }
            private set
            {
               value = new DateTime(Year, Month, Day);
            }
        }
        public Category Category { get; set; }
        public SubCategory SubCategory { get; set; }
        public int Amount { get; set; }
    }
}
