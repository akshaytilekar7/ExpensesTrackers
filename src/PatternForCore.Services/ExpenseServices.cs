using System;
using System.Collections.Generic;
using PatternForCore.Core.Uow;
using System.Linq;
using PatternForCore.Models;
using PatternForCore.Services.Base.Contracts;

namespace PatternForCore.Services
{
    public class ExpenseServices : IExpenseServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExpenseServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool Add(Expense expense)
        {
            bool result = false;
            try
            {
                if (expense != null)
                {
                    var movieRepository = _unitOfWork.GetRepository<Expense>();
                    movieRepository.Add(expense);
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

        public void Add(List<Expense> lst)
        {
            var movieRepository = _unitOfWork.GetRepository<Expense>();
            foreach (var item in lst)
            {
                movieRepository.Add(item);
                _unitOfWork.Commit();
            }
        }

        public IList<Expense> GetAll()
        {
            var movieRepository = _unitOfWork.GetRepository<Expense>();
            return movieRepository.GetAll().OrderByDescending(x => x.Id).ToList();
        }
    }
}
