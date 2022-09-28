using PatternForCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternForCore.Services.Base.Contracts
{
    public interface ICategoryServices
    {
        bool Add(MasterCategoryType movieItem);
        IList<MasterCategoryType> GetAll();
    }
}
