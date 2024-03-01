using Dislab.Base.Features.Answer.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dislab.Base.Features.Questions.ViewModels
{
    public class QuestionDetailsVM
    {
        public long Id { get; set; }

        //[Required]
        //[StringLength(150, ErrorMessage = "Question Title can't be more than 150 characters.")]
        public string? QuestionTitle { get; set; }

        //[Required]
        //[StringLength(2000, ErrorMessage = "Question Description can't be more than 2000 characters.")]
        public string? QuestionBody { get; set; }

        public long QuestionId { get; set; }
        public long AnswerId { get; set; }

        //[Required]
        //[StringLength(3000, ErrorMessage = "Answer Body can't be more than 3000 characters.")]
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
