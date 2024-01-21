using Dislab.Base.Features.Questions.Entities;
using Dislab.Base.Features.Questions.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dislab.Base.Services
{
    public interface IQuestionService
    {
        public bool Insert(InsertQuestionVM model);
        public void Update(UpdateQuestionVM question);
        public long Delete(long id);
        public GetAllQuiestionsVM GetAll();
        public IEnumerable<AskQuestion> GetByQuestionId(long id);
    }
}
