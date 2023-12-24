using Dislab.API.DbContexts;

namespace Dislab.API.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDapperContext _dapperContext;

        public UnitOfWork(IEmployeeRepository employeeRepository,
           IDapperContext dapperContext)
        {
            _employeeRepository = employeeRepository;
            _dapperContext = dapperContext;
        }
        public IEmployeeRepository EmployeeRepository => _employeeRepository ?? new EmployeeRepository(_dapperContext);
       
    }
}
