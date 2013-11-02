using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Clinica_Frba.Sql
{
    public class SqlRunner
    {
        private readonly string connectionString;

        public SqlRunner(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<KeyValuePair<string, string>> Run(IEnumerable<Runnable> runnables)
        {
            return this.Run(runnables.ToArray());
        }

        public IEnumerable<KeyValuePair<string, string>> Run(params Runnable[] runnables)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                this.PostConnectionAction(connection);

                using (var command = new SqlCommand { Connection = connection })
                    return this.ExecuteCommand(runnables, command);
            }
        }

        public DataTable Select(string query, params object[] parameters)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand { Connection = connection })
                {
                    var queryWithParameters = string.Format(query, parameters);
                    return Runnable.Query(queryWithParameters).Select(command);
                }
            }
        }

        public int executeNonQuery(string query, params object[] parameters)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                var queryWithParameters = string.Format(query, parameters);
                var command = new SqlCommand(queryWithParameters, connection);

                return command.ExecuteNonQuery();

            }
        }



        public int Insert(string query, params object[] parameters)
        {
            return this.executeNonQuery(query, parameters);
        }

        public int Update(string query, params object[] parameters)
        {
            return this.executeNonQuery(query, parameters);
        }

        public int Delete(string query, params object[] parameters)
        {
            return this.executeNonQuery(query, parameters);
        }

        public DataTable Select(string query, Filters filters)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand { Connection = connection })
                {
                    var queryWithParameters = query + " " + filters.Build();
                    return Runnable.Query(queryWithParameters).Select(command);
                }
            }
        }


        public DataRow Single(string query, Filters filters)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand { Connection = connection })
                {
                    var queryWithParameters = query + " " + filters.Build();
                    return Runnable.Query(queryWithParameters).Single(command);
                }
            }
        }

        public DataRow Single(string query, params string[] parameters)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand { Connection = connection })
                {
                    var queryWithParameters = string.Format(query, parameters);
                    return Runnable.Query(queryWithParameters).Single(command);
                }
            }
        }

        protected virtual IEnumerable<KeyValuePair<string, string>> ExecuteCommand(IEnumerable<Runnable> runnables, SqlCommand command)
        {
            return this.RunRunnables(runnables, command);
        }

        protected IEnumerable<KeyValuePair<string, string>> RunRunnables(IEnumerable<Runnable> runnables, SqlCommand command)
        {
            foreach (var runnable in runnables)
            {
                runnable.Run(command);
                this.UpdateParameters(runnable, runnables);
            }

            return runnables.SelectMany(r => r.Values);
        }

        private void UpdateParameters(Runnable executed, IEnumerable<Runnable> runnables)
        {
            foreach (var runnable in runnables.Except(new[] { executed }))
                runnable.UpdateParametersFrom(executed);
        }

        protected virtual void PostConnectionAction(SqlConnection connection) { }
    }
}