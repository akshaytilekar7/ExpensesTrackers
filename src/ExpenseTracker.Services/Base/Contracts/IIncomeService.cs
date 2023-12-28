using ExpenseTracker.Models;
using ExpenseTracker.Models.Dto;
using System;
using System.Collections.Generic;

namespace ExpenseTracker.Services.Base.Contracts
{
    public interface IIncomeService
    {
        bool Add(Income item);
        void Delete(List<Income> lst);
        List<DtoIncome> GetIncome(DateTime startDate, DateTime endDate);

    }
}
