using Dislab.Base.Features.Questions.Entities;
using Dislab.Base.Features.Questions.ViewModels;

namespace Dislab.Base.Features.Questions.Domain
{
    public interface IQuestionRepository
    {
        public bool Insert(InsertQuestionVM model);
        public void Update(UpdateQuestionVM question);
        public long Delete(long id);
        public IEnumerable<AskQuestion> GetAll();
        public AskQuestion GetByQuestionId(long id);
    }

}
