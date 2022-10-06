using System.Collections.Generic;

namespace PatternForCore.Models.Dto
{
    public class DtoYealry
    {
        public string Category { get; set; }
        public int Jan { get; set; }

        public IEnumerable<Expense> JanLst { get; set; }

        public int Feb { get; set; }

        public IEnumerable<Expense> FebLst { get; set; }

        public int March { get; set; }

        public IEnumerable<Expense> MarchLst { get; set; }

        public int April { get; set; }

        public IEnumerable<Expense> AprilLst { get; set; }

        public int May { get; set; }

        public IEnumerable<Expense> MayLst { get; set; }

        public int June { get; set; }

        public IEnumerable<Expense> JuneLst { get; set; }

        public int July { get; set; }

        public IEnumerable<Expense> JulyLst { get; set; }

        public int August { get; set; }

        public IEnumerable<Expense> AugustLst { get; set; }

        public int September { get; set; }

        public IEnumerable<Expense> SeptemberLst { get; set; }

        public int October { get; set; }

        public IEnumerable<Expense> OctoberLst { get; set; }

        public int November { get; set; }
        public IEnumerable<Expense> NovemberLst { get; set; }

        public int December { get; set; }

        public IEnumerable<Expense> DecemberLst { get; set; }

        public int CatogoryTotal { get; set; }

    }

}
