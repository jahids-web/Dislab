using AutoMapper;
using Dislab.Base.Data;
using Dislab.Base.Features.Answer.DTOs;
using Dislab.Base.Features.Answer.DTOS;
using Dislab.Base.Features.Answer.ViewModel;

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

        public async Task<bool> InsertFEAsync(InsertAnswerVM model)
        {
            var mappedObject = _mapper.Map<InsertAnswerDTO>(model);
            var result = await _unitOfWork.AnswerRepository.InsertFEAsync(mappedObject);
            return result;
        }

        public async Task<IEnumerable<GetAllAnswerVM>> GetAllAnswerAsync(long id)
        {
            var result = await _unitOfWork.AnswerRepository.GetAllAnswerAsync(id);
            var mappedObject = _mapper.Map<IEnumerable<GetAllAnswerVM>>(result);
            return mappedObject;
        }

        public async Task<GetAnswerByIdVM> GetAnswerByIdFEAsync(long id)
        {
            var result = await _unitOfWork.AnswerRepository.GetAnswerByIdFEAsync(id);
            var mappedObject = _mapper.Map<GetAnswerByIdVM>(result);
            return mappedObject;
        }

        public async Task<string> UpdateFEAsync(UpdateAnswerVM model)
        {
            var mappedObject = _mapper.Map<UpdateAnswerDTO>(model);
            var result = await _unitOfWork.AnswerRepository.UpdateFEAsync(mappedObject);
            return result;
        }

        public async Task<long> DeleteFEAsync(long id)
        {
            var result = await _unitOfWork.AnswerRepository.DeleteFEAsync(id);
            return result;
        }

        //DashBoard
        public async Task<AdminAnswerVM> GetAnswerByIdAsync(long id)
        {
            var result = await _unitOfWork.AnswerRepository.GetAnswerByIdAsync(id);
            var mappedObject = _mapper.Map<AdminAnswerVM>(result);
            return mappedObject;
        }

        public async Task<string> UpdateAsync(AdminAnswerVM model)
        {
            var mappedObject = _mapper.Map<AdminAnswerDTO>(model);
            var result = await _unitOfWork.AnswerRepository.UpdateAsync(mappedObject);
            return result;
        }


    }
}
