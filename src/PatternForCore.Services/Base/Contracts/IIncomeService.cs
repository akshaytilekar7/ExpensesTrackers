using PatternForCore.Models;
using System.Collections.Generic;

namespace PatternForCore.Services.Base.Contracts
{
    public interface IIncomeService
    {
        bool Add(IncomeSource item);
        IList<IncomeSource> GetAll();
        void Delete(List<IncomeSource> lst);

    }
}
