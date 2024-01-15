using System.Data;
using TechnicalTest.Domain;

namespace TechnicalTest.Infrastructure
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IDataAccessRepository _dataAccessRepository;
        public EmployeeRepository(IDataAccessRepository dataAccessRepository)
        {
            _dataAccessRepository = dataAccessRepository;
        }

        public async Task CreateEmployee(Employee employee)
        {
            await _dataAccessRepository.ExecuteFirst<Employee>("SP_CreateEmployee", employee, CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _dataAccessRepository.Execute<Employee>("SP_GetAllEmployees", null!, CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<Employee>> GetEmployeeByDocumentOrName(string Search)
        {
            return await _dataAccessRepository.Execute<Employee>("SP_GetEmployeeByDocumentOrName", new { Search }, CommandType.StoredProcedure);
        }

        public async Task UpdateEmployee(Employee employee)
        {
            await _dataAccessRepository.ExecuteFirst<Employee>("SP_UpdateEmployee", employee, CommandType.StoredProcedure);
        }
    }
}
