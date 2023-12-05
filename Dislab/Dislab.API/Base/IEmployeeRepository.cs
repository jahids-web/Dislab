using Dislab.API.Entities;

namespace Dislab.API.Base
{
    public interface IEmployeeRepository
    {
        public void Create(Employee employee);
        public Employee Update(Employee employee);
        public void Delete(long id);
        public Employee GetEmployeeById(long id);
        public List<Employee> GetAll(Employee employee);
    }
}
