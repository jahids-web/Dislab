using Dapper;
using Dislab.Base.DbContexts;
using Dislab.Base.Features.Questions.DTOs;
using Dislab.Base.Features.Questions.Entities;
using Dislab.Base.Features.Questions.ViewModels;

namespace Dislab.Base.Features.Questions.Domain
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly IDapperContext _context;

        public QuestionRepository(IDapperContext context)
        {
            _context = context;
        }
        public async Task<bool> InsertAsync(InsertQuestionVM model)
        {
            try
            {
                var sqlQuesy = @"INSERT INTO AskQuestion (QuestionTitle, QuestionBody) VALUES (@QuestionTitle, @QuestionBody)";

                using var connection = _context.CreateConnection();
                connection.Open();
                var resutl = await connection.ExecuteAsync(sqlQuesy, model);
                if (resutl > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }

        }

        public async Task<long> DeleteAsync(long id)
        {
            try
            {
                var sqlQuery = @"DELETE FROM AskQuestion WHERE Id = @id";

                using var connection = _context.CreateConnection();
                connection.Open();
                var resutl = await connection.ExecuteAsync(sqlQuery, new { id });
                return resutl;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        public async Task<IEnumerable<AskQuestion>> GetAllAsync()
        {
            try
            {
                var sqlQuery = @"SELECT * FROM AskQuestion";

                using var connection = _context.CreateConnection();
                connection.Open();
                var result = await connection.QueryAsync<AskQuestion>(sqlQuery);
                return result;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        public async Task<AskQuestion> GetByQuestionIdAsync(long id)
        {
            try
            {
                var sqlQuery = @"SELECT * FROM AskQuestion WHERE Id = @id";

                using var connection = _context.CreateConnection();
                connection.Open();
                var result = await connection.QueryFirstOrDefaultAsync<AskQuestion>(sqlQuery, new { id });
                return result;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        public async Task<string> UpdateAsync(UpdateQuestionVM model)
        {
            try
            {
                var sqlQuery = @"UPDATE AskQuestion SET QuestionTitle = @QuestionTitle, QuestionBody = @QuestionBody WHERE Id = @Id";

                using var connection = _context.CreateConnection();
                connection.Open();
                var result = await connection.QueryFirstOrDefaultAsync<long>(sqlQuery, model);
                if(result > 0)
                {
                    return "Success";
                }
                else
                {
                    return "Not Success";
                }
                
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }
    }

}
