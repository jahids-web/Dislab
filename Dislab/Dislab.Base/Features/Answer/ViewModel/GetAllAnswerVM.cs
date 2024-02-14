using Dislab.Base.Features.Questions.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dislab.Base.Features.Answer.ViewModel
{
    public class GetAllAnswerVM
    {
        public long Id { get; set; }
        public long QuestionId { get; set; }
        public string? AnswerBody { get; set; }
    }
}
