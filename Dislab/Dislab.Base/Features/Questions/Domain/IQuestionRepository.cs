using Dislab.Base.Features.Questions.DTOs;
using Dislab.Base.Features.Questions.Entities;
using Dislab.Base.Features.Questions.ViewModels;

namespace Dislab.Base.Features.Questions.Domain
{
    public interface IQuestionRepository
    {
        public Task<bool>InsertAsync(InsertQuestionDTO model);
        public Task<string> UpdateAsync(UpdateQuestionDTO model);
        public Task<long> DeleteAsync(long id);
        public Task<IEnumerable<Question>> GetAllAsync();
        public Task<QuestionDetailsDTO> GetByQuestionIdAsync(long id);
    }

}
