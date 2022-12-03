using System.Collections.Generic;

namespace ExpenseTracker.Models.Dto
{
    public class DtoYealry
    {
        public string Category { get; set; }

        public string ExpenseType { get; set; }

        public decimal Jan { get; set; }

        public IEnumerable<Expense> JanLst  = null;

        public decimal Feb { get; set; }

        public IEnumerable<Expense> FebLst = null;

        public decimal March { get; set; }

        public IEnumerable<Expense> MarchLst = null;

        public decimal April { get; set; }

        public IEnumerable<Expense> AprilLst = null;

        public decimal May { get; set; }

        public IEnumerable<Expense> MayLst = null;

        public decimal June { get; set; }

        public IEnumerable<Expense> JuneLst = null;

        public decimal July { get; set; }

        public IEnumerable<Expense> JulyLst = null;

        public decimal August { get; set; }

        public IEnumerable<Expense> AugustLst = null;

        public decimal September { get; set; }

        public IEnumerable<Expense> SeptemberLst = null;

        public decimal October { get; set; }

        public IEnumerable<Expense> OctoberLst = null;

        public decimal November { get; set; }
        public IEnumerable<Expense> NovemberLst = null;

        public decimal December { get; set; }

        public IEnumerable<Expense> DecemberLst = null;

        public decimal CatogoryTotal { get; set; }

    }

}
