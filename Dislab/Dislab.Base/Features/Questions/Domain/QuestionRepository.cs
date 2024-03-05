using Dapper;
using Dislab.Base.DbContexts;
using Dislab.Base.Features.Questions.DTOs;

namespace Dislab.Base.Features.Questions.Domain
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly IDapperContext _context;

        public QuestionRepository(IDapperContext context)
        {
            _context = context;
        }
        public async Task<bool> InsertFEAsync(InsertQuestionDTO model)
        {
            try
            {
                var sqlQuesy = @"INSERT INTO Question (QuestionTitle, QuestionBody) VALUES (@QuestionTitle, @QuestionBody)";

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

        public async Task<long> DeleteFEAsync(long id)
        {
            try
            {
                var sqlQuery = @"DELETE FROM Question WHERE Id = @id";

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

        public async Task<IEnumerable<GetAllQuiestionsDTO>> GetAllFEAsync()
        {
            try
            {
                var sqlQuery = @"SELECT * FROM Question";

                using var connection = _context.CreateConnection();
                connection.Open();
                var result = await connection.QueryAsync<GetAllQuiestionsDTO>(sqlQuery);
                return result;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        public async Task<QuestionDetailsDTO> GetQuestionByFEIdAsync(long id)
        {
            try
            {
                var sqlQuery = @"
                SELECT Q.Id, Q.QuestionTitle, Q.QuestionBody, A.Id AS AnswerId, A.AnswerBody 
                FROM Question AS Q
                INNER JOIN Answer AS A ON Q.Id = A.QuestionId
                WHERE Q.Id = @Id";

                var questionQuery = @"
                SELECT QuestionTitle, QuestionBody
                FROM Question
                WHERE Id = @id";

                using var connection = _context.CreateConnection();
                connection.Open();

                var result = await connection.QueryFirstOrDefaultAsync<QuestionDetailsDTO>(sqlQuery, new { id });

                if (result is null)
                {
                    var withoutAnswer = await connection.QueryFirstOrDefaultAsync<QuestionDetailsDTO>(questionQuery, new { id });
                    return withoutAnswer;
                }

                return result;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        public async Task<string> UpdateFEAsync(QuestionDetailsDTO model)
        {
            try
            {
                var sqlQuery = @"UPDATE Question SET QuestionTitle = @QuestionTitle, QuestionBody = @QuestionBody WHERE Id = @Id";
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

        // Dashboard 
        public async Task<AdminQuestionDTO> GetQuestionByIdAsync(long id)
        {
            try
            {
                var sqlQuery = @"SELECT * FROM Question WHERE Id = @id";
                using var connection = _context.CreateConnection();
                connection.Open();
                var result = await connection.QueryFirstOrDefaultAsync<AdminQuestionDTO>(sqlQuery, new { id });
                return result;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        public async Task<string> UpdateAsync(AdminQuestionDTO model)
        {
            try
            {
                var sqlQuery = @"UPDATE Question SET QuestionTitle = @QuestionTitle, QuestionBody = @QuestionBody WHERE Id = @Id";
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
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

    }

}
