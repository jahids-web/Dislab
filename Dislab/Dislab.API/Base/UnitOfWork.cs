namespace Dislab.API.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IEmployeeRepository _employeeRepository;
        public UnitOfWork(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public IEmployeeRepository EmployeeRepository { get; set ; }
    }
}
