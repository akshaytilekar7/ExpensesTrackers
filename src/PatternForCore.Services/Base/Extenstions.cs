using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace PatternForCore.Services.Base
{
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
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
