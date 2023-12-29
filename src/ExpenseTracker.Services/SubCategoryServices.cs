using System.Collections.Generic;
using ExpenseTracker.Core.Uow;
using System.Linq;
using ExpenseTracker.Services.Base.Contracts;
using ExpenseTracker.Models;

namespace ExpenseTracker.Services
{
    public class SubCategoryServices : ISubCategoryServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public SubCategoryServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IList<SubCategory> GetAll()
        {
            var repo = _unitOfWork.GetRepository<SubCategory>();
            return repo.GetAll().OrderBy(x => x.Name).ToList();
        }
    }
}
