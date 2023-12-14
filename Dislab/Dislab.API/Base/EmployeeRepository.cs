using Dapper;
using Dislab.API.DbContexts;
using Dislab.API.Entities;

namespace Dislab.API.Base
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IDapperContext _context;

        public EmployeeRepository(IDapperContext context)
        {
            _context = context;
        }
        public Employee Create(Employee employee)
        {
            try
            {
                
                var sqlQuery = @"INSERT INTO Employee (Name, Email) VALUES (@Name, @Email)";

                using var connection = _context.CreateConnection();
                connection.Open();
                var result = connection.QuerySingle<Employee>(sqlQuery, employee);
                return result;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
           
        }

        public Employee Delete(long id)
        {
            try
            {

                var sqlQuery = @"DELETE FROM Employee WHERE Id = @id";

                using var connection = _context.CreateConnection();
                connection.Open();
                var result = connection.QuerySingle(sqlQuery);
                return result;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        public IEnumerable<Employee> GetAll(Employee employee)
        {
            try
            {

                var sqlQuery = @"SELETE * FROM Employee";

                using var connection = _context.CreateConnection();
                connection.Open();
                var result =  connection.Query<Employee>(sqlQuery, employee);
                return result;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        public Employee GetEmployeeById(long id)
        {
            try
            {

                var sqlQuery = @"SELECT * FROM Employee WHERE Id = @id";

                using var connection = _context.CreateConnection();
                connection.Open();
                var result = connection.QuerySingle<Employee>(sqlQuery, id);
                return result;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
            
        }

        public Employee Update(Employee employee)
        {
            try
            {
                var sqlQuery = @"UPDATE Employee SET Name = @Name, Email = @Email";

                using var connection = _context.CreateConnection();
                connection.Open();
                var result = connection.QuerySingle<Employee>(sqlQuery, employee);
                return result;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }
    }
}
