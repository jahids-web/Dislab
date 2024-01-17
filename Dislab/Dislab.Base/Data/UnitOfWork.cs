using Dislab.Base.DbContexts;
using Dislab.Base.Features.Questions.Domain;

namespace Dislab.Base.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IQuestionRepository _askQuestionRepository;
        private readonly IDapperContext _dapperContext;

        public UnitOfWork(IQuestionRepository askQuestionRepository, IDapperContext dapperContext)
        {
            _askQuestionRepository = askQuestionRepository;
            _dapperContext = dapperContext;
        }


        public IQuestionRepository AskQuestionRepository => _askQuestionRepository ?? new QuestionRepository(_dapperContext);
    }
}
