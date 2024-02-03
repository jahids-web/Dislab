﻿using Dislab.Base.Features.Answer.Entities;
using Dislab.Base.Features.Answer.ViewModel;

namespace Dislab.Base.Services
{
    public interface IAnswerService 
    {
        public Task<bool> InsertAsync(InsertAnswerVM model);
        public Task<string> UpdateAsync(UpdateAnswerVM model);
        public Task<long> DeleteAsync(long id);
        public Task<IEnumerable<Answer>> GetAllAsync();
        public Task<Answer> GetByQuestionIdAsync(long id);
    }
}
