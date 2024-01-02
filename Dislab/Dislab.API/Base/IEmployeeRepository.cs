using Dislab.API.Entities;

namespace Dislab.API.Base
{
    public interface IEmployeeRepository
    {
        public Employee Create(Employee employee);
        public Employee Update(Employee employee);
        public long Delete(long id);
        public long GetEmployeeById(long id);
        public IEnumerable<Employee> GetAll(Employee employee);
       
    }
}
