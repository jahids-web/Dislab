using Dapper;
using Dislab.API.DbContexts;
using Dislab.API.Entities;
using Microsoft.Data.SqlClient;
using System;

namespace Dislab.API.Base
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IDapperContext _context;

        public EmployeeRepository(IDapperContext context)
        {
            _context = context;
        }
        public void Create(Employee employee)
        {
            try
            {
                
                var sqlQuery = @"INSERT INTO Employee (Name, Email) VALUES (@Name, @Email)";

                using var connection = _context.CreateConnection();
                connection.Open();
                connection.Execute(sqlQuery, employee);
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        public void Delete(long id)
        {
            try
            {

                var sqlQuery = @"DELETE FROM Employee WHERE Id = @id";

                using var connection = _context.CreateConnection();
                connection.Open();
                connection.Execute(sqlQuery);
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        public List<Employee> GetAll(Employee employee)
        {
            try
            {

                var sqlQuery = @"SELETE * FROM Employee";

                using var connection = _context.CreateConnection();
                connection.Open();
                List<Employee> employeeCollection = connection.Query<Employee>(sqlQuery, employee);
                return employeeCollection;
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
                connection.Execute(sqlQuery, id);
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
            throw new InvalidOperationException();
        }

        public Employee Update(Employee employee)
        {
            try
            {

                var sqlQuery = @"UPDATE Employee SET Name = @Name, Email = @Email";

                using var connection = _context.CreateConnection();
                connection.Open();
                connection.Execute(sqlQuery, employee);
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
            return employee;
        }
    }
}
