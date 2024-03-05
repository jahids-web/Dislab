using Dislab.Base.Features.Answer.Entities;
using Dislab.Base.Features.Answer.ViewModel;
using Dislab.Base.Features.Questions.ViewModels;

namespace Dislab.Base.Services
{
    public interface IAnswerService 
    {
        public Task<bool> InsertFEAsync(InsertAnswerVM model);
        public Task<string> UpdateFEAsync(UpdateAnswerVM model);
        public Task<long> DeleteFEAsync(long id);
        public Task<IEnumerable<GetAllAnswerVM>> GetAllAnswerAsync(long id);
        public Task<GetAnswerByIdVM> GetAnswerByIdFEAsync(long id);
        //DashBoard
        public Task<AdminAnswerVM> GetAnswerByIdAsync(long id);
        public Task<string> UpdateAsync(AdminAnswerVM model);
    }
}
