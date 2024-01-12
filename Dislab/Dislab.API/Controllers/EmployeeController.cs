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

        [HttpPost ("InsertEmployee")]
        public Employee Insert(Employee employee)
        {
            var result = _employeeServices.Insert(employee);
            return (result);

        }

        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(long id)
        {
            _employeeServices.Delete(id);
            return Ok(new { IsSuccess = true, Message = "Employee Deleted Successfully." });
        }

        [HttpGet("GetEmployeeBy/{id}")]
        public IActionResult GetEmployeeById(long id)
        {
            var employee = _employeeServices.GetEmployeeById(id);
            return Ok(new
            {
                IsSuccess = true,
                Message = "Employee  Successfully.",
                Data = employee
            });
        }

        [HttpPut("UpdateEmployeeBy/{id}")]
        public void Update(Employee employee)
        {
             _employeeServices.Update(employee);
        }

        [HttpGet("GetAllEmployee")]
        public IEnumerable<Employee> GetAll()
        {
            var data = _employeeServices.GetAll();
            return data;
        }
    }
}
