using TechnicalTest.Domain;

namespace TechnicalTest.Application
{
    public class EmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Result<List<Employee>>> GetAllEmployees()
        {
            try
            {
                var res = await _employeeRepository.GetAllEmployees();
                return new Result<List<Employee>>()
                {
                    Data = res.ToList(),
                    Success = true
                };
            }
            catch (Exception e)
            {
                throw new ArgumentException(message: e.Message);
            }
        }

        public async Task<Result<List<Employee>>> GetEmployeeByDocumentOrName(string Search)
        {
            try
            {
                var res = await _employeeRepository.GetEmployeeByDocumentOrName(Search);
                return new Result<List<Employee>>()
                {
                    Data = res.ToList(),
                    Success = true
                };
            }
            catch (Exception e)
            {
                throw new ArgumentException(message: e.Message);
            }
        }

        public async Task<Result<bool>> CreateEmployee(Employee employee)
        {
            try
            {
                await _employeeRepository.CreateEmployee(employee);
                return new Result<bool>()
                {
                    Data = true,
                    Success = true
                };
            }
            catch (Exception e)
            {
                throw new ArgumentException(message: e.Message);
            }
        }

        public async Task<Result<bool>> UpdateEmployee(Employee employee)
        {
            try
            {
                await _employeeRepository.UpdateEmployee(employee);
                return new Result<bool>()
                {
                    Data = true,
                    Success = true
                };
            }
            catch (Exception e)
            {
                throw new ArgumentException(message: e.Message);
            }
        }
    }
}
