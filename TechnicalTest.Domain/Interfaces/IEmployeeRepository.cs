namespace TechnicalTest.Domain
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<IEnumerable<Employee>> GetEmployeeByDocumentOrName(string Search);
        Task CreateEmployee(Employee employee);
        Task UpdateEmployee(Employee employee);
    }
}
