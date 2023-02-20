using ExpenseTracker.Core;
using ExpenseTracker.Core.Uow;
using ExpenseTracker.Services.Base.Contracts;
using Microsoft.Extensions.Options;

namespace ExpenseTracker.Services.Factory
{
    public class ServiceFactory : IServiceFactory
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOptions<MyConfig> myConfig;

        public ServiceFactory(IUnitOfWork unitOfWork, IOptions<MyConfig> myConfig)
        {
            _unitOfWork = unitOfWork;
            this.myConfig = myConfig;
        }
        public ICategoryServices CategoryServices
        {
            get
            {
                return new CategoryServices(_unitOfWork);
            }
        }

        public IExpenseServices ExpenseServices
        {
            get
            {
                return new ExpenseServices(_unitOfWork);
            }
        }

        public IIncomeService IncomeService
        {
            get
            {
                return new IncomeService(_unitOfWork, this);
            }
        }

        public IExcelService ExcelService
        {
            get
            {
                return new ExcelService();
            }
        }

        public IYearlyService YearlyService
        {
            get
            {
                return new YearlyService(_unitOfWork);
            }
        }

        public IMasterTableService MasterTableService
        {
            get
            {
                return new MasterTableService(_unitOfWork);
            }
        }

        public IUserService UserService
        {
            get
            {
                return new UserService(_unitOfWork);
            }
        }

        public IBankService BankService
        {
            get
            {
                return new BankService(_unitOfWork);
            }
        }

        public IYearlyTotalService YearlyTotalService
        {
            get
            {
                return new YearlyTotalService(_unitOfWork, myConfig);
            }
        }
    }
}
