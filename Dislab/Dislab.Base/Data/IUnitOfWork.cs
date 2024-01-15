using Dislab.Base.Features.Questions.Domain;

namespace Dislab.Base.Data
{
    public interface IUnitOfWork
    {
        public IAskQuestionRepository AskQuestionRepository { get; }
    }
}
