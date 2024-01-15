using System.Data;

namespace TechnicalTest.Domain
{
    public interface IDataAccessRepository
    {
        Task<TOutput> ExecuteFirst<TOutput>(string storedProcedureKey, object obj, CommandType commandType);
        Task<IEnumerable<TOutput>> Execute<TOutput>(string storedProcedureKey, object obj, CommandType commandType);
    }
}
