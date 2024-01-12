using Dislab.API.Entities;

namespace Dislab.API.Base
{
    public interface IEmployeeRepository
    {
        public Employee Create(Employee employee);
        public void Update(Employee employee);
        public long Delete(long id);
        public IEnumerable<Employee> GetEmployeeById(long id);
        public IEnumerable<Employee> GetAll();

    }
}
