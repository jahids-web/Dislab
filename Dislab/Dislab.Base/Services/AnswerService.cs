using Dislab.Base.Data;
using Dislab.Base.Features.Answer.Entities;
using Dislab.Base.Features.Answer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dislab.Base.Services
{
    public class AnswerService : IAnswerService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AnswerService(IUnitOfWork unitOfWork) 
        { 
            _unitOfWork = unitOfWork;
        }

        public Task<long> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Answer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Answer> GetByQuestionIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertAsync(InsertAnswerVM model)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateAsync(UpdateAnswerVM model)
        {
            throw new NotImplementedException();
        }
    }
}
