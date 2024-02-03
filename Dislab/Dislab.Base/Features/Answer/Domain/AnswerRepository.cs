using Dislab.Base.DbContexts;
using Dislab.Base.Features.Answer.Entities;
using Dislab.Base.Features.Answer.ViewModel;

namespace Dislab.Base.Features.Answer.Domain
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly IDapperContext _dapperContext;

        public AnswerRepository(IDapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public Task<long> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Entities.Answer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Entities.Answer> GetByQuestionIdAsync(long id)
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
