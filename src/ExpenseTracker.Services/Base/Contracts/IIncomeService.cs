using ExpenseTracker.Models;
using ExpenseTracker.Models.Dto;
using System;
using System.Collections.Generic;

namespace ExpenseTracker.Services.Base.Contracts
{
    public interface IIncomeService
    {
        bool Add(IncomeSource item);
        IList<DtoIncome> GetAll();
        void Delete(List<IncomeSource> lst);

        List<DtoIncome> GetIncome(DateTime startDate, DateTime endDate);


    }
}
