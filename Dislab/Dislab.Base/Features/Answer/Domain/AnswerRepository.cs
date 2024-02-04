using Dapper;
using Dislab.Base.DbContexts;
using Dislab.Base.Features.Answer.DTOS;
using Dislab.Base.Features.Answer.ViewModel;
using Dislab.Base.Features.Questions.Entities;
using System;

namespace Dislab.Base.Features.Answer.Entities
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly IDapperContext _context;

        public AnswerRepository(IDapperContext context)
        {
            _context = context;
        }

        public async Task<bool> InsertAsync(InsertAnswerDTO model)
        {
            try
            {
                var sqlQuery = @"INSERT INTO Answer (QuestionId , AnswerBody) VALUES (@QuestionId, @AnswerBody)";

                using var connection = _context.CreateConnection();
                connection.Open();
                var result = await connection.ExecuteAsync(sqlQuery, model);
                if(result > 0)
                {
                    return true;
                }
                return false;
            }
            catch(Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        public async Task<string> UpdateAsync(UpdateAnswerDTO model)
        {
            try
            {
                var sqlQuery = @"UPDATE Answer SET AnswerBody = @AnswerBody WHERE Id = @Id";

                using var connection = _context.CreateConnection();
                connection.Open();
                var result = await connection.QueryFirstOrDefaultAsync<long>(sqlQuery, model);
                if (result > 0)
                {
                    return "Success";
                }
                else
                {
                    return "Not Success";
                }
            }
            catch(Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        public async Task<IEnumerable<Answer>> GetAllAsync()
        {
            try
            {
                var sqlQuery = @"SELECT * FROM Answer";

                using var connection = _context.CreateConnection();
                connection.Open();
                var result = await connection.QueryAsync<Answer>(sqlQuery);
                return result;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        public async Task<Answer> GetByIdAsync(long id)
        {
            try
            {
                var sqlQuery = @"SELECT * FROM Answer WHERE Id = @id";

                using var connection = _context.CreateConnection();
                connection.Open();
                var result = await connection.QueryFirstOrDefaultAsync<Answer>(sqlQuery, new { id });
                return result;
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
                var sqlQuery = @"DELETE FROM Answer WHERE Id = @id";

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

       

       

       
    }
}
