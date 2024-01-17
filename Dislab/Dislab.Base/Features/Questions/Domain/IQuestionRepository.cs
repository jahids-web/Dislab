using Dislab.Base.Features.Questions.Entities;

namespace Dislab.Base.Features.Questions.Domain
{
    public interface IQuestionRepository
    {
        public AskQuestion Insert(AskQuestion question);
        public void Update(AskQuestion question);
        public long Delete(long id);
        public IEnumerable<AskQuestion> GetAll();
        public IEnumerable<AskQuestion> GetByQuestionId(long id);
    }

}
