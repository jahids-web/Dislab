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
        public Employee Delete(long id)
        {
            return _employeeServices.Delete(id);
        }

        [HttpGet]
        public IEnumerable<Employee> GetAll(Employee employee)
        {
            var data = _employeeServices.GetAll(employee);
            return data;
        }

        [HttpGet("{id}")]
        public Employee GetEmployeeById(long id)
        {
            return _employeeServices.GetEmployeeById(id);
        }

        [HttpPut("{employee}")]
        public Employee Update(Employee employee)
        {
            return _employeeServices.Update(employee);
        }
    }
}
