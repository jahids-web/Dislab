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
        public Task<bool> InsertAsync(InsertQuestionVM model);
        public Task<string> UpdateAsync(UpdateQuestionVM model);
        public Task<long> DeleteAsync(long id);
        public Task<IEnumerable<Question>> GetAllAsync();
        public Task<QuestionDetailsVM> GetByQuestionIdAsync(long id);
    }
}
