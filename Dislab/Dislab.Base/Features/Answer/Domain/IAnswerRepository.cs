using Dislab.Base.Features.Answer.DTOs;
using Dislab.Base.Features.Answer.DTOS;
using Dislab.Base.Features.Answer.ViewModel;

namespace Dislab.Base.Features.Answer.Entities
{
    public interface IAnswerRepository
    {
        public Task<bool> InsertAsync(InsertAnswerDTO model);
        public Task<string> UpdateAsync(GetAnswerByIdDTO model);
        public Task<long> DeleteAsync(long id);
        public Task<IEnumerable<Answer>> GetAllAsync();
        public Task<GetAnswerByIdDTO> GetAnswerByIdAsync(long id);
    }
}
