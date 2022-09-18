using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Reflection;

namespace PatternForCore.Core.ExcelUtility
{

    public interface IExcelService
    {
        System.Data.DataTable LoadDataTable(string filePath);

        System.Data.DataTable ConvertExcelToDataTable(string filePath, bool isXlsx = false);

        System.Data.DataTable ConvertCsvToDataTable(string filePath);
    }
    public class ExcelService : IExcelService
    {
        public System.Data.DataTable LoadDataTable(string filePath)
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

        public System.Data.DataTable ConvertExcelToDataTable(string filePath, bool isXlsx = false)
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

        public System.Data.DataTable ConvertCsvToDataTable(string filePath)
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

    public static class Extenstions
    {
        public static IList<T> DatatableToClass<T>(this System.Data.DataTable Table) where T : class, new()
        {
            Type classType = typeof(T);
            IList<PropertyInfo> propertyList = classType.GetProperties();

            // Parameter class has no public properties.
            if (propertyList.Count == 0)
                return new List<T>();

            List<string> columnNames = Table.Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToList();

            List<T> result = new List<T>();
            try
            {
                foreach (DataRow row in Table.Rows)
                {
                    T classObject = new T();
                    foreach (PropertyInfo property in propertyList)
                    {
                        if (property != null && property.CanWrite)   // Make sure property isn't read only
                        {
                            if (columnNames.Contains(property.Name))  // If property is a column name
                            {
                                if (row[property.Name] != System.DBNull.Value)   // Don't copy over DBNull
                                {
                                    object propertyValue = System.Convert.ChangeType(
                                            row[property.Name],
                                            property.PropertyType
                                        );
                                    property.SetValue(classObject, propertyValue, null);
                                }
                            }
                        }
                    }
                    result.Add(classObject);
                }
                return result;
            }
            catch
            {
                return new List<T>();
            }
        }
    }
}


