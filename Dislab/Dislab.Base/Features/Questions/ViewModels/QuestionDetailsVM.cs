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

        public long QuestionId { get; set; }
        public long AnswerId { get; set; }
        public string? AnswerBody {  get; set; }

        public List<AnswerVM>? Answers { get; set; } //Ekane sob Answer list ante hobe loop e kaj korar juno

        public InsertAnswerVM GetInsertAnswerVM()
        {
            var model = new InsertAnswerVM
            {
                QuestionId = QuestionId,
                AnswerBody = AnswerBody
            };
            return model;
        }
        
        public UpdateAnswerVM GetUpdateAnswerVm()
        {
            var model = new UpdateAnswerVM
            {
                Id = AnswerId,
                AnswerBody = AnswerBody
            };
            return model;
        }

    }
}
