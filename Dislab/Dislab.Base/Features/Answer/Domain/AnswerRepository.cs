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
                var sqlQuery = @"INSERT INTO Answer (QuestionId, AnswerBody) VALUES (@QuestionId, @AnswerBody)";

                using var connection = _context.CreateConnection();
                connection.Open();
                var result = await connection.ExecuteAsync(sqlQuery, model);
                if (result > 0)
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

        public Task<long> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Answer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Answer> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateAsync(UpdateAnswerDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
