using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace GrouponDesktop.Sql
{
    public class Adapter
    {
        public IList<T> TransformMany<T>(DataTable dataTable)
        {
            return dataTable.Rows
                .Cast<DataRow>()
                .Select(row => this.Transform<T>(row))
                .ToList();
        }

        public T Transform<T>(DataRow dataRow)
        {
            var entity = Activator.CreateInstance<T>();

            var columnNames = dataRow.Table.Columns
                .Cast<DataColumn>()
                .Select(c => c.ColumnName);

            var properties = typeof (T).GetProperties();

            foreach (var property in columnNames.Select(columnName => properties.Single(p => p.Name == columnName)))
                property.SetValue(entity, this.ConvertValue(dataRow, property), null);
 
            return entity;
        }

        public IEnumerable<SqlParameter> CreateParametersFrom(Dictionary<string, object> values)
        {
            return values.Select(x => new SqlParameter(x.Key, x.Value) { Direction = ParameterDirection.InputOutput });
        }

        public IEnumerable<SqlParameter> CreateParametersFrom(object model, params string[] parameterNames)
        {
            var properties = model.GetType().GetProperties();
            var parameters = properties
                .Select(property => new SqlParameter(property.Name, property.GetValue(model, null)) { Direction = ParameterDirection.InputOutput});
            
            return parameterNames.Length == 0
                ? parameters 
                : parameters.Where(p => parameterNames.Contains(p.ParameterName));
        }

        private object ConvertValue(DataRow dataRow, PropertyInfo property)
        {
            var value = dataRow[property.Name];

            return value == DBNull.Value 
                ? null 
                : Convert.ChangeType(value, property.PropertyType, CultureInfo.InvariantCulture);
        }
    }
}