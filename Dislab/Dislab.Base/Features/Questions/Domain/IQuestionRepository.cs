using Dislab.Base.Features.Questions.DTOs;
using Dislab.Base.Features.Questions.Entities;
using Dislab.Base.Features.Questions.ViewModels;

namespace Dislab.Base.Features.Questions.Domain
{
    public interface IQuestionRepository
    {
        public Task<bool>InsertFEAsync(InsertQuestionDTO model);
        public Task<string> UpdateFEAsync(QuestionDetailsDTO model);
        public Task<long> DeleteFEAsync(long id);
        public Task<IEnumerable<GetAllQuiestionsDTO>> GetAllFEAsync();
        public Task<QuestionDetailsDTO> GetQuestionByFEIdAsync(long id);

        //
        public Task<AdminQuestionDTO> GetQuestionByIdAsync(long id);
        public Task<string> UpdateAsync(AdminQuestionDTO model);
    }

}
