
namespace TechTalk.DBEngine
{
    using TechTalk.Framework;
    using Microsoft.Extensions.Configuration;
    using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using System.Text;
	using System.Threading.Tasks;
    using static Dapper.SqlMapper;
    public interface ISQLServerHandler
    {
		IDbConnection Connection { get; }
		IDbConnection OPTConnection { get; }

		Task<T> QueryFirstOrDefaultAsync<T>(IDbConnection connection, string sql, CommandType commandType, object ?parameters = null);  // return the Single row Data table values

		Task<T> QuerySingleAsync<T>(IDbConnection connection, string sql, CommandType commandType, object ?parameters = null); // return the Data table values

		Task<T> ExecuteScalarAsync<T>(IDbConnection connection, string sql, CommandType commandType, object ?parameters = null);  // return the object values

		Task ExecuteAsync(IDbConnection connection, string sql, CommandType commandType, object ?parameters = null); // Insert, Update and Delete

		Task<IEnumerable<T>> QueryAsync<T>(IDbConnection connection, string sql, CommandType commandType, object ?parameters = null);   // return the Single data table

		Task<GridReader> QueryMultipleAsync(IDbConnection connection, string sql, CommandType commandType, object ?parameters = null);  // return the Data Set  values

		Task<IDataReader> ExecuteReaderAsync(IDbConnection connection, string sql, CommandType commandType, object ?parameters = null);  // return the Data Set  values

