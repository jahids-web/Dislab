using Dislab.Base.Features.Answer.DTOS;
using Dislab.Base.Features.Answer.ViewModel;

namespace Dislab.Base.Features.Answer.Entities
{
    public interface IAnswerRepository
    {
        public Task<bool> InsertAsync(InsertAnswerDTO model);
        public Task<string> UpdateAsync(UpdateAnswerDTO model);
        public Task<long> DeleteAsync(long id);
        public Task<IEnumerable<Answer>> GetAllAsync();
        public Task<Answer> GetByIdAsync(long id);
    }
}
