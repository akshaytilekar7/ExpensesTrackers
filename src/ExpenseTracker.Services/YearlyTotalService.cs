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
using System.Linq.Expressions;
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

    }
}
