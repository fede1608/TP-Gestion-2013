using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace ClinicaSigkill.Sql
{
    public static class SqlParameterHelpers
    {
        public static SqlParameter FindByName(this SqlParameterCollection collection, string name)
        {
            return collection.Cast<SqlParameter>().Single(p => p.ParameterName == name);
        }
    }
    
    public class Runnable
    {
        private readonly string query;
        private readonly IList<SqlParameter> parameters;
        private readonly CommandType commandType;

        public IEnumerable<string> ParametersToReplace { get; set; }

        public IEnumerable<KeyValuePair<string, string>> Values
        {
            get { return this.parameters.Select(p => new KeyValuePair<string, string>(p.ParameterName, p.Value.ToString())); }
        }

        public static Runnable Query(string query)
        {
            return new Runnable(CommandType.Text, query);
        }

        public static Runnable StoreProcedure(string name, IEnumerable<SqlParameter> parameters)
        {
            return new Runnable(CommandType.StoredProcedure, name, parameters);
        }

        public static Runnable StoreProcedure(string name, IEnumerable<SqlParameter> parameters, IEnumerable<string> parametersToReplace)
        {
            var runnable = StoreProcedure(name, parameters);
            runnable.ParametersToReplace = parametersToReplace;

            return runnable;
        }

        private Runnable(CommandType commandType, string query, IEnumerable<SqlParameter> parameters)
        {
            this.query = query;
            this.parameters = parameters.ToList();
            this.commandType = commandType;
            this.ParametersToReplace = new string[1];
        }

        private Runnable(CommandType commandType, string query) : this(commandType, query, new SqlParameter[0]) { }

        private void SetupCommand(SqlCommand command)
        {
            command.Parameters.Clear();

            foreach (var p in parameters)
                command.Parameters.Add(p);

            command.CommandType = this.commandType;
            command.CommandText = this.query;
        }
        
        public void Run(SqlCommand command)
        {
            this.SetupCommand(command);
            command.ExecuteNonQuery();
            
            this.UpdateParametersValuesFrom(command.Parameters);
        }

        private void UpdateParametersValuesFrom(SqlParameterCollection sqlParameterCollection)
        {
            foreach (var parameter in this.parameters)
                parameter.Value = sqlParameterCollection.FindByName(parameter.ParameterName).Value;
        }

        public DataTable Select(SqlCommand command)
        {
            this.SetupCommand(command);

            var datatable = new DataTable();
            new SqlDataAdapter(command).Fill(datatable);

            return datatable;
        }

        public DataRow Single(SqlCommand command)
        {
            try
            {
                return this.Select(command).Rows[0];
            }
            catch (IndexOutOfRangeException e)
            {
                throw new NoResultsException(e);
            }
        }

        public void UpdateParametersFrom(Runnable executed)
        {
            var repeatedParameterNames = this.parameters
                .Where(p => this.ParametersToReplace.Contains(p.ParameterName))
                .Intersect(executed.parameters, new SqlParameterComparer())
                .Select(p => p.ParameterName);

            var parametersToUpdate = this.parameters.Where(parameter => repeatedParameterNames.Contains(parameter.ParameterName));

            foreach (var parameter in parametersToUpdate)
                parameter.Value = executed.GetParameterValue(parameter.ParameterName);
        }

        public object GetParameterValue(string parameterName)
        {
            return this.parameters
                .Single(p => p.ParameterName == parameterName)
                .Value;
        }
    }

    public class SqlParameterComparer : IEqualityComparer<SqlParameter>
    {
        public bool Equals(SqlParameter x, SqlParameter y)
        {
            return x.ParameterName == y.ParameterName;
        }

        public int GetHashCode(SqlParameter obj)
        {
            return obj.ParameterName.GetHashCode();
        }
    }

    public class NoResultsException : ApplicationException
    {
        public NoResultsException(Exception innerException) : base("La consulta no retorno resultados", innerException) {}
    }
}