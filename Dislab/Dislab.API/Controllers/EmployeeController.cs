using Dislab.API.Entities;
using Dislab.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dislab.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServices _employeeServices;

        public EmployeeController(IEmployeeServices employeeServices)
        {
            _employeeServices = employeeServices;
        }

        [HttpPost]
        public Employee Insert(Employee employee)
        {
            var result = _employeeServices.Insert(employee);
            return (result);

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _employeeServices.Delete(id);
            return Ok(new { IsSuccess = true, Message = "Employee Deleted Successfully." });
        }

        [HttpGet]
        public IEnumerable<Employee> GetAll(Employee employee)
        {
            var data = _employeeServices.GetAll(employee);
            return data;
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(long id)
        {
           var employee = _employeeServices.GetEmployeeById(id);
            return Ok(new { IsSuccess = true, 
                Message = "Employee  Successfully.",
                Data = employee
            });
        }

        [HttpPut("{employee}")]
        public IEnumerable<Employee> Update(Employee employee)
        {
            var data = _employeeServices.GetAll(employee);
            return data;

        }
    }
}
