namespace PatternForCore.Services.Base.Contracts
{
    public interface IExcelService
    {
        System.Data.DataTable LoadDataTable(string filePath);

        System.Data.DataTable ConvertExcelToDataTable(string filePath, bool isXlsx = false);

        System.Data.DataTable ConvertCsvToDataTable(string filePath);
    }
}
