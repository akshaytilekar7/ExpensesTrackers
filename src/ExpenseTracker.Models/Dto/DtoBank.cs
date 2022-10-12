using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Models.Dto
{
    public class DtoBank
    {
        public string Lable { get; set; }
        public int Amount { get; set; }

    }

    public class DtoBankAmount
    {
        public string BankName { get; set; }
        public int Amount { get; set; }
        public int Expense { get; set; }
        public int Balance { get; set; }

    }
}
