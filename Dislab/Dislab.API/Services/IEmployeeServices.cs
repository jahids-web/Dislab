using Dislab.API.Entities;

namespace Dislab.API.Services
{
    public interface IEmployeeServices
    {
        public Employee Insert(Employee employee);
        public Employee Update(Employee employee);
        public long Delete(long id);
        public long GetEmployeeById(long id);
        public IEnumerable<Employee> GetAll(Employee employee);
    }
}
