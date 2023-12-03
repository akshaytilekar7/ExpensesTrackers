using ExpenseTracker.Models;
using ExpenseTracker.Models.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpenseTracker.Services.Base.Contracts
{
    public interface IBankService
    {
        List<Bank> GetAll();

        Task<List<DtoBank>> GetBankData(DateTime startDate, DateTime endDate);
    }
}