using Dislab.Base.Data;
using Dislab.Base.Features.Questions.Entities;
using Dislab.Base.Features.Questions.ViewModels;

namespace Dislab.Base.Services
{

    public class QuestionService : IQuestionService
    {
        private readonly IUnitOfWork _unitOfWork;

        public QuestionService(IUnitOfWork uniteOfWork)
        {
            _unitOfWork = uniteOfWork;
        }

        public bool Insert(InsertQuestionVM model)
        {
            var result = _unitOfWork.AskQuestionRepository.Insert(model);
            return result;
        }

        public long Delete(long id)
        {
            return _unitOfWork.AskQuestionRepository.Delete(id);
        }

        public GetAllQuiestionsVM GetAll()
        {
            var result = new GetAllQuiestionsVM();
            result.Questions = _unitOfWork.AskQuestionRepository.GetAll();
            return result;
        }

        public IEnumerable<AskQuestion> GetByQuestionId(long id)
        {
            return _unitOfWork.AskQuestionRepository.GetByQuestionId(id);
        }

        public void Update(UpdateQuestionVM question)
        {
            _unitOfWork.AskQuestionRepository.Update(question);
        }
    }
}
