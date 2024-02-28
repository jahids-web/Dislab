﻿using Dislab.Base.Features.Answer.DTOs;
using Dislab.Base.Features.Answer.DTOS;
using Dislab.Base.Features.Answer.ViewModel;

namespace Dislab.Base.Features.Answer.Entities
{
    public interface IAnswerRepository
    {
        public Task<bool> InsertFEAsync(InsertAnswerDTO model);
        public Task<string> UpdateFEAsync(UpdateAnswerDTO model);
        public Task<long> DeleteFEAsync(long id);
        public Task<IEnumerable<GetAllAnswerDTO>> GetAllFEAsync();
        public Task<GetAnswerByIdDTO> GetAnswerByIdFEAsync(long id);

        //DashBoard
        public Task<AdminAnswerDTO> GetAnswerByIdAsync(long id);
        public Task<string> UpdateAsync(AdminAnswerDTO model);
    }
}
