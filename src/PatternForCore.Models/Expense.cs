// https://github.com/senvardarsemih/generic-for-core

using System;

namespace PatternForCore.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int Amount { get; set; }
        public string Comment { get; set; }

    }
}
