using Dislab.Base.Features.Answer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dislab.Base.Features.Questions.ViewModels
{
    public class QuestionDetailsVM
    {
        public long Id { get; set; }
        public string? QuestionTitle { get; set; }
        public string? QuestionBody { get; set; }

        public long QuestionId {  get; set; }
        public string? AnswerBody {  get; set; }

        public InsertAnswerVM GetAnswerVM()
        {
            var model = new InsertAnswerVM
            {
                QuestionId = QuestionId,
                AnswerBody = AnswerBody
            };
            return model;
        }
    }
}
