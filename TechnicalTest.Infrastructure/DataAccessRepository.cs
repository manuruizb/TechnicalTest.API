using Dapper;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;

namespace TechnicalTest.Infrastructure
{
    public class DataAccessRepository
    {
        private readonly string _connectionString;

        public DataAccessRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("dbConnection")!;
        }

        private IDbConnection _Connection
        {
            get
            {
                return new SqlConnection(_connectionString);
            }
        }

        internal async Task<TOutput> ExecFirst<TInput, TOutput>(string spName, TInput inputObject, CommandType command) where TInput : class
        {
            try
            {
                using (IDbConnection conn = _Connection)
                {
                    conn.Open();
                    var json = JsonConvert.SerializeObject(inputObject, Formatting.None);
                    var result = await conn.QueryFirstOrDefaultAsync<TOutput>(spName, inputObject == null ? null : new { json }, commandType: command);
                    conn.Close();
                    return result!;
                }
            }
            catch (Exception e)
            {
                throw new ArgumentException(message: e.Message);
            }
        }

        internal async Task<IEnumerable<TOutput>> Exec<TInput, TOutput>(string spName, TInput inputObject, CommandType command) where TInput : class
        {
            try
            {
                using (IDbConnection conn = _Connection)
                {
                    conn.Open();
                    var json = JsonConvert.SerializeObject(inputObject, Formatting.None);
                    var result = await conn.QueryAsync<TOutput>(spName, inputObject == null ? null : new { json }, commandType: command);
                    conn.Close();
                    return result!;
                }
            }
            catch (Exception e)
            {
                throw new ArgumentException(message: e.Message);
            }
        }
    }
}
