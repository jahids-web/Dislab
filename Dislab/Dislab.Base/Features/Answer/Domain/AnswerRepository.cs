using Dapper;
using Dislab.Base.DbContexts;
using Dislab.Base.Features.Answer.DTOs;
using Dislab.Base.Features.Answer.DTOS;
using Dislab.Base.Features.Answer.ViewModel;
using Dislab.Base.Features.Questions.DTOs;

namespace Dislab.Base.Features.Answer.Entities
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly IDapperContext _context;

        public AnswerRepository(IDapperContext context)
        {
            _context = context;
        }

        public async Task<bool> InsertFEAsync(InsertAnswerDTO model)
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

        public async Task<long> DeleteFEAsync(long id)
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

        public async Task<IEnumerable<GetAllAnswerDTO>> GetAllAnswerAsync(long id)
        {
            try
            {
                //var sqlQuery = @"Select * from Answer where QuestionId = @id";

                var sqlQuery = @"SELECT 
                    A.*,
                    Q.QuestionTitle
                FROM 
                    Answer A
                JOIN 
                    Question Q ON A.QuestionId = Q.Id
                WHERE 
                    A.QuestionId = @id;";

                using var connection = _context.CreateConnection();
                connection.Open();
                var result = await connection.QueryAsync<GetAllAnswerDTO>(sqlQuery , new { id });
                return result;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        public async Task<GetAnswerByIdDTO> GetAnswerByIdFEAsync(long id)
        {
            try
            {
                var sqlQuery = @"SELECT * FROM Answer WHERE Id = @id";

                using var connection = _context.CreateConnection();
                connection.Open();
                var result = await connection.QueryFirstOrDefaultAsync<GetAnswerByIdDTO>(sqlQuery, new { id });
                return result;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        public async Task<string> UpdateFEAsync(UpdateAnswerDTO model)
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
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        //DashBoard
        public async Task<AdminAnswerDTO> GetAnswerByIdAsync(long id)
        {
            try
            {
                var sqlQuery = @"SELECT * FROM Answer WHERE Id = @id";

                using var connection = _context.CreateConnection();
                connection.Open();
                var result = await connection.QueryFirstOrDefaultAsync<AdminAnswerDTO>(sqlQuery, new { id });
                return result;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        public async Task<string> UpdateAsync(AdminAnswerDTO model)
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
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }
    }
}
