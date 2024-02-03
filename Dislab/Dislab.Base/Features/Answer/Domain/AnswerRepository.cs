using Dislab.Base.DbContexts;
using Dislab.Base.Features.Answer.ViewModel;

namespace Dislab.Base.Features.Answer.Entities
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly IDapperContext _context;

        public AnswerRepository(IDapperContext context)
        {
            _context = context;
        }

        public Task<long> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Answer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Answer> GetByAnswerIdAsync(long id)
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
