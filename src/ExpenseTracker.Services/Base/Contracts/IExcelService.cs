using System.Data;

namespace ExpenseTracker.Services.Base.Contracts
{
    public interface IExcelService
    {
        DataTable LoadDataTable(string filePath);

        DataTable ConvertExcelToDataTable(string filePath, bool isXlsx = false);

        DataTable ConvertCsvToDataTable(string filePath);
    }
}
