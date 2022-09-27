using System.Collections.Generic;

namespace PatternForCore.Models.Dto
{
    public class DtoYealry
    {
        public string Category { get; set; }
        public int Jan { get; set; }
        public string JanTooltip = "JanTooltip 1";
        public IEnumerable<Expense> JanLst = null;

        public int Feb { get; set; }
        public string FebTooltip = "JanTooltip 2";
        public IEnumerable<Expense> FebLst = null;

        public int March { get; set; }
        public string MarchTooltip = "JanTooltip3";
        public IEnumerable<Expense> MarchLst = null;

        public int April { get; set; }
        public string AprilTooltip = "JanTooltip4";
        public IEnumerable<Expense> AprilLst = null;

        public int May { get; set; }
        public string MayTooltip = "JanTooltip5";
        public IEnumerable<Expense> MayLst = null;

        public int June { get; set; }
        public string JuneTooltip = "JanTooltip6";
        public IEnumerable<Expense> JuneLst = null;

        public int July { get; set; }
        public string JulyTooltip = "JanTooltip7";
        public IEnumerable<Expense> JulyLst = null;

        public int August { get; set; }
        public string AugustTooltip = "JanTooltip8";
        public IEnumerable<Expense> AugustLst = null;

        public int September { get; set; }
        public string SeptemberTooltip = "JanTooltip9";
        public IEnumerable<Expense> SeptemberLst = null;

        public int October { get; set; }
        public string OctoberTooltip = "JanTooltip10";
        public IEnumerable<Expense> OctoberLst = null;

        public int November { get; set; }
        public string NovemberTooltip = "JanTooltip11";
        public IEnumerable<Expense> NovemberLst = null;

        public int December { get; set; }
        public string DecemberTooltip = "JanTooltip12";
        public IEnumerable<Expense> DecemberLst = null;
        public int CatogoryTotal { get; set; }

    }

}
