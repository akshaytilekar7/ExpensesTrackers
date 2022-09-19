using PatternForCore.Models;
using System.Collections.Generic;

namespace PatternForCore.Services.Base.Contracts
{
    public interface IIncomeService
    {
        bool Add(IncomeSource movieItem);
        IList<IncomeSource> GetAll();
    }
}
