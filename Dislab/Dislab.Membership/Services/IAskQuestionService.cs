using Dislab.Base.Data;
using Dislab.Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dislab.Membership.Services
{
    public interface IAskQuestionService
    {
        public AskQuestion Insert(AskQuestion question);
        public void Update(AskQuestion question);
        public long Delete(long id);
        public IEnumerable<AskQuestion> GetAll();
        public IEnumerable<AskQuestion> GetByQuestionId(long id);
    }

    public class AskQuestionService : IAskQuestionService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AskQuestionService(IUnitOfWork uniteOfWork)
        {
            _unitOfWork = uniteOfWork;
        }

        public AskQuestion Insert(AskQuestion question)
        {
            var result = _unitOfWork.AskQuestionRepository.Create(question);
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
