using System.Collections.Generic;

namespace ExpenseTracker.Models.Dto
{
    public class DtoYealry
    {
        public string Category { get; set; }
        public int Jan { get; set; }

        public IEnumerable<Expense> JanLst  = null;

        public int Feb { get; set; }

        public IEnumerable<Expense> FebLst = null;

        public int March { get; set; }

        public IEnumerable<Expense> MarchLst = null;

        public int April { get; set; }

        public IEnumerable<Expense> AprilLst = null;

        public int May { get; set; }

        public IEnumerable<Expense> MayLst = null;

        public int June { get; set; }

        public IEnumerable<Expense> JuneLst = null;

        public int July { get; set; }

        public IEnumerable<Expense> JulyLst = null;

        public int August { get; set; }

        public IEnumerable<Expense> AugustLst = null;

        public int September { get; set; }

        public IEnumerable<Expense> SeptemberLst = null;

        public int October { get; set; }

        public IEnumerable<Expense> OctoberLst = null;

        public int November { get; set; }
        public IEnumerable<Expense> NovemberLst = null;

        public int December { get; set; }

        public IEnumerable<Expense> DecemberLst = null;

        public int CatogoryTotal { get; set; }

    }

}
