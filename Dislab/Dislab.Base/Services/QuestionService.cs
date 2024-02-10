using AutoMapper;
using Dislab.Base.Data;
using Dislab.Base.Features.Questions.DTOs;
using Dislab.Base.Features.Questions.Entities;
using Dislab.Base.Features.Questions.ViewModels;
using System.Collections.Generic;

namespace Dislab.Base.Services
{

    public class QuestionService : IQuestionService 
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public QuestionService(IUnitOfWork uniteOfWork,
            IMapper mapper)
        {
            _unitOfWork = uniteOfWork;
            _mapper = mapper;
        }

        public async Task<bool> InsertAsync(InsertQuestionVM model)
        {
            var mappedObject =  _mapper.Map<InsertQuestionDTO>(model);
            var result = await _unitOfWork.AskQuestionRepository.InsertAsync(mappedObject);

            return result;
        }

        public async Task<long> DeleteAsync(long id)
        {
            var result = await _unitOfWork.AskQuestionRepository.DeleteAsync(id);
            return result;
        }

        public async Task<IEnumerable<Question>> GetAllAsync()
        {

            var result = await _unitOfWork.AskQuestionRepository.GetAllAsync();
            return result;
        }

        public async Task<QuestionDetailsVM> GetByQuestionIdAsync(long id)
        {
            var result = await _unitOfWork.AskQuestionRepository.GetByQuestionIdAsync(id);
            var mappedObject = _mapper.Map<QuestionDetailsVM>(result);
            return mappedObject;
        }

        public async Task<string> UpdateAsync(UpdateQuestionVM model)
        {
            var mappedObject = _mapper.Map<UpdateQuestionDTO>(model);
            var result = await _unitOfWork.AskQuestionRepository.UpdateAsync(mappedObject);
            return result;
        }
    }
}
