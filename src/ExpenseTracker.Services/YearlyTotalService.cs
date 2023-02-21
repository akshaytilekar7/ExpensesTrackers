using System.Collections.Generic;
using ExpenseTracker.Core.Uow;
using System.Linq;
using ExpenseTracker.Models;
using ExpenseTracker.Services.Base.Contracts;
using ExpenseTracker.Models.Dto;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Data;
using System;
using ExpenseTracker.Services.Factory;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using ExpenseTracker.Core;

namespace ExpenseTracker.Services
{
    public class YearlyTotalService : IYearlyTotalService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOptions<MyConfig> myConfig;
        private readonly ServiceFactory _serviceFactory;
        public YearlyTotalService(IUnitOfWork unitOfWork, IOptions<MyConfig> myConfig)
        {
            _unitOfWork = unitOfWork;
            this.myConfig = myConfig;
            _serviceFactory = new ServiceFactory(_unitOfWork, myConfig);
        }

        public List<DtoYealryTotal> GetYearlyData()
        {
            var repoYealyTotal = _unitOfWork.GetRepository<YealyTotal>();
            var yearlyData = repoYealyTotal.GetAll();

            List<DtoYealryTotal> dtoYealries = new List<DtoYealryTotal>();

            foreach (var year in yearlyData)
            {
                DtoYealryTotal dtoYealry = new DtoYealryTotal();
                dtoYealry.Category = year.CategoryType;
                dtoYealry.ExpenseType = year.ExpenseType;
                dtoYealry.Year2022 = Convert.ToDecimal(year.Year2022);
                dtoYealry.Year2023 = Convert.ToDecimal(year.Year2023);
                dtoYealry.Total = dtoYealry.Year2022 + dtoYealry.Year2023;
                dtoYealries.Add(dtoYealry);
            }

            return dtoYealries.OrderBy(x => x.Category).ToList();
        }

        public async Task<List<DtoExpense>> GetYearlyForTooltip(int year, string category)
        {
            // var _serviceFactory = new ServiceFactory(new UnitOfWork(new SpecialContextFactory(myConfig, year)), myConfig);
            var _categoryRepository = _unitOfWork.GetRepository<CategoryType>();
            CategoryType dbCategory = _categoryRepository.FindBy(x => x.Name == category).FirstOrDefault();
            if (dbCategory == null)
                return new List<DtoExpense>();

            DtoExpenseFilter dtoExpenseFilter = new DtoExpenseFilter()
            {
                CategoryId = dbCategory.Id,
                StartDate = new DateTime(year, 1, 1),
                EndDate = new DateTime(year, 12, 31),
            };

            var lstDtoExpense = await _serviceFactory.ExpenseServices.GetExpenseFilter(dtoExpenseFilter);
            return lstDtoExpense;
        }
    }
}
