using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Reflection;

namespace PatternForCore.Services
{
    public interface IExcelInteropService
    {
        DataTable ConvertCsvToDataTable(string filePath);
        DataTable ConvertExcelToDataTable(string filePath, bool isXlsx = false);
        void CreateExcel(string fileName, string sheetName, DataTable dataTable);
        DataTable LoadDataTable(string filePath);
    }

    public class ExcelInteropService : IExcelInteropService
    {
        public void CreateExcel(string fileName, string sheetName, DataTable dataTable)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workBook;
            Microsoft.Office.Interop.Excel.Worksheet worKsheeT;
            Microsoft.Office.Interop.Excel.Range celLrangE;

            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                workBook = excel.Workbooks.Add(Type.Missing);

                worKsheeT = (Microsoft.Office.Interop.Excel.Worksheet)workBook.ActiveSheet;
                worKsheeT.Name = sheetName;

                worKsheeT.Range[worKsheeT.Cells[1, 1], worKsheeT.Cells[1, 8]].Merge();
                worKsheeT.Cells[1, 1] = "Student Report Card";
                worKsheeT.Cells.Font.Size = 15;

                int rowcount = 2;

                foreach (DataRow datarow in dataTable.Rows)
                {
                    rowcount += 1;
                    for (int i = 1; i <= dataTable.Columns.Count; i++)
                    {

                        if (rowcount == 3)
                        {
                            worKsheeT.Cells[2, i] = dataTable.Columns[i - 1].ColumnName;
                            worKsheeT.Cells.Font.Color = System.Drawing.Color.Black;

                        }

                        worKsheeT.Cells[rowcount, i] = datarow[i - 1].ToString();

                        if (rowcount > 3)
                        {
                            if (i == dataTable.Columns.Count)
                            {
                                if (rowcount % 2 == 0)
                                {
                                    celLrangE = worKsheeT.Range[worKsheeT.Cells[rowcount, 1], worKsheeT.Cells[rowcount, dataTable.Columns.Count]];
                                }
                            }
                        }
                    }
                }

                celLrangE = worKsheeT.Range[worKsheeT.Cells[1, 1], worKsheeT.Cells[rowcount, dataTable.Columns.Count]];
                celLrangE.EntireColumn.AutoFit();
                Microsoft.Office.Interop.Excel.Borders border = celLrangE.Borders;
                border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                border.Weight = 2d;


                celLrangE = worKsheeT.Range[worKsheeT.Cells[1, 1], worKsheeT.Cells[2, dataTable.Columns.Count]];

                workBook.SaveAs(fileName);
                workBook.Close();
                excel.Quit();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                worKsheeT = null;
                celLrangE = null;
                workBook = null;
            }
        }

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


