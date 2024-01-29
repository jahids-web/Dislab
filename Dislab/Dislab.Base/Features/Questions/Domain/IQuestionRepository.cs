using Dislab.Base.Features.Questions.DTOs;
using Dislab.Base.Features.Questions.Entities;

namespace Dislab.Base.Features.Questions.Domain
{
    public interface IQuestionRepository
    {
        public Task<bool>InsertAsync(InsertQuestionDTO dto);
        public Task<string> UpdateAsync(UpdateQuestionDTO dto);
        public Task<long> DeleteAsync(long id);
        public Task<IEnumerable<AskQuestion>> GetAllAsync();
        public Task<AskQuestion> GetByQuestionIdAsync(long id);
    }

}
