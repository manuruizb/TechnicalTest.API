using Microsoft.AspNetCore.Mvc;
using TechnicalTest.Domain;

namespace TechnicalTest.Application
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _employeeService;
        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        [Route("GetAllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            var res = await _employeeService.GetAllEmployees();
            return new OkObjectResult(res);
        }

        [HttpGet]
        [Route("GetEmployeeByDocumentOrName")]
        public async Task<IActionResult> GetEmployeeByDocumentOrName([FromQuery] string Search)
        {
            var res = await _employeeService.GetEmployeeByDocumentOrName(Search);
            return new OkObjectResult(res);
        }

        [HttpPost]
        [Route("CreateEmployee")]
        public async Task<IActionResult> CreateEmployee([FromBody] Employee employee)
        {
            var res = await _employeeService.CreateEmployee(employee);
            return new OkObjectResult(res);
        }

        [HttpPut]
        [Route("UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployee([FromBody] Employee employee)
        {
            var res = await _employeeService.UpdateEmployee(employee);
            return new OkObjectResult(res);
        }
    }
}
