using Dislab.API.Entities;

namespace Dislab.API.Services
{
    public interface IEmployeeServices
    {
        public Employee Insert(Employee employee);
        public void Update(Employee employee);
        public long Delete(long id);
        public IEnumerable<Employee> GetEmployeeById(long id);
        public IEnumerable<Employee> GetAll();
    }
}
