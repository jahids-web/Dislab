using Dislab.Base.Features.Questions.Domain;

namespace Dislab.Base.Data
{
    public interface IUnitOfWork
    {
        public IQuestionRepository AskQuestionRepository { get; }
    }
}
