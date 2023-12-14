using Dislab.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dislab.API.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeServices _employeeServices;

        public EmployeeController(IEmployeeServices employeeServices) 
        {
            _employeeServices = employeeServices;
        }


    }
}