        T FetchDatabyClass<T>(IDbConnection connection, string query,  CommandType commandType, DataValue dv = null);


    }
    public class SQLServerHandler : ISQLServerHandler
	{
		private readonly IConfiguration _configuration;
		public SQLServerHandler(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public IDbConnection Connection
		{
			get
			{
				var sqlconnection = new SqlConnection(_configuration.GetConnectionString("ConnString"));
				return sqlconnection;
			}
		}

		public IDbConnection OPTConnection
		{
			get
			{
				var sqlconnection = new SqlConnection(_configuration.GetConnectionString("OPTConnString"));
				return sqlconnection;
			}
		}

		public async Task<T> QueryFirstOrDefaultAsync<T>(IDbConnection connection, string sql, CommandType commandType, object ?parameters = null)
		{
			using (connection)
			{
				return await connection.QueryFirstOrDefaultAsync<T>(sql, parameters, commandType: commandType);
			}
		}

		public async Task<IEnumerable<T>> QueryAsync<T>(IDbConnection connection, string sql, CommandType commandType, object ?parameters = null)
		{
			using (connection)
			{
				return await connection.QueryAsync<T>(sql, parameters, commandType: commandType, commandTimeout: 600);
			}
		}

		public async Task<T> QuerySingleAsync<T>(IDbConnection connection, string sql, CommandType commandType, object ?parameters = null)
		{
			using (connection)
			{
				return await connection.QuerySingleAsync<T>(sql, parameters, commandType: commandType);
			}
		}

		public async Task<T> ExecuteScalarAsync<T>(IDbConnection connection, string sql, CommandType commandType, object ?parameters = null)
		{
			using (connection)
			{
				return await connection.ExecuteScalarAsync<T>(sql, parameters, commandType: commandType);
			}
		}

		public async Task ExecuteAsync(IDbConnection connection, string sql, CommandType commandType, object ?parameters = null)
		{
			using (connection)
			{
				await connection.ExecuteAsync(sql, parameters, commandType: commandType);
			}
		}

		public async Task<GridReader> QueryMultipleAsync(IDbConnection connection, string sql, CommandType commandType, object ?parameters = null)
		{
			return await connection.QueryMultipleAsync(sql, parameters, commandType: commandType, commandTimeout: 180);
		}

		public async Task<IDataReader> ExecuteReaderAsync(IDbConnection connection, string sql, CommandType commandType, object ?parameters = null)
		{
			return await connection.ExecuteReaderAsync(sql, parameters, commandType: commandType, commandTimeout: 180);
		}


        /// <summary>
        /// Get the .Net Data Type and return the corresponding SqlDbType Datatype
        /// </summary>
        /// <param name="fieldType">.Net DataType Enumerator</param>
        /// <returns>
        /// SqlDbType
        /// </returns>
        private SqlDbType GetSQLFieldType(EnumCommand.DataType fieldType)
        {
            switch (fieldType)
            {
                case EnumCommand.DataType.Boolean:
                    { return SqlDbType.Bit; }
                case EnumCommand.DataType.Byte:
                    { return SqlDbType.TinyInt; }
                case EnumCommand.DataType.Char:
                    { return SqlDbType.VarChar; }
                case EnumCommand.DataType.DateTime:
                    { return SqlDbType.DateTime; }
                case EnumCommand.DataType.TimeSpan:
                    { return SqlDbType.Timestamp; }
                case EnumCommand.DataType.Money:
                    { return SqlDbType.Money; }
                case EnumCommand.DataType.Double:
                case EnumCommand.DataType.Decimal:
                    { return SqlDbType.Decimal; }
                case EnumCommand.DataType.Single:
                    { return SqlDbType.Real; }
                case EnumCommand.DataType.Int:
                case EnumCommand.DataType.Int32:
                    { return SqlDbType.Int; }
                case EnumCommand.DataType.Int16:
                    { return SqlDbType.SmallInt; }
                case EnumCommand.DataType.Int64:
                    { return SqlDbType.BigInt; }
                case EnumCommand.DataType.Text:
                    { return SqlDbType.Text; }
                case EnumCommand.DataType.Xml:
                    { return SqlDbType.Xml; }
                case EnumCommand.DataType.Varchar:
                    { return SqlDbType.VarChar; }
                case EnumCommand.DataType.nVarchar:
                    { return SqlDbType.NVarChar; }
                case EnumCommand.DataType.ByteArray:
                    { return SqlDbType.VarBinary; }
                default:
                    { return SqlDbType.VarChar; }
            }
        }

        /// <summary>
        /// Add the parameter name, value and data type to the MySql Command Object
        /// </summary>
        /// <param name="dv">DataValue Object</param>
        /// <param name="query">The Insert,Update,Delete or Select Query</param>
        /// <param name="connection">The connection.</param>
        /// <param name="sqlType">Type of the SQL.</param>
        /// <returns>
        /// MySql Command
        /// </returns>
        private SqlCommand SetSqlCommand(DataValue dv, string query, SqlConnection connection, CommandType commandType)
        {
            SqlCommand Command = new SqlCommand(query, connection);
            if (dv != null)
            {
                string Param = "";
                string FieldName = "";
                Command.CommandType = commandType;
                foreach (DataValueBase dvBase in dv)
                {
                    try
                    {
                        FieldName = dvBase.FieldName;
                        Param = GetParameter(query, FieldName, commandType);
                        if (Param != string.Empty)
                        {
                            SqlParameter Parameter = new SqlParameter(Param, GetSQLFieldType(dvBase.FieldDataType));
                            if (dvBase.FieldDataType == EnumCommand.DataType.ByteArray)
                            {
                                if (string.IsNullOrEmpty(dvBase.FieldValue))
                                    Parameter.Value = DBNull.Value;
                                else
                                    Parameter.Value = Encoding.ASCII.GetBytes(dvBase.FieldValue);
                            }
                            else
                            {
                                if (dvBase.FieldValue != string.Empty)
                                    Parameter.Value = dvBase.FieldValue;
                                else
                                    Parameter.Value = DBNull.Value;
                            }
                            Command.Parameters.Add(Parameter);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            return Command;
        }

        /// <summary>
        /// Check a parameter is available in the query
        /// </summary>
        /// <param name="query">The Select,Insert,Update or Delete Query</param>
        /// <param name="fieldName">The Filed Name</param>
        /// <param name="sqlType">Type of the SQL.</param>
        /// <returns>
        /// if the query contains the field,it return the filed name other wise returns the empty
        /// </returns>
        private string GetParameter(string query, string fieldName, CommandType commandType)
        {
            string param = "@" + fieldName;
            if (commandType == CommandType.Text)
            {
                param = "@" + fieldName.ToUpper();
                param = query.ToUpper().Contains(param) ? param : string.Empty;
            }
            return param;
        }






        public T FetchDatabyClass<T>(IDbConnection connection, string query, CommandType commandType, DataValue dv = null)
        {
            T result;
            SqlCommand Command = null;
            SqlConnection Con = (SqlConnection)connection;
            try
            {


                if (dv == null)
                    Command = new SqlCommand(query, Con);
                else
                    Command = SetSqlCommand(dv, query, Con, commandType);


				Con.Open();

                //Command.Parameters.Add(parameters.t);

                Command.CommandTimeout = 0;
                try
                {
                    if (Con.State == ConnectionState.Open && Command != null)
                    {
                        using (var reader = Command.ExecuteXmlReader())
                        {
                            result = DataMapper.XmlReaderToObject<T>(reader);
                        }
                    }
                    else
                    {
                        result = default(T);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Con.Close();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Command != null)
                    Command.Dispose();
                Command = null;
                Con.Close();
            }
            return result;
        }


    }
}