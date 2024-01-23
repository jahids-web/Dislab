using Dislab.Base.Features.Questions.Entities;
using Dislab.Base.Features.Questions.ViewModels;

namespace Dislab.Base.Features.Questions.Domain
{
    public interface IQuestionRepository
    {
        public Task<bool>InsertAsync(InsertQuestionVM model);
        public Task<string> UpdateAsync(UpdateQuestionVM question);
        public Task<long> DeleteAsync(long id);
        public Task<IEnumerable<AskQuestion>> GetAllAsync();
        public Task<AskQuestion> GetByQuestionIdAsync(long id);
    }

}
