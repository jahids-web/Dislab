using Dislab.Base.Features.Answer.Entities;
using Dislab.Base.Features.Answer.ViewModel;
using Dislab.Base.Features.Questions.ViewModels;

namespace Dislab.Base.Services
{
    public interface IAnswerService 
    {
        public Task<bool> InsertAsync(InsertAnswerVM model);
        public Task<string> UpdateAsync(GetAnswerByIdVM model);
        public Task<long> DeleteAsync(long id);

        //public Task<IEnumerable<GetAllAnswerVM>> GetAllAsync();
        public Task<IEnumerable<Answer>> GetAllAsync();
        public Task<GetAnswerByIdVM> GetAnswerByIdAsync(long id);
    }
}
