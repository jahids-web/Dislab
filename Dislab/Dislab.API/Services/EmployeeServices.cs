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
        public Employee Create(Employee employee)
        {
            return _unitOfWork.EmployeeRepository.Create(employee);
        }

        public Employee Delete(long id)
        {
            return _unitOfWork.EmployeeRepository.Delete(id);
        }

        public IEnumerable<Employee> GetAll(Employee employee)
        {
            return _unitOfWork.EmployeeRepository.GetAll(employee);
        }

        public Employee GetEmployeeById(long id)
        {
            return _unitOfWork.EmployeeRepository.GetEmployeeById(id);
        }

        public Employee Update(Employee employee)
        {
            return _unitOfWork.EmployeeRepository.Update(employee);
        }
    }
}
