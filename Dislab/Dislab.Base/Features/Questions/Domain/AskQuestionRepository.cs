﻿using Dapper;
using Dislab.Base.DbContexts;
using Dislab.Base.Features.Questions.Entities;

namespace Dislab.Base.Features.Questions.Domain
{
    public class AskQuestionRepository : IAskQuestionRepository
    {
        private readonly IDapperContext _context;

        public AskQuestionRepository(IDapperContext context)
        {
            _context = context;
        }
        public AskQuestion Insert(AskQuestion question)
        {
            try
            {
                var sqlQuesy = @"INSERT INTO AskQuestion (QuestionTitle, QuestionBody) VALUES (@QuestionTitle, @QuestionBody)";

                using var connection = _context.CreateConnection();
                connection.Open();
                var resutl = connection.ExecuteScalar<AskQuestion>(sqlQuesy, question);
                return resutl;
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
                var result = connection.Query<AskQuestion>(sqlQuery);
                return result;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        public IEnumerable<AskQuestion> GetByQuestionId(long id)
        {
            try
            {
                var sqlQuery = @"SELECT * FROM AskQuestion WHERE Id = @id";

                using var connection = _context.CreateConnection();
                connection.Open();
                var result = connection.Query<AskQuestion>(sqlQuery, new { id });
                return result;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        public void Update(AskQuestion question)
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