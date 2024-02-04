using AutoMapper;
using Dislab.Base.Data;
using Dislab.Base.Features.Answer.DTOS;
using Dislab.Base.Features.Answer.Entities;
using Dislab.Base.Features.Answer.ViewModel;
using Dislab.Base.Features.Questions.DTOs;
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
        private readonly IMapper _mapper;

        public AnswerService(IUnitOfWork unitOfWork , IMapper mapper) 
        { 
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> InsertAsync(InsertAnswerVM model)
        {
            var mappedObject = _mapper.Map<InsertAnswerDTO>(model);
            var result = await _unitOfWork.AnswerRepository.InsertAsync(mappedObject);
            return result;
        }

        public async Task<string> UpdateAsync(UpdateAnswerVM model)
        {
            var mappedObject = _mapper.Map<UpdateAnswerDTO>(model);
            var result = await _unitOfWork.AnswerRepository.UpdateAsync(mappedObject);
            return result;
        }

        public async Task<IEnumerable<Answer>> GetAllAsync()
        {
            var result = await _unitOfWork.AnswerRepository.GetAllAsync();
            return result;
        }

        public async Task<Answer> GetByIdAsync(long id)
        {
            var result = await _unitOfWork.AnswerRepository.GetByIdAsync(id);
            return result;

        }

        public async Task<long> DeleteAsync(long id)
        {
            var result = await _unitOfWork.AnswerRepository.DeleteAsync(id);
            return result;
        }

      

    }
}
