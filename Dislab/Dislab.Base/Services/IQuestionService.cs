using Dislab.Base.Features.Questions.DTOs;
using Dislab.Base.Features.Questions.Entities;
using Dislab.Base.Features.Questions.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dislab.Base.Services
{
    public interface IQuestionService
    {
        public Task<bool> InsertFEAsync(InsertQuestionVM model);
        public Task<string> UpdateFEAsync(QuestionDetailsVM model);
        public Task<long> DeleteFEAsync(long id);
        public Task<IEnumerable<GetAllQuiestionsVM>> GetAllFEAsync();
        public Task<QuestionDetailsVM> GetQuestionByFEIdAsync(long id);

        // Dashboard
        public Task<AdminQuestionVM> GetQuestionByIdAsync(long id);
        public Task<string> UpdateAsync(AdminQuestionVM model);
    }
}
