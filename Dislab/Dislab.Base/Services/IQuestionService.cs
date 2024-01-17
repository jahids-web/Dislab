using Dislab.Base.Features.Questions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dislab.Base.Services
{
    public interface IQuestionService
    {
        public AskQuestion Insert(AskQuestion question);
        public void Update(AskQuestion question);
        public long Delete(long id);
        public IEnumerable<AskQuestion> GetAll();
        public IEnumerable<AskQuestion> GetByQuestionId(long id);
    }
}
