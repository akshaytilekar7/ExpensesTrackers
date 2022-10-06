using PatternForCore.Models;
using System.Collections.Generic;

namespace PatternForCore.Services.Base.Contracts
{
    public interface ICategoryServices
    {
        bool Add(MasterCategoryType item);
        IList<MasterCategoryType> GetAll();
    }
}
