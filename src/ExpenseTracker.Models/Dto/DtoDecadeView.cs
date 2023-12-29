using System.Collections.Generic;

namespace ExpenseTracker.Models.Dto
{
    public class DtoDecadeViewOld
    {
        public List<string> SubCategory { get; set; }
        public List<string> Category { get; set; }
        public List<decimal> Year2022 { get; set; }
        public List<decimal> Year2023 { get; set; }

    }


    public class DtoDecadeView
    {
        public List<CategoryData> Categories { get; set; }

        public DtoDecadeView()
        {
            Categories = new List<CategoryData>();
        }
    }

    public class CategoryData
    {
        public string CategoryName { get; set; }
        public List<SubCategoryData> SubCategories { get; set; }

        public CategoryData()
        {
            SubCategories = new List<SubCategoryData>();
        }
    }

    public class SubCategoryData
    {
        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public decimal Year2022 { get; set; }
        public decimal Year2023 { get; set; }
    }


}
