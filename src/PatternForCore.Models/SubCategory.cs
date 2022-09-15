// https://github.com/senvardarsemih/generic-for-core

namespace PatternForCore.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public Category Category { get; set; }

    }
}
