using Dapper;
using Dislab.Base.DbContexts;
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
        public bool Insert(InsertQuestionVM model)
        {
            try
            {
                var sqlQuesy = @"INSERT INTO AskQuestion (QuestionTitle, QuestionBody) VALUES (@QuestionTitle, @QuestionBody)";

                using var connection = _context.CreateConnection();
                connection.Open();
                var resutl = connection.Execute(sqlQuesy, model);
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

        public long Delete(long id)
        {
            try
            {
                var sqlQuery = @"DELETE FROM AskQuestion WHERE Id = @id";

                using var connection = _context.CreateConnection();
                connection.Open();
                var resutl = connection.Execute(sqlQuery, new { id });
                return resutl;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        public IEnumerable<AskQuestion> GetAll()
        {
            try
            {
                var sqlQuery = @"SELECT * FROM AskQuestion";

                using var connection = _context.CreateConnection();
                connection.Open();
                var questionCollection = new GetAllQuiestionsVM();
                questionCollection.Questions = connection.Query<AskQuestion>(sqlQuery);
                return questionCollection.Questions;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        public AskQuestion GetByQuestionId(long id)
        {
            try
            {
                var sqlQuery = @"SELECT * FROM AskQuestion WHERE Id = @id";

                using var connection = _context.CreateConnection();
                connection.Open();
                var result = connection.QueryFirstOrDefault<AskQuestion>(sqlQuery, new { id });
                return result;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        public void Update(UpdateQuestionVM question)
        {
            try
            {
                var sqlQuery = @"UPDATE AskQuestion SET QuestionTitle = @QuestionTitle, QuestionBody = @QuestionBody WHERE Id = @Id";

                using var connection = _context.CreateConnection();
                connection.Open();
                connection.Execute(sqlQuery, new { question.QuestionTitle, question.QuestionBody, question.Id });
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }
    }

}
