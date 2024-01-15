using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTest.Domain;

namespace TechnicalTest.Infrastructure
{
    public class GenericRepository : DataAccessRepository, IDataAccessRepository
    {
        public GenericRepository(IConfiguration configuration) : base(configuration) { }
        public async Task<IEnumerable<TOutput>> Execute<TOutput>(string storedProcedureKey, object obj, CommandType commandType)
        {
            return await Exec<object, TOutput>(storedProcedureKey, obj, commandType);
        }

        public async Task<TOutput> ExecuteFirst<TOutput>(string storedProcedureKey, object obj, CommandType commandType)
        {
            return await ExecFirst<object, TOutput>(storedProcedureKey, obj, commandType);
        }
    }
}
