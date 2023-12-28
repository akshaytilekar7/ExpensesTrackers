using System.Collections.Generic;
using ExpenseTracker.Models;

namespace ExpenseTracker.Services.Base.Contracts
{
    public interface IMasterTableService
    {
        List<Category> GetAllCategory();

        List<SubCategory> GetAllSubCategory();

        public void AddCategory(List<Category> lst);

        public void AddSubCategory(List<SubCategory> lst);

    }
}