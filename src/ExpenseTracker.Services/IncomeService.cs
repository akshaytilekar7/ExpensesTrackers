using System;
using System.Collections.Generic;
using ExpenseTracker.Core.Uow;
using System.Linq;
using ExpenseTracker.Services.Base.Contracts;
using ExpenseTracker.Models;
using System.Linq.Expressions;
using ExpenseTracker.Models.Dto;

namespace ExpenseTracker.Services
{
    public class IncomeService : IIncomeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public IncomeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool Add(IncomeSource item)
        {
            bool result = false;
            try
            {
                if (item != null)
                {
                    var movieRepository = _unitOfWork.GetRepository<IncomeSource>();
                    movieRepository.Add(item);
                    _unitOfWork.Commit();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return result;
        }

        public void Delete(List<IncomeSource> lst)
        {
            var repository = _unitOfWork.GetRepository<IncomeSource>();
            foreach (var item in lst)
                repository.HardDelete(item);
            _unitOfWork.Commit();
        }

        public IList<DtoIncome> GetAll()
        {
            List<Expression<Func<IncomeSource, object>>> includers = new List<Expression<Func<IncomeSource, object>>>();
            includers.Add(x => x.User);
            includers.Add(x => x.Bank);
            var lstUsers = _unitOfWork.GetRepository<IncomeSource>().GetAll(includers).ToList();
            return lstUsers.Select(x => new DtoIncome()
            {
                Amount = x.Amount,
                BankName = x.Bank.Name,
                Date = x.Date,
                Id = x.Id,
                UserName = x.User.Name
            }).ToList();
        }

        public List<DtoIncome> GetIncome(DateTime startDate, DateTime endDate)
        {
            IEnumerable<DtoIncome> lst = GetAll().Where(x => x.Date >= startDate && x.Date <= endDate);
            return lst.ToList();
        }
    }
}
