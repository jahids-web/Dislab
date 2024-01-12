using Dapper;
using Dislab.API.DbContexts;
using Dislab.API.Entities;
using System.Data.Common;

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
                var result = connection.ExecuteScalar<Employee>(sqlQuery, employee);/* commandType: System.Data.CommandType.StoredProcedure*/
                return result;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
            
        }

        public long Delete(long id)
        {
            try
            {
                var sqlQuery = @"DELETE FROM Employee WHERE Id = @id";

                using var connection = _context.CreateConnection();
                connection.Open();
                var result = connection.Execute(sqlQuery, new { id });
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
                var sqlQuery = @"SELECT * FROM Employee";

                using var connection = _context.CreateConnection();
                connection.Open();
                var result = connection.Query<Employee>(sqlQuery);
                return result;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        public IEnumerable<Employee> GetEmployeeById(long id)
        {
            try
            {
                var sqlQuery = @"SELECT * FROM Employee WHERE Id = @id";

                using var connection = _context.CreateConnection();
                connection.Open();
                var result = connection.Query<Employee>(sqlQuery, new { id });
                return result;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        public void Update(Employee employee)
        {
            try
            {
                var sqlQuery = @"UPDATE Employee SET Name = @Name,Email = @Email WHERE Id = @Id";

                using var connection = _context.CreateConnection();
                connection.Open();
                connection.Execute(sqlQuery, new { employee.Name, employee.Email, employee.Id });
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }



    }
}
