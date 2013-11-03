using System.Collections.Generic;
using System.Linq;

namespace Clinica_Frba.Sql
{
    public class Filters
    {
        private readonly List<string> filters;
        private string order;

        public Filters()
        {
            this.filters = new List<string>();
        }

        public Filters AddLike(string columnName, string value)
        {
            this.filters.Add(string.Format("{0} LIKE '%{1}%'", columnName, value));
            return this;
        }

        public Filters AddEqual(string columnName, string value)
        {
            this.filters.Add(string.Format("{0} = '{1}'", columnName, value));
            return this;
        }

        public Filters AddEqualField(string columnName, string value)
        {
            this.filters.Add(string.Format("{0} = {1}", columnName, value));
            return this;
        }

        public Filters AddNotEqual(string columnName, string value)
        {
            this.filters.Add(string.Format(" NOT {0} = {1}", columnName, SafeDBString(value)));
            return this;
        }

        public Filters AddLessThan(string columnName, string value)
        {
            this.filters.Add(string.Format("{0} < {1}", columnName, SafeDBString(value)));
            return this;
        }

        public Filters AddGreaterThan(string columnName, string value)
        {
            this.filters.Add(string.Format("{0} > {1}", columnName, SafeDBString(value)));
            return this;
        }

        public Filters AddLessThanOrEqual(string columnName, string value)
        {
            this.filters.Add(string.Format("{0} <= {1}", columnName, SafeDBString(value)));
            return this;
        }

        public Filters AddGreaterThanOrEqual(string columnName, string value)
        {
            this.filters.Add(string.Format("{0} >= {1}", columnName, SafeDBString(value)));
            return this;
        }


        private string SafeDBString(string inputValue)
        {
            return "'" + inputValue.Replace("'", "") + "'";
        }

        public string Build()
        {
            if (!this.filters.Any())
                return string.Empty;
            if (order==null)
            return this.filters
                .Aggregate("WHERE", (acum, filter) => acum + " " + filter + " AND")
                .Substring(0, this.filters.Aggregate("WHERE", (acum, filter) => acum + " " + filter + " AND").Length - 4);
            else
                return this.filters
                .Aggregate("WHERE", (acum, filter) => acum + " " + filter + " AND")
                .Substring(0, this.filters.Aggregate("WHERE", (acum, filter) => acum + " " + filter + " AND").Length - 4) + order;
        }

        public Filters AddOrderBy(string param, string orden)
        {
            order = string.Format(" ORDER BY {0} {1}", param, orden);
            return this;
        }

        public Filters AddIsNull(string columnName)
        {
            this.filters.Add(string.Format(" {0} IS NULL ", columnName));
            return this;
        }

        public Filters AddNotIsNull(string columnName)
        {
            this.filters.Add(string.Format(" NOT {0} IS NULL ", columnName));
            return this;
        }

        public Filters AddCustom(string p, string p_2, string p_3)
        {
            this.filters.Add(string.Format(" {0} {1} {2} ", p,p_2,p_3));
            return this;
        }
    }
}