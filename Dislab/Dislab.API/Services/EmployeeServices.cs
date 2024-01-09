using Dislab.API.Base;
using Dislab.API.Entities;

namespace Dislab.API.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Employee Insert(Employee employee)
        {
            var result = _unitOfWork.EmployeeRepository.Create(employee);
            return result; 
        }

        public long Delete(long id)
        {
            return _unitOfWork.EmployeeRepository.Delete(id);
        }

        public IEnumerable<Employee> GetAll(Employee employee)
        {
            return _unitOfWork.EmployeeRepository.GetAll(employee);
        }

        public IEnumerable<Employee> GetEmployeeById(long id)
        {
            return _unitOfWork.EmployeeRepository.GetEmployeeById(id);
        }

        public void Update(Employee employee)
        {
           _unitOfWork.EmployeeRepository.Update(employee);
        }


    }
}
