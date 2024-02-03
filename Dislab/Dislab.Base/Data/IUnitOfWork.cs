using Dislab.Base.Features.Answer.Domain;
using Dislab.Base.Features.Answer.Entities;
using Dislab.Base.Features.Questions.Domain;

namespace Dislab.Base.Data
{
    public interface IUnitOfWork
    {
        public IQuestionRepository AskQuestionRepository { get; }

        public IAnswerRepository AnswerRepository { get; }
    }
}
