using System.Collections.Generic;

namespace PatternForCore.Models.Dto
{
    public class CategoryTags
    {
        public string CategoryName { get; set; }
        public List<string> Tags { get; set; }

        public static List<CategoryTags> GetTags()
        {
            var CategoryTags = new List<CategoryTags>()
            {
                new CategoryTags()
                {
                    CategoryName = "Hotel/outing",
                    Tags = new List<string>()
                    {
                        "hotel",
                        "ice",
                        "ice cream",
                    }
                },
                new CategoryTags()
                {
                    CategoryName = "Snacks",
                    Tags = new List<string>()
                    {
                        "vada",
                        "wada",
                        "idli",
                        "pani puri",
                        "panipuri",
                        "bhel",
                        "nira",
                        "pav",
                        "pav bhaji",
                        "misal pav",
                        "misal",
                        "pohe",
                        "chick",
                        "khichade",
                        "dosa",
                        "pizza",
                        "burger",
                        "mac d",
                        "macd",
                        "peter",
                        "peter cafe",
                        "ccd",
                        "chaha",
                        "tea",
                        "coffee",
                    }
                },
                 new CategoryTags()
                {
                    CategoryName = "Travel - cab",
                    Tags = new List<string>()
                    {
                        "ola",
                        "auto",
                        "riksha",
                        "cab",
                        "bus",
                    }
                },
                  new CategoryTags()
                {
                    CategoryName = "Medical/Hospital",
                    Tags = new List<string>()
                    {
                        "dr",
                        "doctor",
                        "hospital",
                        "medicine",
                        "medicle",
                        "medicines",
                    }
                },
                   new CategoryTags()
                {
                    CategoryName = "Fruit",
                    Tags = new List<string>()
                    {
                        "naral",
                        "naral pani",
                        "fruit",
                        "fruits"
                    }
                },
                    new CategoryTags()
                {
                    CategoryName = "Bike - Petrol/Service",
                    Tags = new List<string>()
                    {
                        "petrol",
                        "air",
                        "hawa",
                        "service",
                        "servicing",
                        "puncture",
                    }
                },
                      new CategoryTags()
                {
                    CategoryName = "Salon/Parlour",
                    Tags = new List<string>()
                    {
                        "cutting",
                        "parlour",
                        "parlor",
                        "makeup",
                    }
                }
            };

            return CategoryTags;
        }
    }
}
