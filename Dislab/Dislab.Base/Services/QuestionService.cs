using Dislab.Base.Data;
using Dislab.Base.Features.Questions.Entities;
using Dislab.Base.Features.Questions.ViewModels;
using System.Collections.Generic;

namespace Dislab.Base.Services
{

    public class QuestionService : IQuestionService
    {
        private readonly IUnitOfWork _unitOfWork;

        public QuestionService(IUnitOfWork uniteOfWork)
        {
            _unitOfWork = uniteOfWork;
        }

        public async Task<bool> InsertAsync(InsertQuestionVM model)
        {
            var result = await _unitOfWork.AskQuestionRepository.InsertAsync(model);
            return result;
        }

        public async Task<long> DeleteAsync(long id)
        {
            var result = await _unitOfWork.AskQuestionRepository.DeleteAsync(id);
            return result;
        }

        public async Task<IEnumerable<AskQuestion>> GetAllAsync()
        {
            var result = await _unitOfWork.AskQuestionRepository.GetAllAsync();
            return result;
        }

        public async Task<AskQuestion> GetByQuestionIdAsync(long id)
        {
            var result = await _unitOfWork.AskQuestionRepository.GetByQuestionIdAsync(id);
            return result;
        }

        public async Task<string> UpdateAsync(UpdateQuestionVM question)
        {
            var result = await _unitOfWork.AskQuestionRepository.UpdateAsync(question);
            return result;
        }
    }
}
