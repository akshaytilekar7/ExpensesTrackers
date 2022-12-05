using ExpenseTracker.Core.Uow;
using ExpenseTracker.Services.Base.Contracts;

namespace ExpenseTracker.Services.Factory
{
    public class ServiceFactory : IServiceFactory
    {
        private readonly IUnitOfWork _unitOfWork;

        public ServiceFactory(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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
    }
}
