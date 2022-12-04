using System.Collections.Generic;
using ExpenseTracker.Core.Uow;
using System.Linq;
using ExpenseTracker.Services.Base.Contracts;
using ExpenseTracker.Models;

namespace ExpenseTracker.Services
{
    public class OpeningBalanceService : IOpeningBalancekService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OpeningBalanceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<OpeningBalance> GetAll(int year)
        {
            return _unitOfWork.GetRepository<OpeningBalance>().GetAll().Where(x => x.Year == year).ToList();
        }
    }
}
