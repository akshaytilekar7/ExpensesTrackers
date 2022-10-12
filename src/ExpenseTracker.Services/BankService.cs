using System.Collections.Generic;
using ExpenseTracker.Core.Uow;
using System.Linq;
using ExpenseTracker.Services.Base.Contracts;
using ExpenseTracker.Models;

namespace ExpenseTracker.Services
{
    public class BankService : IBankService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BankService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        List<Bank> IBankService.GetAll()
        {
            var banks = _unitOfWork.GetRepository<Bank>().GetAll().ToList();
            return banks;
        }
    }
}
