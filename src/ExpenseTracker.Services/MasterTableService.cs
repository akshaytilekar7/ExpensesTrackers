using System.Collections.Generic;
using ExpenseTracker.Core.Uow;
using System.Linq;
using ExpenseTracker.Models;
using ExpenseTracker.Services.Base.Contracts;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace ExpenseTracker.Services
{
    public class MasterTableService : IMasterTableService
    {
        private readonly IUnitOfWork _unitOfWork;
        public MasterTableService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<CategoryType> GetAllCategoryType()
        {
            var repository = _unitOfWork.GetRepository<CategoryType>();
            return repository.GetAll("ExpenseType").OrderBy(x => x.Name).ToList();
        }

        public List<ExpenseType> GetAllExpenseType()
        {
            var repository = _unitOfWork.GetRepository<ExpenseType>();
            return repository.GetAll().OrderBy(x => x.Name).ToList();
        }

        public void SaveExpenseType(List<ExpenseType> ExpenseTypes)
        {
            var repository = _unitOfWork.GetRepository<ExpenseType>();
            var dbExpenseType = repository.GetAll();

            foreach (var item in ExpenseTypes)
            {
                if (item.Id <= 0)
                {
                    repository.Add(item);
                }
                else if (dbExpenseType.Any(x => x.Id == item.Id))
                {
                    repository.Update(item);
                }
                _unitOfWork.Commit();
            }
        }

        public void SaveCategoryType(List<CategoryType> CategoryTypes)
        {
            var repository = _unitOfWork.GetRepository<CategoryType>();
            var dbCategoryTypes = repository.GetAll();

            foreach (var item in CategoryTypes)
            {
                if (item.Id <= 0)
                {
                    repository.Add(item);
                }
                else if (dbCategoryTypes.Any(x => x.Id == item.Id))
                {
                    repository.Update(item);
                }

                _unitOfWork.Commit();
            }
        }

    }
}
