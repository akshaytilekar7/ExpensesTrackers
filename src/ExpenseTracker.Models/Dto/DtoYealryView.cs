using System.Collections.Generic;

namespace ExpenseTracker.Models.Dto
{
    public class DtoYealryView
    {
        public string CategoryName { get; set; }

        public string SubCategoryName { get; set; }

        public decimal? ExpectedAmount { get; set; }

        public decimal Jan { get; set; }

        public IEnumerable<Transaction> JanLst  = null;

        public decimal Feb { get; set; }

        public IEnumerable<Transaction> FebLst = null;

        public decimal March { get; set; }

        public IEnumerable<Transaction> MarchLst = null;

        public decimal April { get; set; }

        public IEnumerable<Transaction> AprilLst = null;

        public decimal May { get; set; }

        public IEnumerable<Transaction> MayLst = null;

        public decimal June { get; set; }

        public IEnumerable<Transaction> JuneLst = null;

        public decimal July { get; set; }

        public IEnumerable<Transaction> JulyLst = null;

        public decimal August { get; set; }

        public IEnumerable<Transaction> AugustLst = null;

        public decimal September { get; set; }

        public IEnumerable<Transaction> SeptemberLst = null;

        public decimal October { get; set; }

        public IEnumerable<Transaction> OctoberLst = null;

        public decimal November { get; set; }
        public IEnumerable<Transaction> NovemberLst = null;

        public decimal December { get; set; }

        public IEnumerable<Transaction> DecemberLst = null;

        public decimal CatogoryTotal { get; set; }

    }

}
