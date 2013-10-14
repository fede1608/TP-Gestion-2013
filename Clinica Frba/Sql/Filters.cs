using System.Collections.Generic;
using System.Linq;

namespace GrouponDesktop.Sql
{
    public class Filters
    {
        private readonly List<string> filters;

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

        public Filters AddLessThan(string columnName, string value)
        {
            this.filters.Add(string.Format("{0} < '{1}'", columnName, value));
            return this;
        }

        public Filters AddGreaterThan(string columnName, string value)
        {
            this.filters.Add(string.Format("{0} > '{1}'", columnName, value));
            return this;
        }

        public Filters AddLessThanOrEqual(string columnName, string value)
        {
            this.filters.Add(string.Format("{0} <= '{1}'", columnName, value));
            return this;
        }

        public Filters AddGreaterThanOrEqual(string columnName, string value)
        {
            this.filters.Add(string.Format("{0} >= '{1}'", columnName, value));
            return this;
        }

        public string Build()
        {
            if (!this.filters.Any())
                return string.Empty;

            return this.filters
                .Aggregate("WHERE", (acum, filter) => acum + " " + filter + " AND")
                .Substring(0, this.filters.Aggregate("WHERE", (acum, filter) => acum + " " + filter + " AND").Length - 4);
        }
    }
}