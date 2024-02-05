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

        public Task<long> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Answer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Answer> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateAsync(UpdateAnswerVM model)
        {
            throw new NotImplementedException();
        }
    }
}
