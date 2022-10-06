using ExpenseTracker.Services.Base.Contracts;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace ExpenseTracker.Services
{
    
    public class ExcelService : IExcelService
    {
        public DataTable LoadDataTable(string filePath)
        {
            string fileExtension = Path.GetExtension(filePath);
            switch (fileExtension.ToLower())
            {
                case ".xlsx":
                    return ConvertExcelToDataTable(filePath, true);
                case ".xls":
                    return ConvertExcelToDataTable(filePath);
                case ".csv":
                    return ConvertCsvToDataTable(filePath);
                default:
                    return new System.Data.DataTable();
            }

        }

        public DataTable ConvertExcelToDataTable(string filePath, bool isXlsx = false)
        {
            string con = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";" + @"Extended Properties='Excel 8.0;HDR=Yes;'";
            var connection = new OleDbConnection(con);
            connection.Open();
            OleDbCommand command = new OleDbCommand("select * from [Sheet1$]", connection);
            OleDbDataReader dr = command.ExecuteReader();
            var dataTable = new System.Data.DataTable();
            dataTable.Load(dr);
            return dataTable;
        }

        public DataTable ConvertCsvToDataTable(string filePath)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            using (StreamReader sr = new StreamReader(filePath))
            {
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }

            }
            return dt;
        }
    }
   
}


