using AutoMapper;
using Dislab.Base.Data;
using Dislab.Base.Features.Answer.ViewModel;
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

        public async Task<bool> InsertFEAsync(InsertQuestionVM model)
        {
            var mappedObject =  _mapper.Map<InsertQuestionDTO>(model);
            var result = await _unitOfWork.AskQuestionRepository.InsertFEAsync(mappedObject);

            return result;
        }

        public async Task<long> DeleteFEAsync(long id)
        {
            var result = await _unitOfWork.AskQuestionRepository.DeleteFEAsync(id);
            return result;
        }

        public async Task<IEnumerable<GetAllQuiestionsVM>> GetAllFEAsync()
        {
            var result = await _unitOfWork.AskQuestionRepository.GetAllFEAsync();
            var mappedObject = _mapper.Map<IEnumerable<GetAllQuiestionsVM>>(result);
            return mappedObject;
        }

        public async Task<QuestionDetailsVM> GetQuestionByFEIdAsync(long id)
        {
            var result = await _unitOfWork.AskQuestionRepository.GetQuestionByFEIdAsync(id);
            var mappedObject = _mapper.Map<QuestionDetailsVM>(result);
            return mappedObject;
        }

        public async Task<string> UpdateFEAsync(QuestionDetailsVM model)
        {
            var mappedObject = _mapper.Map<QuestionDetailsDTO>(model);
            var result = await _unitOfWork.AskQuestionRepository.UpdateFEAsync(mappedObject);
            return result;
        }

        //Dashboard 
        public async Task<AdminQuestionVM> GetQuestionByIdAsync(long id)
        {
            var result = await _unitOfWork.AskQuestionRepository.GetQuestionByIdAsync(id);
            var mappedObject = _mapper.Map<AdminQuestionVM>(result);
            return mappedObject;
        }

        public async Task<string> UpdateAsync(AdminQuestionVM model)
        {
            var mappedObject = _mapper.Map<AdminQuestionDTO>(model);
            var result = await _unitOfWork.AskQuestionRepository.UpdateAsync(mappedObject);
            return result;
        }

        
    }
}
