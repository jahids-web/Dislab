namespace Dislab.API.Base
{
    public interface IUnitOfWork
    {
        public IEmployeeRepository EmployeeRepository { get; }
    }
}
