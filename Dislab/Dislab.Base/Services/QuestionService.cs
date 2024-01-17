using Dislab.Base.Data;
using Dislab.Base.Features.Questions.Entities;

namespace Dislab.Base.Services
{

    public class QuestionService : IQuestionService
    {
        private readonly IUnitOfWork _unitOfWork;

        public QuestionService(IUnitOfWork uniteOfWork)
        {
            _unitOfWork = uniteOfWork;
        }

        public AskQuestion Insert(AskQuestion question)
        {
            var result = _unitOfWork.AskQuestionRepository.Insert(question);
            return result;
        }

        public long Delete(long id)
        {
            return _unitOfWork.AskQuestionRepository.Delete(id);
        }

        public IEnumerable<AskQuestion> GetAll()
        {
            return _unitOfWork.AskQuestionRepository.GetAll();
        }

        public IEnumerable<AskQuestion> GetByQuestionId(long id)
        {
            return _unitOfWork.AskQuestionRepository.GetByQuestionId(id);
        }

        public void Update(AskQuestion question)
        {
            _unitOfWork.AskQuestionRepository.Update(question);
        }
    }
}
