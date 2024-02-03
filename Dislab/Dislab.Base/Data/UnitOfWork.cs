using Dislab.Base.DbContexts;
using Dislab.Base.Features.Answer.Entities;
using Dislab.Base.Features.Questions.Domain;

namespace Dislab.Base.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IQuestionRepository _askQuestionRepository;
        private readonly IAnswerRepository _answerRepository;
        private readonly IDapperContext _dapperContext;

        public UnitOfWork(
            IQuestionRepository askQuestionRepository, 
            IAnswerRepository answerRepository, 
            IDapperContext dapperContext)
        {
            _askQuestionRepository = askQuestionRepository;
            _answerRepository = answerRepository;
            _dapperContext = dapperContext;
        }


        public IQuestionRepository AskQuestionRepository => _askQuestionRepository ?? new QuestionRepository(_dapperContext);

        public IAnswerRepository AnswerRepository => _answerRepository ?? new AnswerRepository(_dapperContext);
    }
}
